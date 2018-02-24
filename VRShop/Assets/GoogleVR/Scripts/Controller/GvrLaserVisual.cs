// Copyright 2017 Google Inc. Все права защищены.
//
// Лицензируется по лицензии Apache, версия 2.0 («Лицензия»);
// вы не можете использовать этот файл, кроме как в соответствии с Лицензией.
// Вы можете получить копию Лицензии на
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Если это не предусмотрено действующим законодательством или не согласовано в письменной форме, программное обеспечение
// распространяется по лицензии, распространяется на основе «AS IS»,
// БЕЗ ГАРАНТИЙ ИЛИ УСЛОВИЙ ЛЮБОГО ВИДА, явных или подразумеваемых.
// См. Лицензию на конкретном языке, определяющем разрешения и
// ограничения по лицензии.

using System;
using UnityEngine;
using UnityEngine.Assertions;

/// Визуализирует лазер и сетку с помощью LineRenderer и Quad.
/// Предоставляет функции для настройки конечной точки лазера,
/// и зажимает лазер и сетку на основе максимальных расстояний.
[RequireComponent(typeof(LineRenderer))]
public class GvrLaserVisual : MonoBehaviour, IGvrArmModelReceiver {
  /// Used to position the reticle at the current position.
  [Tooltip("Used to position the reticle at the current position.")]
  public GvrControllerReticleVisual reticle;

  /// Конечная точка визуала не обязательно должна быть направлена вперед в направлении лазера.
   /// Это особенно справедливо в режимах Camera и Hybrid Raycast. В этом случае
   /// лазер и контроллер повернуты к граничной точке. Эта ссылка используется для управления
   /// вращение контроллера.
  [Tooltip("Used to rotate the controller to face the current position.")]
  public Transform controller;

  /// Цвет лазерной указки, включая альфа-прозрачность.
  [Tooltip("Start color of the laser pointer including alpha transparency.")]
  public Color laserColor = new Color(1.0f, 1.0f, 1.0f, 0.25f);

  /// Цвет лазерной указки, включая альфа-прозрачность.
  [Tooltip("End color of the laser pointer including alpha transparency.")]
  public Color laserColorEnd = new Color(1.0f, 1.0f, 1.0f, 0.0f);

  ///Максимальное расстояние лазера (метров).
  [Tooltip("Maximum distance of the laser (meters).")]
  [Range(0.0f, 20.0f)]
  public float maxLaserDistance = 1.0f;

  /// Скорость, с которой текущая позиция перемещается в позицию цели.
  [Tooltip("The rate that the current position moves towards the target position.")]
  public float lerpSpeed = 20.0f;

  /// Если targetPosition больше этого порога, тогда
   /// позиция меняется немедленно, а не ерпинг.
   /// =============================================
   /// If the targetPosition is greater than this threshold, then
  /// the position changes immediately instead of lerping.
  [Tooltip("If the target position is greater than this threshold, then the position changes " +
    "immediately instead of lerping.")]
  public float lerpThreshold = 1.0f;

  /// Это в основном используется для режима Hybrid Raycast (подробности в _GvrBasePointer_), чтобы предотвратить
   /// несоответствие между лазером и сеткой при использовании компонента «камера» луча.
  [Tooltip("Determines if the laser will shrink when it isn't facing in the forward direction " +
    "of the transform.")]
  public bool shrinkLaser = true;

  /// Сумма для сжатия лазера при полном сжатии.
  [Range(0.0f, 1.0f)]
  [Tooltip("Amount to shrink the laser when it is fully shrunk.")]
  public float shrunkScale = 0.2f;

  /// Начинаем сжимать лазер, когда угол между трансформированием и сеткой
   /// больше этого значения.
  [Range(0.0f, 15.0f)]
  [Tooltip("Begin shrinking the laser when the angle between transform.forward and the reticle " +
    "is greater than this value.")]
  public float beginShrinkAngleDegrees = 0.0f;

  /// Закончить сжимание лазера, когда угол между преобразованием. И сеткой
   /// больше этого значения.
  [Range(0.0f, 15.0f)]
  [Tooltip("Finish shrinking the laser when the angle between transform.forward and the reticle " +
    "is greater than this value.")]
  public float endShrinkAngleDegrees = 2.0f;

  private const float LERP_CLAMP_THRESHOLD = 0.02f;

  public GvrBaseArmModel ArmModel { get; set; }

  /// Ссылка на визуализатор линии лазера.
  public LineRenderer Laser { get; private set; }

  /// Дополнительный делегат для настройки того, как currentPosition вычисляется на основе расстояния.
   /// Если не задано, currentPosition определяется на основе расстояния, умноженного на форвардную
   /// направление преобразования, добавленное к положению преобразования.
  public delegate Vector3 GetPointForDistanceDelegate(float distance);

  public GetPointForDistanceDelegate GetPointForDistanceFunction { get; set; }

  protected float shrinkRatio;
  protected float targetDistance;
  protected float currentDistance;
  protected Vector3 currentPosition;
  protected Vector3 currentLocalPosition;
  protected Quaternion currentLocalRotation;

