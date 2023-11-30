using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MoneyPickupAnimation : MonoBehaviour
{
	[Serializable]
	public class Settings
	{
		public float inAnimationDuration;

		public float totalDelayForInAnimationIndexes;

		public AnimationCurve inScaleCurve;

		public float startScale;

		public Vector3 randomRange;

		public float travelDuration;

		public float totalDelayForIndexes;

		public AnimationCurve travelCurve;

		public float travelEndScale;

		public AnimationCurve travelScaleCurve;

		public float bobDuration;

		public float bobScale;

		public AnimationCurve bobCurve;

		public int numberOfCoins;

		public int numberOfStars;
	}

	public struct ShowParams
	{
		public int numberOfCoins;

		public int numberOfStars;

		public RectTransform starDestinationTransform;

		public RectTransform coinDestinationTransform;

		public Action onComplete;
	}

	public struct ElementDefinition
	{
		public MoneyPickupAnimationMoney.Style style;

		public int count;
	}

	private sealed class _003CDoInAnimation_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MoneyPickupAnimation _003C_003E4__this;

		private Settings _003Csettings_003E5__2;

		private float _003Ctime_003E5__3;

		private float _003CdelayPerIndex_003E5__4;

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
		public _003CDoInAnimation_003Ed__16(int _003C_003E1__state)
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

	private sealed class _003CDoTravelToAnimation_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MoneyPickupAnimation _003C_003E4__this;

		private Vector3 _003ClocalEndPositionStar_003E5__2;

		private Vector3 _003ClocalEndPositionCoin_003E5__3;

		private Settings _003Csettings_003E5__4;

		private float _003Ctime_003E5__5;

		private float _003CdelayPerIndex_003E5__6;

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
		public _003CDoTravelToAnimation_003Ed__17(int _003C_003E1__state)
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
	private ComponentPool coinPool;

	[SerializeField]
	private RectTransform coinSpawnOrigin;

	[SerializeField]
	private float elementWith;

	private ShowParams showParams;

	private List<MoneyPickupAnimationMoney> moneyElements;

	private bool isInAnimationComplete;

	private bool isInTranslateAnimation;

	private IEnumerator animationEnumerator;

	private List<ElementDefinition> elements;

	public Settings settings => null;

	public void Show(ShowParams showParams)
	{
	}

	public void TravelToAnimation()
	{
	}

	private IEnumerator DoInAnimation()
	{
		return null;
	}

	private IEnumerator DoTravelToAnimation()
	{
		return null;
	}

	public void Callback_OnClick()
	{
	}

	private void Update()
	{
	}
}
