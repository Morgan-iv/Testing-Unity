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

#if UNITY_2017_2_OR_NEWER
using UnityEngine.XR;
#else
using XRSettings = UnityEngine.VR.VRSettings;
#endif  // UNITY_2017_2_OR_NEWER

/// Используется для повторного включения только контроллера, необходимого для сцен, у которых нет четкого направления вперед.
/// Детали: https://developers.google.com/vr/distribute/daydream/design-requirements#UX-D6
///
/// Работает путем смещения ориентации преобразования, когда происходит повторный приемник для коррекции
/// изменение ориентации, вызванное событием recenter.
///
/// Использование: Поместите на родителя камеры, у которой должна быть исправлена ориентация.
public class GvrRecenterOnlyController : MonoBehaviour {
  private Quaternion lastAppliedYawCorrection = Quaternion.identity;
  private Quaternion yawCorrection = Quaternion.identity;

  void Update() {
    if (GvrControllerInput.State != GvrConnectionState.Connected) {
      return;
    }

    // Daydream загружается только на устройстве, а не в редакторе.
#if UNITY_ANDROID && !UNITY_EDITOR
    if (XRSettings.loadedDeviceName != GvrSettings.VR_SDK_DAYDREAM) {
      return;
    }
#endif

    if (GvrControllerInput.Recentered) {
      ApplyYawCorrection();
      return;
    }

#if UNITY_EDITOR
    // Совместимость для мгновенного предварительного просмотра.
    if (Gvr.Internal.InstantPreview.Instance != null &&
      Gvr.Internal.InstantPreview.Instance.enabled &&
      (GvrControllerInput.HomeButtonDown || GvrControllerInput.HomeButtonState)) {
      return;
    }
#else  // !UNITY_EDITOR
    if (GvrControllerInput.HomeButtonDown || GvrControllerInput.HomeButtonState) {
      return;
    }
#endif  // UNITY_EDITOR

    yawCorrection = GetYawCorrection();
  }

  void OnDisable() {
    yawCorrection = Quaternion.identity;
    RemoveLastYawCorrection();
  }

  private void ApplyYawCorrection() {
    RemoveLastYawCorrection();
    transform.localRotation = transform.localRotation * yawCorrection;
    lastAppliedYawCorrection = yawCorrection;
  }

  private void RemoveLastYawCorrection() {
    transform.localRotation =
      transform.localRotation * Quaternion.Inverse(lastAppliedYawCorrection);
    lastAppliedYawCorrection = Quaternion.identity;
  }

  private Quaternion GetYawCorrection() {
    Quaternion headRotation = GvrVRHelpers.GetHeadRotation();
    Vector3 euler = headRotation.eulerAngles;
    return lastAppliedYawCorrection * Quaternion.Euler(0.0f, euler.y, 0.0f);
  }
}
