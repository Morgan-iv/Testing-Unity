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
using System;
using System.Collections;

using Gvr.Internal;


/// Представляет текущее состояние подключения контроллера.
/// Все значения и семантика ниже (кроме Error) являются
/// из gvr_types.h в API GVR C.
public enum GvrConnectionState {
  /// Указывает, что произошла ошибка.
  Error = -1,

  /// Указывает, что контроллер отключен.
  Disconnected = 0,
  /// Указывает, что устройство сканирует контроллеры.
  Scanning = 1,
  /// Указывает, что устройство подключается к контроллеру.
  Connecting = 2,
/// Указывает, что устройство подключено к контроллеру.
  Connected = 3,
};

/// Представляет статус API текущего состояния контроллера.
/// Значения и семантика из gvr_types.h в API GVR C.
public enum GvrControllerApiStatus {
  /// Произошла ошибка, связанная с соединением 
   /// Это единственное значение, которое не указано в gvr_types.h.
  Error = -1,

   /// API счастлив и здоров. Это не означает, что сам контроллер работает
   /// Это означает, что основная служба работает
   /// должным образом.
  Ok = 0,


   /// Любой другой статус представляет собой постоянный сбой, который требует
   /// внешнее действие для исправления:

   /// API не удалось, потому что это устройство не поддерживает контроллеры (API тоже
   /// low или другая требуемая функция отсутствует).
  Unsupported = 1,
  /// Этому приложению не было разрешено использовать эту службу (например, отсутствующие разрешения,
   /// приложение занесено в черный список базовым сервисом и т. д.).
  NotAuthorized = 2,
  /// Подходящая служба VR отсутствует.
  Unavailable = 3,
  /// Основная служба VR слишком старая, нуждается в обновлении.
  ApiServiceObsolete = 4,
  /// Основная служба VR слишком новая, несовместима с текущим клиентом.
  ApiClientObsolete = 5,
  /// Неисправна базовая служба VR. Попробуйте позже.
  ApiMalfunction = 6,
};

/// Представляет текущий уровень заряда аккумулятора контроллера.
/// Значения и семантика из gvr_types.h в API GVR C.
public enum GvrControllerBatteryLevel {
 /// Произошла ошибка, связанная с соединением.
   /// Это единственное значение, которое не указано в gvr_types.h.
  Error = -1,

  /// Состояние батареи в настоящее время не зарегистрировано
  Unknown = 0,

 /// Эквивалент 1 из 5 баров индикатора батареи
  CriticalLow = 1,

 /// Эквивалентно 2 из 5 баров индикатора батареи
  Low = 2,

  /// Эквивалент 3 из 5 баров индикатора батареи
  Medium = 3,

  /// Эквивалент 4 из 5 баров индикатора батареи
  AlmostFull = 4,

  /// Эквивалентно 5 из 5 баров индикатора батареи
  Full = 5,
};


/// Основная точка входа для API контроллера Daydream.
///
/// Чтобы использовать этот API, добавьте это поведение в GameObject в вашей сцене или используйте
/// GvrControllerMain prefab. На вашем месте может быть только один объект с таким поведением.
///
/// Это одноэлементный объект.
///
/// Для доступа к состоянию контроллера просто прочитайте статические свойства этого класса. Например,
///, чтобы узнать текущую ориентацию контроллера, используйте GvrControllerInput.Orientation.
public class GvrControllerInput : MonoBehaviour {
  private static GvrControllerInput instance;
  private static IControllerProvider controllerProvider;

  private ControllerState controllerState = new ControllerState();
  private Vector2 touchPosCentered = Vector2.zero;

  private int lastUpdatedFrameCount = -1;

  /// Обработчик событий для приема кнопки, тачпада и обновлений IMU от контроллера.
   /// Используйте этот обработчик для обновления состояния приложения на основе ввода контроллера.
  public static event Action OnControllerInputUpdated;

  /// Обработчик событий для получения второго обратного вызова уведомления, в конце концов
   /// События `OnControllerInputUpdated` запускаются.
  public static event Action OnPostControllerInputUpdated;

 /// Обработчик событий, когда изменяется состояние соединения контроллера.
  public delegate void OnStateChangedEvent(GvrConnectionState state, GvrConnectionState oldState);
  public static event OnStateChangedEvent OnStateChanged;

