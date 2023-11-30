using GGMatch3;
using ProtoModels;

public class Analytics : BehaviourSingletonInit<Analytics>
{
	public class EventBase
	{
		public virtual void Send()
		{
		}
	}

	public class StageStartedEvent : EventBase
	{
		public GameScreen.StageState stageState;
	}

	public class StageCompletedEvent : EventBase
	{
		public GameScreen.StageState stageState;
	}

	public class StageFailedEvent : EventBase
	{
		public GameScreen.StageState stageState;
	}

	public class IAPEvent : EventBase
	{
		public InAppBackend.PurchaseEventArguments purchaseArguments;

		public OffersDB.ProductDefinition inAppObject;

		public string purchaseToken;
	}

	public class MovesBoughtEvent : EventBase
	{
		public GameScreen.StageState stageState;

		public BuyMovesPricesConfig.OfferConfig offer;
	}

	public class LivesRefillBoughtEvent : EventBase
	{
		public int livesBeforeRefill;

		public int livesAfterRefill;

		public LivesPriceConfig.PriceConfig config;
	}

	public class RoomItemBoughtEvent : EventBase
	{
		public SingleCurrencyPrice price;

		public DecorateRoomScreen screen;

		public GraphicsSceneConfig.VisualObject visualObject;

		public GraphicsSceneConfig.Variation variation;

		public int numberOfItemsOwned;
	}

	public class RoomItemChangedEvent : EventBase
	{
		public DecorateRoomScreen screen;

		public GraphicsSceneConfig.VisualObject visualObject;

		public GraphicsSceneConfig.Variation variation;
	}

	public class BoosterUsedEvent : EventBase
	{
		public BoosterConfig booster;

		public GameScreen.StageState stageState;
	}

	public class RateDialog : EventBase
	{
		public int timesShown;

		public bool isLike;

		public bool isGoingToRate;
	}

	public const string Filename = "ans.bytes";

	public AnalyticsDAO model;

	public float secondsTillExited => 0f;

	public override void Init()
	{
	}

	public void Save()
	{
	}

	public void SetExited()
	{
	}

	public void IncSessionNum()
	{
	}

	public Analytics()
	{
		//((BehaviourSingletonInit<>)(object)this)._002Ector();
	}
}
