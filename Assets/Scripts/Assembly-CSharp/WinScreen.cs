using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;

public class WinScreen : MonoBehaviour
{
	public class InitArguments
	{
		public long baseStageWonCoins;

		public long additionalCoins;

		public long previousCoins;

		public long previousStars;

		public long currentStars;

		public long getsStars;

		public Action onComplete;

		public Action onMiddle;

		public Match3Game game;

		public DecorateRoomScreen decorateRoomScreen;

		public CurrencyPanel currencyPanel;

		public RectTransform starRect;

		public RectTransform coinRect;

		public long currentCoins => 0L;

		public long coinsWon => 0L;

		public void CallOnComplete()
		{
		}

		public void CallOnMiddle()
		{
		}
	}

	[Serializable]
	public class Settings
	{
		public float starTravelDuration;

		public float starRotationAngle;

		public float starEndScale;

		public float backgroundFadeOutDuration;

		public float coinTravelDuration;

		public float coinEndScale;

		public int maxCoinsToAnimate;
	}

	private struct TapState
	{
		public bool isTapped;

		public bool isWaitingForTap;

		public Action onTap;

		public void CallOnTap()
		{
		}
	}

	private sealed class _003CDoPlainAnimation_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WinScreen _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private IEnumerator _003CwaitForTapEnum_003E5__3;

		private CurrencyDisplay _003CstarsDisplay_003E5__4;

		private EnumeratorsList _003CenumList_003E5__5;

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
		public _003CDoPlainAnimation_003Ed__22(int _003C_003E1__state)
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

	private sealed class _003CFade_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public float from;

		public float to;

		public WinScreen _003C_003E4__this;

		public List<CanvasGroup> fadeItems;

		private float _003Ctime_003E5__2;

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
		public _003CFade_003Ed__23(int _003C_003E1__state)
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

	private sealed class _003CFade_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public float from;

		public float to;

		public CanvasGroup visualItem;

		private float _003Ctime_003E5__2;

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
		public _003CFade_003Ed__24(int _003C_003E1__state)
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

	private sealed class _003CWaitTillStateFinishes_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Animator animator;

		public string stateName;

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
		public _003CWaitTillStateFinishes_003Ed__25(int _003C_003E1__state)
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

	private sealed class _003CDoWaitForTap_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WinScreen _003C_003E4__this;

		public bool showTapContainer;

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
		public _003CDoWaitForTap_003Ed__34(int _003C_003E1__state)
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

	[SerializeField]
	private TextMeshProUGUI getsStarsLabel;

	[SerializeField]
	private Animator starAnimator;

	[SerializeField]
	private UIGGParticleCreator particles;

	[SerializeField]
	private string inStarAnimatorState;

	[SerializeField]
	private RectTransform tapContainer;

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private List<CanvasGroup> thingsTofadeAtEnd;

	[SerializeField]
	private List<Transform> thingsToHideAtEnd;

	[SerializeField]
	private WinScreenStar star;

	[SerializeField]
	private WinScreenCoins coins;

	[SerializeField]
	private PlayableDirector playableDirector;

	[SerializeField]
	private Transform normalAnimationContainer;

	[SerializeField]
	private Animator normalAnimator;

	[SerializeField]
	private float minTimeBeforeCanTap;

	private InitArguments initArguments;

	private IEnumerator animationEnum;

	private TapState tapState;

	public CurrencyPanel currencyPanel => null;

	private Settings settings => null;

	public void Show(InitArguments initArguments)
	{
	}

	private void Init(InitArguments initArguments)
	{
	}

	private void SetAlpha(List<CanvasGroup> list, float alpha)
	{
	}

	private IEnumerator DoPlainAnimation()
	{
		return null;
	}

	private IEnumerator Fade(List<CanvasGroup> fadeItems, float from, float to, float duration)
	{
		return null;
	}

	private IEnumerator Fade(CanvasGroup visualItem, float from, float to, float duration)
	{
		return null;
	}

	private IEnumerator WaitTillStateFinishes(Animator animator, string stateName)
	{
		return null;
	}

	private void Hide()
	{
	}

	private void Update()
	{
	}

	private void OnTap(Action onTap)
	{
	}

	private IEnumerator DoWaitForTap(bool showTapContainer = true)
	{
		return null;
	}

	public void ButtonCallback_OnTap()
	{
	}
}
