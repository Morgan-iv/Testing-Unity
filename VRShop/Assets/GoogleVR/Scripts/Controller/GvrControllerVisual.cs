// Copyright 2016 Google Inc. Все права защищены.
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
using System.Collections;

/// Обеспечивает визуальную обратную связь для контроллера дневного света.
[RequireComponent(typeof(Renderer))]
public class GvrControllerVisual : MonoBehaviour, IGvrArmModelReceiver {

  [System.Serializable]
  public struct ControllerDisplayState {

    public GvrControllerBatteryLevel batteryLevel;
    public bool batteryCharging;

    public bool clickButton;
    public bool appButton;
    public bool homeButton;
    public bool touching;
    public Vector2 touchPos;
  }

   /// Массив сборных файлов, которые будут созданы и добавлены как дети
   /// контроллера визуально, когда контроллер создан. Использовал к
   /// динамически добавляет всплывающие подсказки или другие дополнительные визуальные элементы.
  [SerializeField]
  private GameObject[] attachmentPrefabs;
  [SerializeField] private Color touchPadColor =
      new Color(200f / 255f, 200f / 255f, 200f / 255f, 1);
  [SerializeField] private Color appButtonColor =
      new Color(200f / 255f, 200f / 255f, 200f / 255f, 1);
  [SerializeField] private Color systemButtonColor =
      new Color(20f / 255f, 20f / 255f, 20f / 255f, 1);

  /// Определяет, установлено ли displayState из GvrControllerInput.
  [Tooltip("Determines if the displayState is set from GvrControllerInput.")]
  public bool readControllerState = true;

  /// Используется для установки состояния дисплея контроллера.
   /// Это можно использовать для учебных пособий, которые визуализируют контроллер или другие варианты использования, которые требуют
   /// отображение визуализации контроллера без состояния, определяемого входом контроллера.
   /// Кроме того, его можно использовать для предварительного просмотра визуализации контроллера в редакторе.
   /// ПРИМЕЧАНИЕ: readControllerState необходимо отключить, чтобы установить состояние отображения.
  public ControllerDisplayState displayState;

  /// Это предпочтительное максимальное значение альфа, которое должен иметь объект
   ///, когда это удобное расстояние от головы.
  [Range(0.0f, 1.0f)]
  public float maximumAlpha = 1.0f;

  public GvrBaseArmModel ArmModel { get; set; }

  public float PreferredAlpha{
    get{
      return ArmModel != null ?  maximumAlpha * ArmModel.PreferredAlpha : maximumAlpha;
    }
  }

  public Color TouchPadColor {
    get {
      return touchPadColor;
    }
    set {
      touchPadColor = value;
      if(materialPropertyBlock != null) {
        materialPropertyBlock.SetColor(touchPadId, touchPadColor);
      }
    }
  }

  public Color AppButtonColor {
    get {
      return appButtonColor;
    }
    set {
      appButtonColor = value;
      if(materialPropertyBlock != null){
        materialPropertyBlock.SetColor(appButtonId, appButtonColor);
      }
    }
  }

  public Color SystemButtonColor {
    get {
      return systemButtonColor;
    }
    set {
      systemButtonColor = value;
      if(materialPropertyBlock != null) {
        materialPropertyBlock.SetColor(systemButtonId, systemButtonColor);
      }
    }
  }

  private Renderer controllerRenderer;
  private MaterialPropertyBlock materialPropertyBlock;

  private int alphaId;
  private int touchId;
  private int touchPadId;
  private int appButtonId;
  private int systemButtonId;
  private int batteryColorId;

  private bool wasTouching;
  private float touchTime;

 // Данные передаются в шейдер, (xy) положение касания, (z) длительность касания, (w) состояние батареи.
  private Vector4 controllerShaderData;
  // Данные передаются в шейдер, (x) общую альфа, (y) продолжительность нажатия сенсорной панели,
   // (z) продолжительность нажатия кнопки приложения, (w) длительность нажатия кнопки системы.
  private Vector4 controllerShaderData2;
  private Color currentBatteryColor;

  // Эти значения управляют временем анимации для кнопок контроллера
  public const float APP_BUTTON_ACTIVE_DURATION_SECONDS = 0.111f;
  public const float APP_BUTTON_RELEASE_DURATION_SECONDS = 0.0909f;

