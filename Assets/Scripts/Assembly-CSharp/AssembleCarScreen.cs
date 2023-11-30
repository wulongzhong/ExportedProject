using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GGMatch3;
using GiraffeGames.BundleLoader;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AssembleCarScreen : MonoBehaviour, Match3GameListener
{
	[Serializable]
	public class FogSettings
	{
		[SerializeField]
		private bool fogEnabled;

		[SerializeField]
		private Color color;

		[SerializeField]
		private FogMode fogMode;

		[SerializeField]
		private float startDistance;

		[SerializeField]
		private float endDistance;

		public void Apply()
		{
		}
	}

	private class PartsStatus
	{
		public struct Status
		{
			public CarModelPart part;

			public bool isShown;
		}

		public List<Status> statuses;

		public void SaveFromModel(CarModel model)
		{
		}

		public void HideAllInactiveBoxes()
		{
		}
	}

	public class LoadedAsset
	{
		public DateTime timeWhenCreated;

		public string name;

		public CarsDB.Car loadedCar;

		public bool isLoadedFromAssetBundle;

		public Scene scene;

		public CarScene sceneBehaviour;

		public bool IsTimePassedAfterLoad(TimeSpan timeSpan)
		{
			return false;
		}

		public LoadedAsset(string name, CarScene sceneBehaviour)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public bool loadConfigComplete;

		public AssembleCarScreen _003C_003E4__this;

		internal void _003CDoLoadScene_003Eb__0(MainConfig mainConfig)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass57_1
	{
		public bool dialogDone;

		internal void _003CDoLoadScene_003Eb__1(bool _003Cp0_003E)
		{
		}
	}

	private sealed class _003CDoLoadScene_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssembleCarScreen _003C_003E4__this;

		private _003C_003Ec__DisplayClass57_0 _003C_003E8__1;

		public CarsDB.Car car;

		private _003C_003Ec__DisplayClass57_1 _003C_003E8__2;

		private CarsDB.LoadCarRequest _003CroomRequest_003E5__2;

		private CarsDB _003CcarsDB_003E5__3;

		private IEnumerator _003CupdateEnum_003E5__4;

		private BundleLoader.ManifestRequest _003CmanifestLoading_003E5__5;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

        public object Current => throw new NotImplementedException();

        [DebuggerHidden]
		public _003CDoLoadScene_003Ed__57(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public AssembleCarScreen _003C_003E4__this;

		public bool isFirstTime;
	}

	private sealed class _003C_003Ec__DisplayClass59_1
	{
		public NavigationManager nav;

		public _003C_003Ec__DisplayClass59_0 CS_0024_003C_003E8__locals1;

		internal void _003CInitScene_003Eb__0(bool success)
		{
		}
	}

	private sealed class _003CDoFadeOut_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssembleCarScreen _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private float _003Cduration_003E5__3;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

        public object Current => throw new NotImplementedException();

        [DebuggerHidden]
		public _003CDoFadeOut_003Ed__60(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

	private sealed class _003C_003Ec__DisplayClass66_0
	{
		public AssembleCarScreen _003C_003E4__this;

		public CarModelCustomization customization;

		internal void _003COnChangeVariant_003Eb__0(CarVariationPanel panel)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public bool isSprayingDone;

		internal void _003CShowCarSpray_003Eb__0()
		{
		}
	}

	private sealed class _003CShowCarSpray_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarModelPart part;

		public AssembleCarScreen _003C_003E4__this;

		private _003C_003Ec__DisplayClass74_0 _003C_003E8__1;

		private List<TalkingDialog.TalkLine> _003CtoSayBeforeOpen_003E5__2;

		private IEnumerator _003CcustomizationsEnum_003E5__3;

		private int _003Ci_003E5__4;

		private PaintTransformation _003CpaintTransformation_003E5__5;

		private IEnumerator _003CbeforeDialog_003E5__6;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

        object IEnumerator<object>.Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        [DebuggerHidden]
		public _003CShowCarSpray_003Ed__74(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }

	private sealed class _003C_003Ec__DisplayClass75_0
	{
		public AssembleCarScreen _003C_003E4__this;

		public CarCamera.AnimateIntoSettingsArguments animateCameraSettings;
	}

	private sealed class _003C_003Ec__DisplayClass75_1
	{
		public bool isDone;

		public _003C_003Ec__DisplayClass75_0 CS_0024_003C_003E8__locals1;

		internal void _003CShowNewPart_003Eb__0(AnimationCompleteParameters complete)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass75_2
	{
		public bool isDone;

		public _003C_003Ec__DisplayClass75_0 CS_0024_003C_003E8__locals2;

		internal void _003CShowNewPart_003Eb__1(AnimationCompleteParameters complete)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass75_3
	{
		public bool isDone;

		public _003C_003Ec__DisplayClass75_0 CS_0024_003C_003E8__locals3;

		internal void _003CShowNewPart_003Eb__2(AnimationCompleteParameters _003Cp0_003E)
		{
		}
	}

	private sealed class _003CShowNewPart_003Ed__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssembleCarScreen _003C_003E4__this;

		public PartsStatus partsStatus;

		public CarModelPart part;

		private _003C_003Ec__DisplayClass75_0 _003C_003E8__1;

		private _003C_003Ec__DisplayClass75_1 _003C_003E8__2;

		private _003C_003Ec__DisplayClass75_2 _003C_003E8__3;

		private _003C_003Ec__DisplayClass75_3 _003C_003E8__4;

		private bool _003CisRoomComplete_003E5__2;

		private IEnumerator _003CenumeratorToAnimate_003E5__3;

		private IEnumerator _003CslideBackEnum_003E5__4;

		private IEnumerator _003CbeforeDialog_003E5__5;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

        object IEnumerator<object>.Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        [DebuggerHidden]
		public _003CShowNewPart_003Ed__75(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }

	private sealed class _003C_003Ec__DisplayClass76_0
	{
		public NavigationManager nav;

		public CarsDB.Car loadedRoom;

		public AssembleCarScreen _003C_003E4__this;

		public GiftBoxScreen giftBoxScreen;

		public GiftBoxScreen.ShowArguments arguments;

		internal void _003COnCompleteRoom_003Eb__0()
		{
		}

		internal void _003COnCompleteRoom_003Eb__1()
		{
		}
	}

	private sealed class _003CDoShowIntro_003Ed__81 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssembleCarScreen _003C_003E4__this;

		private IntroSequence _003Cintro_003E5__2;

		private IntroScreen _003CintroScreen_003E5__3;

		private IEnumerator _003Canimation_003E5__4;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

        object IEnumerator<object>.Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        [DebuggerHidden]
		public _003CDoShowIntro_003Ed__81(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }

	private sealed class _003C_003Ec__DisplayClass82_0
	{
		public AssembleCarScreen _003C_003E4__this;

		public CarCamera.AnimateIntoSettingsArguments animateCamera;

		public bool done;

		internal void _003CDoShowIntroStoryTimeline_003Eb__0(AnimationCompleteParameters complete)
		{
		}
	}

	private sealed class _003CDoShowIntroStoryTimeline_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssembleCarScreen _003C_003E4__this;

		private _003C_003Ec__DisplayClass82_0 _003C_003E8__1;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

        object IEnumerator<object>.Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        [DebuggerHidden]
		public _003CDoShowIntroStoryTimeline_003Ed__82(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CarVariantInteractionButton> _003C_003E9__92_0;

		internal int _003CUpdate_003Eb__92_0(CarVariantInteractionButton a, CarVariantInteractionButton b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass97_0
	{
		public PreGameDialog pregameDialog;
	}

	private sealed class _003C_003Ec__DisplayClass97_1
	{
		public PreGameDialog.ShowParams p;

		public _003C_003Ec__DisplayClass97_0 CS_0024_003C_003E8__locals1;

		internal void _003CShowPregameDialog_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass100_0
	{
		public bool isAlreadyPassed;
	}

	private sealed class _003C_003Ec__DisplayClass100_1
	{
		public WinScreen.InitArguments winScreenArguments;

		public CurrencyType currencyType;

		public WinScreen winScreen;

		public _003C_003Ec__DisplayClass100_0 CS_0024_003C_003E8__locals1;

		internal void _003COnGameComplete_003Eb__0()
		{
		}
	}

	[SerializeField]
	private CanvasGroup overlayCanvas;

	[SerializeField]
	private bool skipMainLoadingInEditor;

	[NonSerialized]
	private MainConfig config;

	[NonSerialized]
	private CarLocation carLocation;

	[SerializeField]
	private bool skipIntroInEditor;

	[SerializeField]
	private FogSettings fogSettings;

	[SerializeField]
	private Sprite gameBackgroundSprite;

	[SerializeField]
	private TasksButton tasksButton;

	[SerializeField]
	private CarSprayTool sprayTool;

	[SerializeField]
	public ScrewdriverTool screwdriverTool;

	[SerializeField]
	public CarConfirmPurchase confirmPurchase;

	[SerializeField]
	public InputHandler inputHandler;

	[SerializeField]
	private Image progressBarSprite;

	[SerializeField]
	private GameObject confettiParticle;

	[SerializeField]
	private TextMeshProUGUI levelCountLabel;

	[SerializeField]
	private ComponentPool visualItemsPool;

	[SerializeField]
	private ComponentPool variationInteractionItemsPool;

	[SerializeField]
	private List<RectTransform> widgetsToHide;

	[SerializeField]
	private List<RectTransform> controlWidgets;

	[SerializeField]
	private VisualStyleSet loadingSceneStyle;

	[SerializeField]
	private VisualStyleSet retryLoadingStyle;

	[SerializeField]
	private VisualStyleSet newVersionRequiredStyle;

	[SerializeField]
	private TextMeshProUGUI newVersionRequiredMessage;

	[SerializeField]
	private VisualStyleSet roomLoadedStyle;

	[SerializeField]
	public RectTransform coinRect;

	[SerializeField]
	public RectTransform starRect;

	[SerializeField]
	public CurrencyPanel currencyPanel;

	[SerializeField]
	public CarVariationPanel variationPanel;

	[SerializeField]
	public TutorialHandController tutorialHand;

	[SerializeField]
	private ExplodeSlider slider;

	private VisibilityHelper visibilityHelper;

	[NonSerialized]
	private PartsStatus partsStatus;

	private List<CarVisualItemButton> uiButtons;

	private List<CarVariantInteractionButton> interactionButtons;

	private List<CarVariantInteractionButton> sortedInteractionButtons;

	private IEnumerator updateEnumerator;

	private IEnumerator animationEnumerator;

	private IEnumerator autoBuildCarAnimationEnumerator;

	private IEnumerator fadeEnumerator;

	public LoadedAsset activeRoom;

	private int lastPausedCountWhenConfigIsUpdated;

	private List<TalkingDialog.TalkLine> toSayAfterOpen;

	private int wonCoinsCount;

	public CarScene scene => null;

	private bool isRoomLoaded => false;

	public bool IsCameraMoving => false;

	private void ShowConfettiParticle()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnApplicationFocus(bool paused)
	{
	}

	public void Init()
	{
	}

	private void StopReactingToClick()
	{
	}

	private void StartReactingToClick()
	{
	}

	private void OnInputHandlerClick(Vector2 position)
	{
	}

	private void LoadScene(CarsDB.Car car)
	{
	}

	private IEnumerator DoLoadScene(CarsDB.Car car)
	{
		return null;
	}

	public void ButtonCallback_DownloadNewVersion()
	{
	}

	private void InitScene(CarScene carScene, bool isFirstTime, bool skipautoshow = false, CarCamera.AnimateIntoSettingsArguments animateCameraSettings = null)
	{
	}

	public IEnumerator DoFadeOut()
	{
		return null;
	}

	private void OnChangeVariant(CarVariantInteractionButton button)
	{
	}

	private void OnInfoBox(CarVariantInteractionButton button)
	{
	}

	private void OnOpenTasks(CarVariantInteractionButton button)
	{
	}

	private void OnRotateSubpart(CarVariantInteractionButton button)
	{
	}

	private void OnCustomization(CarVariantInteractionButton button)
	{
	}

	private void OnChangeVariant(CarModelInfo.VariantGroup variantGroup, CarModelCustomization customization = null)
	{
	}

	private void OnVariantPanelChanged(CarVariationPanel panel)
	{
	}

	private void OnVariantPanelClosed(CarVariationPanel panel)
	{
	}

	private void HideAllButtons()
	{
	}

	public void VisualItemCallback_OnBuyItemPressed(CarVisualItemButton button)
	{
	}

	public void ConfirmPurchasePanelCallback_OnConfirm(CarConfirmPurchase.InitArguments initArguments)
	{
	}

	public void ConfirmPurchasePanelCallback_OnClosed()
	{
	}

	private IEnumerator ShowCarSpray(CarModelPart part)
	{
		return null;
	}

	private IEnumerator ShowNewPart(CarModelPart part, PartsStatus partsStatus)
	{
		return null;
	}

	private void OnCompleteRoom()
	{
	}

	public void ButtonCallback_Tasks()
	{
	}

	private void ShowTasks(CarModelPart selectedPart)
	{
	}

	private void OnTaskDialogClosed()
	{
	}

	private void OnTaskSelected(CompletionDialog.InitArguments.Task task)
	{
	}

	private IEnumerator DoShowIntro()
	{
		return null;
	}

	private IEnumerator DoShowIntroStoryTimeline()
	{
		return null;
	}

	private void ShowIntro()
	{
	}

	private void AddNewPart(SingleCurrencyPrice price, CarModelPart part)
	{
	}

	public void ButtonCallback_OnRetry()
	{
	}

	public Vector3 TransformWorldCarPointToLocalUIPosition(Vector3 worldCarPoint)
	{
		return default(Vector3);
	}

	public float MainCameraFOV()
	{
		return 0f;
	}

	public float DistanceFromCamera(Vector3 worldCarPoint)
	{
		return 0f;
	}

	public bool IsFacingCamera(Vector3 forward, float toleranceAngle = 0f)
	{
		return false;
	}

	private void Update()
	{
	}

	public void StartGame(Match3GameParams initParams)
	{
	}

	public void OnAllLifesRefilled()
	{
	}

	public void OnFirstLifeRefilled()
	{
	}

	public void ButtonCallback_PlayButtonClick()
	{
	}

	public void ShowPregameDialog(SingleCurrencyPrice price = null)
	{
	}

	public void OnGameStarted(GameStartedParams startedParams)
	{
	}

	public void OnGameComplete(GameCompleteParams completeParams)
	{
	}

	private void OnWinScreenAnimationMiddle()
	{
	}

	private void OnWinScreenAnimationComplete()
	{
	}

	private void OnCoinsGiven()
	{
	}

	public void ButtonCallback_OnLivesClicked()
	{
	}

	public void ButtonCallback_OnShowCarsListButtonPress()
	{
	}

	public void ButtonCallback_OnSettingsButtonPress()
	{
	}

	public void ButtonCallback_OnStarsPressed()
	{
	}

	private void _003CDoLoadScene_003Eb__57_2(bool download)
	{
	}
}
