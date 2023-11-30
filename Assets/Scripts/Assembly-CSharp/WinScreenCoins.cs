using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class WinScreenCoins : MonoBehaviour
{
	private sealed class _003CDoMoveCoins_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int count;

		public WinScreenCoins _003C_003E4__this;

		public long startCoins;

		public RectTransform destination;

		public long endCoins;

		private CurrencyDisplay _003CcurrencyDisplay_003E5__2;

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
		public _003CDoMoveCoins_003Ed__5(int _003C_003E1__state)
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

	private sealed class _003CDoMoveCoin_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WinScreenCoins _003C_003E4__this;

		public float delay;

		public GameObject coinGameObject;

		public Vector3 destinationLocalPosition;

		public long coinCount;

		private CurrencyDisplay _003CcurrencyDisplay_003E5__2;

		private float _003Ctime_003E5__3;

		private Transform _003CcoinTransform_003E5__4;

		private Vector3 _003CstartLocalPosition_003E5__5;

		private Vector3 _003CendLocalPosition_003E5__6;

		private int _003CstartScale_003E5__7;

		private float _003CendScale_003E5__8;

		private float _003Cduration_003E5__9;

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
		public _003CDoMoveCoin_003Ed__9(int _003C_003E1__state)
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
	private ComponentPool coinsPool;

	[SerializeField]
	private RectTransform coinImage;

	[SerializeField]
	private TextMeshProUGUI coinsLabel;

	private WinScreen winScreen;

	private EnumeratorsList enumList;

	private WinScreen.Settings settings => null;

	public void Init(long wonCoins, WinScreen winScreen)
	{
	}

	public IEnumerator DoMoveCoins(int count, RectTransform destination, long startCoins, long endCoins)
	{
		return null;
	}

	private IEnumerator DoMoveCoin(GameObject coinGameObject, Vector3 destinationLocalPosition, float delay, long coinCount)
	{
		return null;
	}
}
