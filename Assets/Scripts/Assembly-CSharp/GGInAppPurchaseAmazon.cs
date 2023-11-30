using UnityEngine;

public class GGInAppPurchaseAmazon : GGInAppPurchase
{
	private AndroidJavaObject javaInstance;

	private RuntimePlatform platform;

	protected override void Init()
	{
	}

	public void startSetup(string base64EncodedPublicKey, string csvConsumableSkuList, bool enableDebugLogging)
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

	public override void QueryInventory()
	{
	}

	public override bool IsInventoryAvailable()
	{
		return false;
	}
}