  public enum EmulatorConnectionMode {
    OFF,
    USB,
    WIFI,
  }
  /// Указывает, как мы подключаемся к эмулятору контроллера.
  [GvrInfo("Hold Shift to use the Mouse as the controller.\n\n" +
           "Controls:  Shift +\n" +
           "   • Move Mouse = Change Orientation\n" +
           "   • Left Mouse Button = ClickButton\n" +
           "   • Right Mouse Button = AppButton\n" +
           "   • Middle Mouse Button = HomeButton/Recenter\n" +
           "   • Ctrl = IsTouching\n" +
           "   • Ctrl + Move Mouse = Change TouchPos", 8)]
  [Tooltip("How to connect to the emulator: USB cable (recommended) or WIFI.")]
  public EmulatorConnectionMode emulatorConnectionMode = EmulatorConnectionMode.USB;

  /// Возвращает текущее состояние подключения контроллера.
  public static GvrConnectionState State {
    get {
      if (instance == null) {
        return GvrConnectionState.Error;
      }
      instance.Update();
      return instance.controllerState.connectionState;
    }
  }

 /// Возвращает статус API текущего состояния контроллера.
  public static GvrControllerApiStatus ApiStatus {
    get {
      if (instance == null) {
        return GvrControllerApiStatus.Error;
      }
      instance.Update();
      return instance.controllerState.apiStatus;
    }
  }

  /// Возвращает true, если поддерживается состояние батареи.
  public static bool SupportsBatteryStatus {
    get {
      if (controllerProvider == null || instance == null) {
        return false;
      }
      instance.Update();
      return controllerProvider.SupportsBatteryStatus;
    }
  }

  /// Возвращает текущую ориентацию контроллера в пространстве, как кватернион.
   /// Вращение обеспечивается в «пространстве ориентации», что означает, что вращение задано относительно того
   ///,как в последний раз пользователь переместил свой контроллер. Чтобы создать игровой объект в вашей сцене
   /// имеют ту же ориентацию, что и контроллер, просто назначьте этот кватернион объекту
   /// `transform.rotation`. Чтобы соответствовать относительному вращению, вместо этого используйте `transform.localRotation`.
  public static Quaternion Orientation {
    get {
      if (instance == null) {
        return Quaternion.identity;
      }
      instance.Update();
      return instance.controllerState.orientation;
    }
  }

  /// Возвращает текущую угловую скорость контроллера в радианах в секунду, используя правое
   /// правило (положительное означает правое вращение вокруг данной оси), измеряемое
   /// диспетчерским гироскопом.
   /// Оси контроллера:
   /// - X указывает вправо,
   /// - Y указывает перпендикулярно верхней поверхности контроллера
   /// - Z лежит вдоль тела регулятора, указывая на фронт
  public static Vector3 Gyro {
    get {
      if (instance == null) {
        return Vector3.zero;
      }
      instance.Update();
      return instance.controllerState.gyro;
    }
  }

  /// Возвращает текущее ускорение контроллера в метрах в секунду.
   /// Оси контроллера:
   /// - X указывает вправо,
   /// - Y указывает перпендикулярно верхней поверхности контроллера
   /// - Z лежит вдоль тела регулятора, указывая на фронт
   /// Обратите внимание, что гравитация неотличима от ускорения, поэтому, когда контроллер лежит
   /// на поверхности, ожидаем ускорение 9,8 м / с ^ 2 по оси Y. Данные акселерометра
   /// будут равным нулю на всех трех осях, только если контроллер находится в свободном падении или если пользователь
 /// находится в условиях невесомости, таких как на космической станции.
  public static Vector3 Accel {
    get {
      if (instance == null) {
        return Vector3.zero;
      }
      instance.Update();
      return instance.controllerState.accel;
    }
  }

 /// Возвращает true, когда пользователь касается сенсорной панели.
  public static bool IsTouching {
    get {
      if (instance == null) {
        return false;
      }
      instance.Update();
      return instance.controllerState.isTouching;
    }
  }

  /// Возвращает true в кадре, когда пользователь начинает касаться сенсорной панели. Каждое событие TouchDown
  /// гарантируется, что за один кадр будет только одно событие TouchUp.
   /// Также TouchDown и TouchUp никогда не будут одновременно в одном кадре.
  public static bool TouchDown {
    get {
      if (instance == null) {
        return false;
      }
      instance.Update();
      return instance.controllerState.touchDown;
    }
  }

/// Возвращает true кадр после того, как пользователь перестает касаться сенсорной панели. Каждое событие TouchUp
   /// гарантированно будет предшествовать одно событие TouchDown в более раннем кадре.
   /// Также TouchDown и TouchUp никогда не будут одновременно в одном кадре.
  public static bool TouchUp {
    get {
      if (instance == null) {
        return false;
      }
      instance.Update();
      return instance.controllerState.touchUp;
    }
  }