  /// Установите расстояние лазера.
   /// Зажимает расстояние от лазера и сетки.
   ///
   /// ** расстояние ** целевое расстояние от указателя для рисования визуального.
   /// ** немедленно ** Если значение true, расстояние изменяется немедленно. В противном случае он будет омрачаться.
  public virtual void SetDistance(float distance, bool immediate = false) {
    targetDistance = distance;
    if (immediate) {
      currentDistance = targetDistance;
    }

    if (targetDistance > lerpThreshold) {
      currentDistance = targetDistance;
    }
  }

  public float CurrentDistance {
    get { return currentDistance; }
  }

  protected virtual void Awake() {
    Laser = GetComponent<LineRenderer>();
  }

  protected virtual void LateUpdate() {
    UpdateCurrentPosition();
    UpdateControllerOrientation();
    UpdateReticlePosition();
    UpdateLaserEndPoint();
    UpdateLaserAlpha();
  }

  protected virtual void UpdateCurrentPosition() {
    if (currentDistance != targetDistance) {
      float speed = GetSpeed();
      currentDistance = Mathf.Lerp(currentDistance, targetDistance, speed);
      float diff = Mathf.Abs(targetDistance - currentDistance);
      if (diff < LERP_CLAMP_THRESHOLD) {
        currentDistance = targetDistance;
      }
    }

    if (GetPointForDistanceFunction != null) {
      currentPosition = GetPointForDistanceFunction(currentDistance);
    } else {
      Vector3 origin = transform.position;
      currentPosition = origin + (transform.forward * currentDistance);
    }

    currentLocalPosition = transform.InverseTransformPoint(currentPosition);
    currentLocalRotation = Quaternion.FromToRotation(Vector3.forward, currentLocalPosition);
  }

  protected virtual void UpdateControllerOrientation() {
    if (controller == null) {
      return;
    }

    controller.localRotation = currentLocalRotation;
  }

  protected virtual void UpdateReticlePosition() {
    if (reticle == null) {
      return;
    }

    reticle.transform.position = currentPosition;
  }

  protected virtual void UpdateLaserEndPoint() {
    if (Laser == null) {
      return;
    }

    Vector3 laserStartPoint = Vector3.zero;
    Vector3 laserEndPoint;

    if (controller != null) {
      Vector3 worldPosition = transform.position;
      Vector3 rotatedPosition = controller.InverseTransformPoint(worldPosition);
      rotatedPosition = currentLocalRotation * rotatedPosition;
      laserStartPoint = controller.TransformPoint(rotatedPosition);
      laserStartPoint = transform.InverseTransformPoint(laserStartPoint);
    }

    laserEndPoint = Vector3.ClampMagnitude(currentLocalPosition, maxLaserDistance);

    if (shrinkLaser) {
      // Рассчитаем угол поворота в градусах.
      float angle = Vector3.Angle(Vector3.forward, currentLocalPosition);

     // Рассчитаем коэффициент усадки на основе угла.
      float shrinkAngleDelta = endShrinkAngleDegrees - beginShrinkAngleDegrees;
      float clampedAngle = Mathf.Clamp(angle - beginShrinkAngleDegrees, 0.0f, shrinkAngleDelta);
      shrinkRatio = clampedAngle / shrinkAngleDelta;

      // Вычислим коэффициент сжатия.
      float shrinkCoeff = GvrMathHelpers.EaseOutCubic(shrunkScale, 1.0f, 1.0f - shrinkRatio);

      // Вычислим конечное расстояние лазера.
      Vector3 diff = laserStartPoint - currentLocalPosition;
      Vector3 dir = diff.normalized;
      float dist = Mathf.Min(diff.magnitude, maxLaserDistance) * shrinkCoeff;

      // Обновляем начальные и конечные точки лазера.
      laserEndPoint = currentLocalPosition;
      laserStartPoint = laserEndPoint + (dir * dist);
    }

    Laser.useWorldSpace = false;
    Laser.SetPosition(0, laserStartPoint);
    Laser.SetPosition(1, laserEndPoint);
  }

  protected virtual void UpdateLaserAlpha() {
    float alpha = ArmModel != null ? ArmModel.PreferredAlpha : 1.0f;

    Color finalStartColor = Color.Lerp(Color.clear, laserColor, alpha);
    Color finalEndColor = laserColorEnd;

    // При сжатии лазера цвета инвертируются на основе коэффициента усадки.
     // Это значит, что оперение лазера идет в правильном направлении.
     // ==================================================
     // If shrinking the laser, the colors are inversed based on the shrink ratio.
    // This is to ensure that the feathering of the laser goes in the right direction.
    if (shrinkLaser) {
      float colorRatio = GvrMathHelpers.EaseOutCubic(0.0f, 1.0f, shrinkRatio);
      finalEndColor = Color.Lerp(finalEndColor, finalStartColor, colorRatio);
      finalStartColor = Color.Lerp(finalStartColor, laserColorEnd, colorRatio);
    }

    Laser.startColor = finalStartColor;
    Laser.endColor = finalEndColor;
  }

  protected virtual float GetSpeed() {
    return lerpSpeed > 0.0f ? lerpSpeed * Time.unscaledDeltaTime : 1.0f;
  }
}