  public const float SYSTEM_BUTTON_ACTIVE_DURATION_SECONDS = 0.111f;
  public const float SYSTEM_BUTTON_RELEASE_DURATION_SECONDS = 0.0909f;

  public const float TOUCHPAD_CLICK_DURATION_SECONDS = 0.111f;
  public const float TOUCHPAD_RELEASE_DURATION_SECONDS = 0.0909f;

  public const float TOUCHPAD_CLICK_SCALE_DURATION_SECONDS = 0.075f;
  public const float TOUCHPAD_POINT_SCALE_DURATION_SECONDS = 0.15f;

  // Эти значения используются шейдером для управления дисплеем батареи
   // Изменяйте эти значения только в том случае, если вы также модифицируете шейдер.
  private const float BATTERY_FULL = 0;
  private const float BATTERY_ALMOST_FULL = .125f;
  private const float BATTERY_MEDIUM = .225f;
  private const float BATTERY_LOW = .325f;
  private const float BATTERY_CRITICAL = .425f;
  private const float BATTERY_HIDDEN = .525f;

  private readonly Color GVR_BATTERY_CRITICAL_COLOR = new Color(1,0,0,1);
  private readonly Color GVR_BATTERY_LOW_COLOR = new Color(1,0.6823f,0,1);
  private readonly Color GVR_BATTERY_MED_COLOR = new Color(0,1,0.588f,1);
  private readonly Color GVR_BATTERY_FULL_COLOR = new Color(0,1,0.588f,1);

  // Сколько времени нужно использовать в качестве «немедленного обновления».
   // Любое значение, достаточно большое для мгновенного обновления всех визуальных анимаций.
  private const float IMMEDIATE_UPDATE_TIME = 10f;

  void Awake() {
    Initialize();
    CreateAttachments();
  }

  void OnEnable() {
    GvrControllerInput.OnPostControllerInputUpdated += OnPostControllerInputUpdated;
  }

  void OnDisable() {
    GvrControllerInput.OnPostControllerInputUpdated -= OnPostControllerInputUpdated;
  }

  void OnValidate() {
    if (!Application.isPlaying) {
      Initialize();
      OnVisualUpdate(true);
    }
  }

  private void OnPostControllerInputUpdated() {
    OnVisualUpdate();
  }

  private void CreateAttachments() {
    if (attachmentPrefabs == null) {
      return;
    }

    for (int i = 0; i < attachmentPrefabs.Length; i++) {
      GameObject prefab = attachmentPrefabs[i];
      GameObject attachment = Instantiate(prefab);
      attachment.transform.SetParent(transform, false);
    }
  }

  private void Initialize() {
    if(controllerRenderer == null) {
      controllerRenderer = GetComponent<Renderer>();
    }
    if(materialPropertyBlock == null) {
      materialPropertyBlock = new MaterialPropertyBlock();
    }

    alphaId = Shader.PropertyToID("_GvrControllerAlpha");
    touchId = Shader.PropertyToID("_GvrTouchInfo");
    touchPadId = Shader.PropertyToID("_GvrTouchPadColor");
    appButtonId = Shader.PropertyToID("_GvrAppButtonColor");
    systemButtonId = Shader.PropertyToID("_GvrSystemButtonColor");
    batteryColorId = Shader.PropertyToID("_GvrBatteryColor");

    materialPropertyBlock.SetColor(appButtonId, appButtonColor);
    materialPropertyBlock.SetColor(systemButtonId, systemButtonColor);
    materialPropertyBlock.SetColor(touchPadId, touchPadColor);
    controllerRenderer.SetPropertyBlock(materialPropertyBlock);
  }

  private void UpdateControllerState() {
    // Вернемся раньше, когда приложение не воспроизводится, чтобы гарантировать, что сериализованный displayState
     // используется для предварительного просмотра визуализации контроллера вместо значений по умолчанию GvrControllerInput.
#if UNITY_EDITOR
    if (!Application.isPlaying) {
      return;
    }
#endif

    displayState.batteryLevel = GvrControllerInput.BatteryLevel;
    displayState.batteryCharging = GvrControllerInput.IsCharging;

    displayState.clickButton = GvrControllerInput.ClickButton;
    displayState.appButton = GvrControllerInput.AppButton;
    displayState.homeButton = GvrControllerInput.HomeButtonState;
    displayState.touching = GvrControllerInput.IsTouching;
    displayState.touchPos = GvrControllerInput.TouchPosCentered;
  }