  /// Положение текущего касания при касании сенсорной панели.
   /// Если не касаться, это положение последнего касания (когда палец вышел из сенсорной панели).
   /// Х и Y диапазон составляет от 0 до 1.
   /// (0, 0) - верхняя левая часть сенсорной панели, а (1, 1) - нижняя правая часть сенсорной панели.
  public static Vector2 TouchPos {
    get {
      if (instance == null) {
        return new Vector2(0.5f,0.5f);
      }
      instance.Update();
      return instance.controllerState.touchPos;
    }
  }

  /// Положение текущего касания при касании сенсорной панели.
   /// Если не касаться, это положение последнего касания (когда палец вышел из сенсорной панели).
   /// Диапазон X и Y от -1 до 1. (-.707, -. 707) внизу слева (.707, .707) - верхний правый.
   /// (0, 0) - это центр тачпада.
   /// Величина касательного вектора гарантируется <= 1.
  public static Vector2 TouchPosCentered {
    get {
      if (instance == null) {
        return Vector2.zero;
      }
      instance.Update();
      return instance.touchPosCentered;
    }
  }
                     // Используйте Recentered, чтобы определить, когда пользователь выполнил жест рецензента.
  [System.Obsolete("Use Recentered to detect when user has completed the recenter gesture.")]
  public static bool Recentering {
    get {
      return false;
    }
  }

  /// Возвращает true, если пользователь только что завершил жест повторного вызова. Гарнитура и
   /// ориентация контроллера теперь сообщается в новом повторной
   /// системе координат. Это флаг события (это верно только для одного кадра
   /// после события, а затем возвращается к false).
  public static bool Recentered {
    get {
      if (instance == null) {
        return false;
      }
      instance.Update();
      return instance.controllerState.recentered;
    }
  }

/// Возвращает true, когда пользователь удерживает нажатие кнопки (кнопка тачпада).
  public static bool ClickButton {
    get {
      if (instance == null) {
        return false;
      }
      instance.Update();
      return instance.controllerState.clickButtonState;
    }
  }

  /// Возвращает true в кадре, когда пользователь начинает нажимать кнопку клика.
   /// (сенсорная панель). После каждого события ClickButtonDown
   ///   следует только одно событие ClickButtonUp в более позднем кадре.
   /// Также ClickButtonDown и ClickButtonUp никогда не будут одновременно в одном кадре.
  public static bool ClickButtonDown {
    get {
      if (instance == null) {
        return false;
      }
      instance.Update();
      return instance.controllerState.clickButtonDown;
    }
  }

 /// Возвращает true после того, как пользователь перестанет нажимать кнопку клика.
   /// (сенсорная панель). Каждое событие ClickButtonUp
   /// гарантированно будет предшествовать только одному событию ClickButtonDown в более раннем кадре.
   /// Также ClickButtonDown и ClickButtonUp никогда не будут одновременно в одном кадре.
  public static bool ClickButtonUp {
    get {
      if (instance == null) {
        return false;
      }
      instance.Update();
      return instance.controllerState.clickButtonUp;
    }
  }

 /// Возвращает true, когда пользователь удерживает кнопку приложения.
  public static bool AppButton {
    get {
      if (instance == null) {
        return false;
      }
      instance.Update();
      return instance.controllerState.appButtonState;
    }
  }

  /// Возвращает true в кадре, когда пользователь начинает нажимать кнопку приложения.
   /// После каждого события AppButtonDown гарантировано
   ///  следует только одно событие AppButtonUp в более позднем кадре.
   /// Также AppButtonDown и AppButtonUp никогда не будут одновременно в одном кадре.
  public static bool AppButtonDown {
    get {
      if (instance == null) {
        return false;
      }
      instance.Update();
      return instance.controllerState.appButtonDown;
    }
  }

  /// Возвращает true после того, как пользователь перестанет нажимать кнопку приложения.
   /// Каждое событие AppButtonUp
   /// гарантированно будет предшествовать точно одному событию AppButtonDown в более раннем кадре.
   /// Также AppButtonDown и AppButtonUp никогда не будут одновременно в одном кадре.
  public static bool AppButtonUp {
    get {
      if (instance == null) {
        return false;
      }
      instance.Update();
      return instance.controllerState.appButtonUp;
    }
  }

