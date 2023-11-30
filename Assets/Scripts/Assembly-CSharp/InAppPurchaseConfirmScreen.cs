using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GGMatch3;
using UnityEngine;

public class InAppPurchaseConfirmScreen : UILayer, InAppBackend.Listener
{
	public struct ConfirmState
	{
		public bool isWaitingForConfirm;

		public bool isConfirmed;
	}

	public struct PurchaseArguments
	{
		public OffersDB.ProductDefinition productToBuy;

		public bool isProductBought;
	}

	private sealed class _003CDoShowPurchasedItem_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InAppPurchaseConfirmScreen _003C_003E4__this;

		private IEnumerator _003CwaitingEnum_003E5__2;

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
		public _003CDoShowPurchasedItem_003Ed__26(int _003C_003E1__state)
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

	private sealed class _003CDoWaitForConfirm_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InAppPurchaseConfirmScreen _003C_003E4__this;

		public float maxSeconds;

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
		public _003CDoWaitForConfirm_003Ed__28(int _003C_003E1__state)
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
	private GameObject confettiParticle;

	[SerializeField]
	private RectTransform successAnimationContainer;

	[SerializeField]
	private List<RectTransform> widgetsToHide;

	[SerializeField]
	private CurrencyPurchaseDialogBigPrefab namedPrefab;

	[SerializeField]
	private CurrencyPurchaseDialogSmallPrefab notNamedPrefab;

	[SerializeField]
	private VisualStyleSet loadingStyle;

	[SerializeField]
	private VisualStyleSet purchaseSuccessStyle;

	private PurchaseArguments _003CpurchaseArguments_003Ek__BackingField;

	private IEnumerator updateAnimation;

	private ConfirmState confirmState;

	private bool isShowSuspended;

	private List<PurchaseArguments> suspendedArguments;

	public PurchaseArguments purchaseArguments
	{
		get
		{
			return default(PurchaseArguments);
		}
		private set
		{
		}
	}

	public void SuspendShow()
	{
	}

	public void ResumeShow()
	{
	}

	public void Show(PurchaseArguments purchaseArguments)
	{
	}

	private void Init()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnInitialized(InAppBackend.InitializeArguments initializeArguments)
	{
	}

	public void OnPurchase(InAppBackend.PurchaseEventArguments purchaseParams)
	{
	}

	private void Hide()
	{
	}

	private IEnumerator DoShowPurchasedItem()
	{
		return null;
	}

	private void ShowConfettiParticle()
	{
	}

	private IEnumerator DoWaitForConfirm(float maxSeconds)
	{
		return null;
	}

	private void Update()
	{
	}

	public void ButtonCallback_OnConfirm()
	{
	}

	public override void OnGoBack(NavigationManager nav)
	{
	}
}
