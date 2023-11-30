using System;
using System.Collections.Generic;
using UnityEngine;

public class GGInAppPurchase : MonoBehaviour
{
	public enum PurchaseResponseCode
	{
		AlreadyOwned = 0,
		CantVerifySignature = 1,
		SignatureNotAccepted = 2,
		ConsumeFailed = 3,
		UnknownError = 4,
		Failed = 5,
		Canceled = 6,
		Success = 7
	}

	public class PurchaseResponse
	{
		public string productId;

		public string purchaseToken;

		public PurchaseResponseCode responseCode;

		public bool success => false;

		public PurchaseResponse(string productId, PurchaseResponseCode responseCode)
		{
		}
	}

	public delegate void PurchaseCompleteDelegate(PurchaseResponse response);

	public delegate void SetupCompleteDelegate(bool success);

	public delegate void OnValidateDelegate(string productId, bool isValid, object data);

	[Serializable]
	public class PurchaseJSON
	{
		public string sku;

		public string purchaseToken;
	}

	private static GGInAppPurchase instance_;

	private static GameObject instanceGameObject_;

	public static GGInAppPurchase instance => null;

	public event PurchaseCompleteDelegate onPurchaseComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	public event SetupCompleteDelegate onSetupComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	public event SetupCompleteDelegate onQueryInventoryComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	public virtual void ValidatePurchase(string productId, OnValidateDelegate onComplete)
	{
	}

	public virtual void updateProductList(List<string> consumableSkuList, List<string> nonConsumableSkuList)
	{
	}

	public virtual void updateProductList(string csvConsumableSkuList, string csvNonConsumableSkuList)
	{
	}

	public void setupFinished(string success)
	{
	}

	public void purchaseCompleteJSON(string json)
	{
	}

	public void purchaseComplete(string productId)
	{
	}

	public void queryInventoryFinished(string success)
	{
	}

	public void purchaseAlreadyOwned(string productId)
	{
	}

	public void purchaseCantVerifySignature(string productId)
	{
	}

	public void purchaseSignatureNotAccepted(string productId)
	{
	}

	public void purchaseConsumeFailed(string token)
	{
	}

	public void purchaseConsumeSuccess(string token)
	{
	}

	public void purchaseUnknownError(string productId)
	{
	}

	public void purchaseFailed(string productId)
	{
	}

	public void purchaseCanceled(string productId)
	{
	}

	protected virtual void Init()
	{
	}

	public virtual void start(string[] productIds, string[] nonConsumableProductIds, string publicKey)
	{
	}

	public virtual void buy(string productId)
	{
	}

	public virtual void consumePurchase(string purchaseToken)
	{
	}

	public virtual void restorePurchases()
	{
	}

	public virtual string GetFormatedPrice(string productId)
	{
		return null;
	}

	public virtual void QueryInventory()
	{
	}

	public virtual bool IsInventoryAvailable()
	{
		return false;
	}

	public virtual string GetPriceCurrencyCode(string productId)
	{
		return null;
	}

	public virtual string GetPriceAmountMicros(string productId)
	{
		return null;
	}
}
