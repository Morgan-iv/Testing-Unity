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

// Контроллер недоступен для версий Unity без
// Собственная интеграция с GVR.

using UnityEngine;
using UnityEngine.EventSystems;

/// Реализация GvrBasePointer для визуализации лазерного указателя.
/// Этот скрипт должен быть прикреплен к объекту контроллера.
/// Лазерная визуала важна, чтобы помочь пользователям найти свой курсор
///, когда он не находится непосредственно в их поле зрения.
[RequireComponent(typeof(GvrLaserVisual))]
public class GvrLaserPointer : GvrBasePointer {
  [Tooltip("Distance from the pointer that raycast hits will be detected.")]
  public float maxPointerDistance = 20.0f;

  [Tooltip("Distance from the pointer that the reticle will be drawn at when hitting nothing.")]
  public float defaultReticleDistance = 20.0f;

  [Tooltip("By default, the length of the laser is used as the CameraRayIntersectionDistance. " +
    "Set this field to a non-zero value to override it.")]
  public float overrideCameraRayIntersectionDistance;

/// Процент сетки сетки, которая показывает сетку.
   /// Остальная сетка сетки прозрачна.
  private const float RETICLE_VISUAL_RATIO = 0.1f;

  public GvrLaserVisual LaserVisual { get; private set; }

  private bool isHittingTarget;

  public override float MaxPointerDistance {
    get {
      return maxPointerDistance;
    }
  }

  public override float CameraRayIntersectionDistance {
    get {
      if (overrideCameraRayIntersectionDistance != 0.0f) {
        return overrideCameraRayIntersectionDistance;
      }

      return LaserVisual != null ?
        LaserVisual.maxLaserDistance : overrideCameraRayIntersectionDistance;
    }
  }

  public override void OnPointerEnter(RaycastResult raycastResult, bool isInteractive) {
    LaserVisual.SetDistance(raycastResult.distance);
    isHittingTarget = true;
  }

  public override void OnPointerHover(RaycastResult raycastResult, bool isInteractive) {
    LaserVisual.SetDistance(raycastResult.distance);
    isHittingTarget = true;
  }

  public override void OnPointerExit(GameObject previousObject) {
    // Don't set the distance immediately.
    // If we exit/enter an object on the same frame, then SetDistance
    // will be called twice which could cause an issue with lerping the reticle.
    // If we don't re-enter a new object, the distance will be set in Update.
    isHittingTarget = false;
  }

  public override void OnPointerClickDown() {
  }

  public override void OnPointerClickUp() {
  }

  public override void GetPointerRadius(out float enterRadius, out float exitRadius) {
    if (LaserVisual.reticle != null) {
      float reticleScale = LaserVisual.reticle.transform.localScale.x;

      // Фиксированный размер для ввода радиуса во избежание мерцания.
       // Это приведет к некоторой незначительной изменчивости, основанной на расстоянии объекта
       // из камеры и оптимизирован для среднего случая.
      enterRadius = LaserVisual.reticle.sizeMeters * 0.5f * RETICLE_VISUAL_RATIO;

      // Динамический размер для радиуса выхода.
       // Всегда правильно, потому что мы знаем точку пересечения объекта и можем
       // поэтому используйте правильный радиус, основанный на расстоянии объекта от камеры.
      exitRadius = reticleScale * LaserVisual.reticle.ReticleMeshSizeMeters * RETICLE_VISUAL_RATIO;
    } else {
      enterRadius = 0.0f;
      exitRadius = 0.0f;
    }
  }

  void Awake() {
    LaserVisual = GetComponent<GvrLaserVisual>();
  }

  protected override void Start() {
    base.Start();
    LaserVisual.GetPointForDistanceFunction = GetPointAlongPointer;
    LaserVisual.SetDistance(defaultReticleDistance, true);
  }

  void Update() {
    if (isHittingTarget) {
      return;
    }

    LaserVisual.SetDistance(defaultReticleDistance);
  }
}