  private void OnVisualUpdate(bool updateImmediately = false) {

    // Обновление визуального отображения на основе состояния контроллера
    if(readControllerState) {
      UpdateControllerState();
    }

    float deltaTime = Time.deltaTime;

    // Если флажок для немедленного обновления, установите deltaTime на произвольно большое значение
     // Это особенно полезно в редакторе, но также для быстрого сброса состояния
    if(updateImmediately) {
      deltaTime = IMMEDIATE_UPDATE_TIME;
    }

    if (displayState.clickButton) {
      controllerShaderData2.y = Mathf.Min(1, controllerShaderData2.y + deltaTime / TOUCHPAD_CLICK_DURATION_SECONDS);
    } else{
      controllerShaderData2.y = Mathf.Max(0, controllerShaderData2.y - deltaTime / TOUCHPAD_RELEASE_DURATION_SECONDS);
    }

    if (displayState.appButton) {
      controllerShaderData2.z = Mathf.Min(1, controllerShaderData2.z + deltaTime / APP_BUTTON_ACTIVE_DURATION_SECONDS);
    } else{
      controllerShaderData2.z = Mathf.Max(0, controllerShaderData2.z - deltaTime / APP_BUTTON_RELEASE_DURATION_SECONDS);
    }

    if (displayState.homeButton) {
      controllerShaderData2.w = Mathf.Min(1, controllerShaderData2.w + deltaTime / SYSTEM_BUTTON_ACTIVE_DURATION_SECONDS);
    } else {
      controllerShaderData2.w = Mathf.Max(0, controllerShaderData2.w - deltaTime / SYSTEM_BUTTON_RELEASE_DURATION_SECONDS);
    }

   // Устанавливаем альфа альфа для умноженной предпочтительной альфы.
    controllerShaderData2.x = PreferredAlpha;
    materialPropertyBlock.SetVector(alphaId, controllerShaderData2);

    controllerShaderData.x = displayState.touchPos.x;
    controllerShaderData.y = displayState.touchPos.y;

    if (displayState.touching || displayState.clickButton) {
      if (!wasTouching) {
        wasTouching = true;
      }
      if(touchTime < 1) {
        touchTime = Mathf.Min(touchTime + deltaTime / TOUCHPAD_POINT_SCALE_DURATION_SECONDS, 1);
      }
    } else {
      wasTouching = false;
      if(touchTime > 0) {
        touchTime = Mathf.Max(touchTime - deltaTime / TOUCHPAD_POINT_SCALE_DURATION_SECONDS, 0);
      }
    }

    controllerShaderData.z = touchTime;

    UpdateBatteryIndicator();

    materialPropertyBlock.SetVector(touchId, controllerShaderData);
    materialPropertyBlock.SetColor(batteryColorId, currentBatteryColor);
    // Обновление рендеринга
    controllerRenderer.SetPropertyBlock(materialPropertyBlock);
  }

  private void UpdateBatteryIndicator() {

    GvrControllerBatteryLevel level = displayState.batteryLevel;
    bool charging = displayState.batteryCharging;

    switch (level) {
      case GvrControllerBatteryLevel.Full:
        controllerShaderData.w = BATTERY_FULL;
        currentBatteryColor = GVR_BATTERY_FULL_COLOR;
      break;
      case GvrControllerBatteryLevel.AlmostFull:
        controllerShaderData.w = BATTERY_ALMOST_FULL;
        currentBatteryColor = GVR_BATTERY_FULL_COLOR;
      break;
      case GvrControllerBatteryLevel.Medium:
        controllerShaderData.w = BATTERY_MEDIUM;
        currentBatteryColor = GVR_BATTERY_MED_COLOR;
      break;
      case GvrControllerBatteryLevel.Low:
        controllerShaderData.w = BATTERY_LOW;
        currentBatteryColor = GVR_BATTERY_LOW_COLOR;
      break;
      case GvrControllerBatteryLevel.CriticalLow:
        controllerShaderData.w = BATTERY_CRITICAL;
        currentBatteryColor = GVR_BATTERY_CRITICAL_COLOR;
      break;
      default:
        controllerShaderData.w = BATTERY_HIDDEN;
        currentBatteryColor.a = 0;
      break;
    }

    if (charging) {
      controllerShaderData.w = -controllerShaderData.w;
      currentBatteryColor = GVR_BATTERY_FULL_COLOR;
    }
  }

}
