using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GGMatch3;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DecorateRoomScreen : UILayer, Match3GameListener
{
	public enum UIItemName
	{
		PlayButton = 0,
		SettingsButton = 1,
		CoinsBar = 2,
		HeartsBar = 3
	}

	[Serializable]
	public class UIItemSetup
	{
		public UIItemName name;

		public Transform widget;
	}

	[Serializable]
	public class Accelerometer
	{
		private Vector3 _003CcurrentPosition_003Ek__BackingField;

		public float lowPassFilter;

		public Vector3 currentPosition
		{
			get
			{
				return default(Vector3);
			}
			protected set
			{
			}
		}

		public Vector3 ClampPosition(Vector3 position)
		{
			return default(Vector3);
		}

		public void Init()
		{
		}

		public void Update()
		{
		}
	}

	public class Room
	{
		public string name;

		public RoomsDB.Room loadedRoom;

		public Scene scene;

		public DecoratingScene sceneBehaviour;

		public Room(string name, DecoratingScene sceneBehaviour)
		{
		}
	}

	private sealed class _003CDoLoadScene_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DecorateRoomScreen _003C_003E4__this;

		public RoomsDB.Room room;

		private InAppPurchaseConfirmScreen _003CinAppPurchaseConfirm_003E5__2;

		private RoomsDB.LoadRoomRequest _003CroomRequest_003E5__3;

		private IEnumerator _003CupdateEnum_003E5__4;

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

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }

	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public DecorateRoomScreen _003C_003E4__this;

		public DecoratingScene scene;

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

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public bool isComplete;

		internal void _003CDoShowCharacterAnimation_003Eb__0()
		{
		}
	}

	private sealed class _003CDoShowCharacterAnimation_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<ChangeAnimationArguments> animationParamsList;

		public DecorateRoomScreen _003C_003E4__this;

		private _003C_003Ec__DisplayClass60_0 _003C_003E8__1;

		public Action onComplete;

		private bool _003CwideBarsShown_003E5__2;

		private int _003Ci_003E5__3;

		private bool _003ChasMoreAnimations_003E5__4;

		private ChangeAnimationArguments _003CanimationParams_003E5__5;

		private float _003Ctime_003E5__6;

		private float _003Cduration_003E5__7;

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
		public _003CDoShowCharacterAnimation_003Ed__60(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass61_0
	{
		public bool isComplete;

		internal void _003CDoShowCharacterAnimation_003Eb__0()
		{
		}
	}

	private sealed class _003CDoShowCharacterAnimation_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChangeAnimationArguments animationParams;

		public DecorateRoomScreen _003C_003E4__this;

		private _003C_003Ec__DisplayClass61_0 _003C_003E8__1;

		public Action onComplete;

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
		public _003CDoShowCharacterAnimation_003Ed__61(int _003C_003E1__state)
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

	private sealed class _003CDoShowMessageEnumerator_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProgressMessageList progressMessages;

		public DecorateRoomScreen _003C_003E4__this;

		public Action onComplete;

		private List<string> _003Cmessages_003E5__2;

		private IEnumerator _003Cenumerator_003E5__3;

		private TextDialog.MessageArguments _003CmessageArguments_003E5__4;

		private int _003Ci_003E5__5;

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
		public _003CDoShowMessageEnumerator_003Ed__62(int _003C_003E1__state)
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

		public static Action _003C_003E9__63_0;

		internal void _003CDoShowMessageEnumerator_003Eb__63_0()
		{
		}
	}

	private sealed class _003CDoShowMessageEnumerator_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DecorateRoomScreen _003C_003E4__this;

		public List<string> messages;

		public List<ChangeAnimationArguments> animationParamsList;

		public Action onComplete;

		private IEnumerator _003Cenumerator_003E5__2;

		private int _003Ci_003E5__3;

		private IEnumerator _003CanimationParamEnum_003E5__4;

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
		public _003CDoShowMessageEnumerator_003Ed__63(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass65_0
	{
		public bool canContiue;

		internal void _003CDoShowMessageEnumerator_003Eb__0()
		{
		}
	}

	private sealed class _003CDoShowMessageEnumerator_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DecorateRoomScreen _003C_003E4__this;

		public TextDialog.MessageArguments messageArguments;

		private _003C_003Ec__DisplayClass65_0 _003C_003E8__1;

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
		public _003CDoShowMessageEnumerator_003Ed__65(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass70_0
	{
		public NavigationManager nav;

		public RoomsDB.Room loadedRoom;

		public GiftBoxScreen giftBoxScreen;

		public GiftBoxScreen.ShowArguments arguments;

		internal void _003COnCompleteRoom_003Eb__0()
		{
		}

		internal void _003COnCompleteRoom_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass83_0
	{
		public WinScreen.InitArguments winScreenArguments;

		public WinScreen winScreen;

		internal void _003COnGameComplete_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass94_0
	{
		public NavigationManager nav;

		internal void _003COnGoBack_003Eb__0(bool success)
		{
		}
	}

	[SerializeField]
	private List<Transform> levelDifficultyWidgets;

	[SerializeField]
	private VisualStyleSet normalDifficultySlyle;

	[SerializeField]
	private VisualStyleSet hardDifficultySlyle;

	[SerializeField]
	private VisualStyleSet nightmareDifficultySlyle;

	[SerializeField]
	private bool alwaysPlaySceneCompleteAnimation;

	[SerializeField]
	public TutorialHandController tutorialHand;

	[SerializeField]
	private ComponentPool speachBubblePool;

	[SerializeField]
	private CanvasGroup bubbleGroup;

	[SerializeField]
	private GroupFooter groupFooter;

	[SerializeField]
	private WideAspectBars aspectBars;

	[SerializeField]
	private StarConsumeAnimation starConsumeAnimation;

	[SerializeField]
	private List<UIItemSetup> uiItemSetups;

	[SerializeField]
	private float marginsPsdSize;

	[SerializeField]
	private bool useAccelerometer;

	[SerializeField]
	private ItemSelectionButton itemSelect;

	[SerializeField]
	private GameObject confettiParticle;

	[SerializeField]
	private VisualObjectParticles visualObjectParticles;

	private VisibilityHelper visibilityHelper;

	[SerializeField]
	private Accelerometer accelerometer;

	[SerializeField]
	public bool noCoinsForPurchase;

	[SerializeField]
	private TextMeshProUGUI levelCountLabel;

	[SerializeField]
	private ComponentPool visualItemsPool;

	[SerializeField]
	private List<RectTransform> widgetsToHide;

	[SerializeField]
	private List<RectTransform> controlWidgets;

	[SerializeField]
	private Image progressBarSprite;

	[SerializeField]
	private VisualStyleSet loadingSceneStyle;

	[SerializeField]
	private VisualStyleSet retryLoadingStyle;

	[SerializeField]
	private VisualStyleSet roomLoadedStyle;

	[SerializeField]
	private VariationPanel variationPanel;

	[SerializeField]
	private ConfirmPurchasePanel confirmPurchasePanel;

	[SerializeField]
	private MoneyPickupAnimation moneyPickupAnimation;

	[SerializeField]
	public RectTransform coinRect;

	[SerializeField]
	public RectTransform starRect;

	[SerializeField]
	public CurrencyPanel currencyPanel;

	[NonSerialized]
	private List<DecorateRoomSceneVisualItem> uiVisualItems;

	[SerializeField]
	private ScreenMessagePanel messagePanel;

	private IEnumerator updateEnumerator;

	private IEnumerator animationEnumerator;

	public Room activeRoom;

	private MainConfig mainConfig;

	private int wonCoinsCount;

	public DecoratingScene scene => null;

	private bool isRoomLoaded => false;

	public void SetSpeachBubbleAlpha(float alpha)
	{
	}

	public CharacterSpeachBubble GetSpeachBubble(CharacterAvatar avatar)
	{
		return null;
	}

	private void ShowConfettiParticle()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnApplicationFocus(bool pause)
	{
	}

	public void Init()
	{
	}

	private void FinishInit()
	{
	}

	private void LoadScene(RoomsDB.Room room)
	{
	}

	private IEnumerator DoLoadScene(RoomsDB.Room room)
	{
		return null;
	}

	private void InitRetry()
	{
	}

	private void InitScene(DecoratingScene scene, bool isFirstTime)
	{
	}

	private IEnumerator DoShowCharacterAnimation(List<ChangeAnimationArguments> animationParamsList, Action onComplete = null)
	{
		return null;
	}

	private IEnumerator DoShowCharacterAnimation(ChangeAnimationArguments animationParams, Action onComplete = null)
	{
		return null;
	}

	private IEnumerator DoShowMessageEnumerator(ProgressMessageList progressMessages, Action onComplete = null)
	{
		return null;
	}

	private IEnumerator DoShowMessageEnumerator(List<string> messages, List<ChangeAnimationArguments> animationParamsList, Action onComplete = null)
	{
		return null;
	}

	private IEnumerator DoShowMessageEnumerator(string message)
	{
		return null;
	}

	private IEnumerator DoShowMessageEnumerator(TextDialog.MessageArguments messageArguments)
	{
		return null;
	}

	private void HideSelectionUI()
	{
	}

	private void ShowStarConsumeAnimation(DecorateRoomSceneVisualItem visualItem, Action onEnd)
	{
	}

	public void ButtonCallback_OnRetry()
	{
	}

	public void VariationPanelCallback_OnClosed(VariationPanel variationPanel)
	{
	}

	private void OnCompleteRoom()
	{
	}

	private void ShowVariations(DecorateRoomSceneVisualItem uiItem, VariationPanel.InitParams initParams)
	{
	}

	public void VisualItemCallback_OnBuyItemPressed(DecorateRoomSceneVisualItem uiItem)
	{
	}

	private void UpdateBubblePosition()
	{
	}

	private void Update()
	{
	}

	public void ButtonCallback_OnSceneClick()
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

	public void ShowPregameDialog()
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

	private void OnCoinsGiven()
	{
	}

	public Vector3 TransformPSDToWorldPoint(Vector2 point)
	{
		return default(Vector3);
	}

	public Vector3 TransformWorldToPSDPoint(Vector2 point)
	{
		return default(Vector3);
	}

	public void ConfirmPurchasePanelCallback_OnConfirm(DecorateRoomSceneVisualItem uiItem)
	{
	}

	public void ConfirmPurchasePanelCallback_OnClosed()
	{
	}

	public void ButtonCallback_OnLivesClicked()
	{
	}

	public void ButtonCallback_OnSettingsButtonPress()
	{
	}

	public override void OnGoBack(NavigationManager nav)
	{
	}
}
