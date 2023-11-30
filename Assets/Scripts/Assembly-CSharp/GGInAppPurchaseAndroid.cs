using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GGInAppPurchaseAndroid : GGInAppPurchase
{
	public class PurchaseData
	{
		public string originalJson;

		public string signature;

		public string productId;

		public string purchaseToken;

		public bool isValid;
	}

	private sealed class _003CDoVerifyInAppData_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PurchaseData data;

		public OnValidateDelegate onComplete;

		private WWW _003Cw_003E5__2;

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
		public _003CDoVerifyInAppData_003Ed__20(int _003C_003E1__state)
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

	private AndroidJavaObject javaInstance;

	private RuntimePlatform platform;

	protected override void Init()
	{
	}

	public void startSetup(string base64EncodedPublicKey, string csvConsumableSkuList, string csvNonConsumableSkuList, bool enableDebugLogging)
	{
	}

	public override void updateProductList(string csvConsumableSkuList, string csvNonConsumableSkuList)
	{
	}

	public bool isSetupFinished()
	{
		return false;
	}

	public bool isSetupStarted()
	{
		return false;
	}

	public void queryInventory()
	{
	}

	public void startPurchaseFlow(string sku)
	{
	}

	public override void start(string[] productIds, string[] nonConsumableProductIds, string publicKey)
	{
	}

	public override void consumePurchase(string purchaseToken)
	{
	}

	public override void buy(string productId)
	{
	}

	public override void restorePurchases()
	{
	}

	public override string GetFormatedPrice(string productId)
	{
		return null;
	}

	public override string GetPriceCurrencyCode(string productId)
	{
		return null;
	}

	public override string GetPriceAmountMicros(string productId)
	{
		return null;
	}

	public string getPurchaseOriginalJSON(string productId)
	{
		return null;
	}

	public string getPurchaseSignature(string productId)
	{
		return null;
	}

	public override void ValidatePurchase(string productId, OnValidateDelegate onComplete)
	{
	}

	protected IEnumerator DoVerifyInAppData(PurchaseData data, OnValidateDelegate onComplete)
	{
		return null;
	}

	public override void QueryInventory()
	{
	}

	public override bool IsInventoryAvailable()
	{
		return false;
	}
}
