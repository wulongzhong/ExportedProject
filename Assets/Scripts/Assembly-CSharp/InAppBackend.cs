using System.Collections.Generic;

public class InAppBackend : BehaviourSingletonInit<InAppBackend>
{
	public class PurchasesList
	{
		protected Dictionary<string, OffersDB.ProductDefinition> objectsThatCanBePurchased;

		public List<string> consumableProductIds => null;

		public List<string> nonConsumableProductIds => null;

		public void Add(List<OffersDB.ProductDefinition> objects)
		{
		}

		public void Add(OffersDB.ProductDefinition inAppObject)
		{
		}
	}

	public struct InitializeArguments
	{
		public bool isSuccess;
	}

	public struct PurchaseEventArguments
	{
		public bool isSuccess;

		public string productId;
	}

	public interface Listener
	{
		void OnInitialized(InitializeArguments initializeArguments);

		void OnPurchase(PurchaseEventArguments purchaseParams);
	}

	private GGInAppPurchase inApp;

	private List<Listener> listeners;

	public void AddListener(Listener listener)
	{
	}

	public void RemoveListener(Listener listener)
	{
	}

	public void PurchaseItem(string productId)
	{
	}

	private void CallListenersOnInitialized(InitializeArguments initializeArguments)
	{
	}

	private void CallListenersOnPurchase(PurchaseEventArguments purchaseEventArguments)
	{
	}

	public override void Init()
	{
	}

	private bool IsInitialized()
	{
		return false;
	}

	private void InitializePurchasing()
	{
	}

	public string LocalisedPriceString(string productId)
	{
		return null;
	}

	protected void OnSetupComplete(bool success)
	{
	}

	public void OnProductPurchased(GGInAppPurchase.PurchaseResponse response)
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	public OffersDB.ProductDefinition FindInAppForId(string productId)
	{
		return null;
	}

	public InAppBackend()
	{
		//((BehaviourSingletonInit<>)(object)this)._002Ector();
	}
}
