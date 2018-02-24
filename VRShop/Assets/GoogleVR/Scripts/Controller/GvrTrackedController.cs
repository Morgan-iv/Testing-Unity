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

using UnityEngine;
using System.Collections;

/// Представляет объект, отслеживаемый вводом контроллера.
///
/// Обновляет положение и вращение объекта, чтобы аппроксимировать контроллер, используя
/// a_GvrBaseArmModel_ и передает _GvrBaseArmModel_ всем _IGvrArmModelReceivers_
/// под этим объектом.
///
/// Управляет активным состоянием отслеживаемого контроллера на основе состояния подключения контроллера.
public class GvrTrackedController : MonoBehaviour {
  [SerializeField]
  [Tooltip("Arm model used to control the pose (position and rotation) of the object, " +
    "and to propagate to children that implement IGvrArmModelReceiver.")]
  private GvrBaseArmModel armModel;

  [SerializeField]
  [Tooltip("Is the object's active status determined by the controller connection status.")]
  private bool isDeactivatedWhenDisconnected = true;

  /// Ручная модель, используемая для управления позой (положением и вращением) объекта и для распространения на
   /// дети, которые реализуют IGvrArmModelReceiver.
  public GvrBaseArmModel ArmModel {
    get {
      return armModel;
    }
    set {
      if (armModel == value) {
        return;
      }

      armModel = value;
      PropagateArmModel();
    }
  }

 /// Статус активного объекта определяется состоянием соединения с контроллером.
  public bool IsDeactivatedWhenDisconnected {
    get {
      return isDeactivatedWhenDisconnected;
    }
    set {
      if (isDeactivatedWhenDisconnected == value) {
        return;
      }

      isDeactivatedWhenDisconnected = value;

      if (isDeactivatedWhenDisconnected) {
        OnControllerStateChanged(GvrControllerInput.State, GvrControllerInput.State);
      }
    }
  }

  public void PropagateArmModel() {
    IGvrArmModelReceiver[] receivers =
      GetComponentsInChildren<IGvrArmModelReceiver>(true);

    for (int i = 0; i < receivers.Length; i++) {
      IGvrArmModelReceiver receiver = receivers[i];
      receiver.ArmModel = armModel;
    }
  }

  void Awake() {
    GvrControllerInput.OnStateChanged += OnControllerStateChanged;
  }

  void OnEnable() {
    // Обновление позиции с помощью OnPostControllerInputUpdated.
     // Таким образом, положение и вращение будут корректными для всего кадра
     // так что неважно, в какой порядок вызывается запрос.
    GvrControllerInput.OnPostControllerInputUpdated += OnPostControllerInputUpdated;

    /// Заставить позу немедленно обновляться, если контроллер не обновляется до следующего
     /// время рендеринга фрейма.
    UpdatePose();

    /// Проверить состояние контроллера сразу, когда этот скрипт включен.
    OnControllerStateChanged(GvrControllerInput.State, GvrControllerInput.State);
  }

  void OnDisable() {
    GvrControllerInput.OnPostControllerInputUpdated -= OnPostControllerInputUpdated;
  }

  void Start() {
    PropagateArmModel();
    OnControllerStateChanged(GvrControllerInput.State, GvrControllerInput.State);
  }

  void OnDestroy() {
    GvrControllerInput.OnStateChanged -= OnControllerStateChanged;
  }

  private void OnPostControllerInputUpdated() {
    UpdatePose();
  }

  private void OnControllerStateChanged(GvrConnectionState state, GvrConnectionState oldState) {
    if (isDeactivatedWhenDisconnected && enabled) {
      gameObject.SetActive(state == GvrConnectionState.Connected);
    }
  }

  private void UpdatePose() {
    if (armModel == null) {
      return;
    }

    transform.localPosition = ArmModel.ControllerPositionFromHead;
    transform.localRotation = ArmModel.ControllerRotationFromHead;
  }

#if UNITY_EDITOR
  /// Если поле сериализации «armModel» изменяется во время воспроизведения приложения
   ///, используя инспектор в редакторе, тогда нам нужно вызвать PropagateArmModel
   /// для обеспечения обновления всех дочерних элементов IGvrArmModelReceiver.
   /// Вне редактора это невозможно, потому что модель руки может измениться только тогда, когда
   /// вызывается Setter, который автоматически вызывает PropagateArmModel.
  void OnValidate() {
    if (Application.isPlaying && isActiveAndEnabled) {
      PropagateArmModel();
      OnControllerStateChanged(GvrControllerInput.State, GvrControllerInput.State);
    }
  }
#endif  // UNITY_EDITOR

}