  /// Возвращает true в кадре, когда пользователь начинает нажимать кнопку «домой».
  public static bool HomeButtonDown {
    get {
      if (instance == null) {
        return false;
      }
      instance.Update();
      return instance.controllerState.homeButtonDown;
    }
  }

  /// Возвращает true, когда пользователь удерживает кнопку «Домой».
  public static bool HomeButtonState {
    get {
      if (instance == null) {
        return false;
      }
      instance.Update();
      return instance.controllerState.homeButtonState;
    }
  }

  /// Если State == GvrConnectionState.Error, это содержит сведения об ошибке.
  public static string ErrorDetails {
    get {
      if (instance != null) {
        instance.Update();
        return instance.controllerState.connectionState == GvrConnectionState.Error ?
          instance.controllerState.errorDetails : "";
      } else {  //«Экземпляр GvrController не найден в сцене. Возможно, он отсутствует, или он может"
                 // + "еще не инициализирован."
        return "GvrController instance not found in scene. It may be missing, or it might "
          + "not have initialized yet.";
      }
    }
  }

  // Возвращает указатель состояния контроллера библиотеки GVR C (gvr_controller_state *).
  public static IntPtr StatePtr {
    get {
      if (instance == null) {
        return IntPtr.Zero;
      }
      instance.Update();
      return instance.controllerState.gvrPtr;
    }
  }

  /// Возвращает true, если контроллер в настоящее время заряжается.
  public static bool IsCharging {
    get {
      if (instance == null) {
        return false;
      }
      instance.Update();
      return instance.controllerState.isCharging;
    }
  }

  /// Возвращает текущий уровень заряда аккумулятора контроллера.
  public static GvrControllerBatteryLevel BatteryLevel {
    get {
      if (instance == null) {
        return GvrControllerBatteryLevel.Error;
      }
      instance.Update();
      return instance.controllerState.batteryLevel;
    }
  }

  void Awake() {
    if (instance != null) {
		// «В вашей сцене было найдено более одного экземпляра GvrController».
        // + «Убедитесь, что есть только один GvrControllerInput».
      Debug.LogError("More than one GvrController instance was found in your scene. "
        + "Ensure that there is only one GvrControllerInput.");
      this.enabled = false;
      return;
    }
    instance = this;
    if (controllerProvider == null) {
      controllerProvider = ControllerProviderFactory.CreateControllerProvider(this);
    }

   // Храните экран здесь, так как GvrController должен находиться в любой сцене GVR, чтобы включить
     // возможности контроллера.
    Screen.sleepTimeout = SleepTimeout.NeverSleep;
  }

  void Update() {
    if(lastUpdatedFrameCount != Time.frameCount){
      // Состояние контроллера должно быть обновлено до любой функции, используя
       // API-интерфейс контроллера для обеспечения согласованности состояния во всем фрейме.
      lastUpdatedFrameCount = Time.frameCount;

      GvrConnectionState oldState = State;

      controllerProvider.ReadState(controllerState);
      UpdateTouchPosCentered();

#if UNITY_EDITOR
      // Удостоверьтесь, что EditorEmulator немедленно обновлен.
      if (GvrEditorEmulator.Instance != null) {
        GvrEditorEmulator.Instance.UpdateEditorEmulation();
      }
#endif  // UNITY_EDITOR

      if (OnStateChanged != null && State != oldState) {
        OnStateChanged(State, oldState);
      }

      if (OnControllerInputUpdated != null) {
        OnControllerInputUpdated();
      }

      if (OnPostControllerInputUpdated != null) {
        OnPostControllerInputUpdated();
      }
    }
  }

  void OnDestroy() {
    instance = null;
  }

  void OnApplicationPause(bool paused) {
    if (null == controllerProvider) return;
    if (paused) {
      controllerProvider.OnPause();
    } else {
      controllerProvider.OnResume();
    }
  }

  private void UpdateTouchPosCentered() {
    if (instance == null) {
      return;
    }

    touchPosCentered.x = (instance.controllerState.touchPos.x - 0.5f) * 2.0f;
    touchPosCentered.y = -(instance.controllerState.touchPos.y - 0.5f) * 2.0f;

    float magnitude = touchPosCentered.magnitude;
    if(magnitude > 1) {
      touchPosCentered.x /= magnitude;
      touchPosCentered.y /= magnitude;
    }
  }


}
