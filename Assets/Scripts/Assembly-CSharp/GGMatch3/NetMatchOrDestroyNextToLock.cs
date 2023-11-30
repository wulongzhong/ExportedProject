namespace GGMatch3
{
	public class NetMatchOrDestroyNextToLock : SlotComponent
	{
		public struct InitProperties
		{
			public bool isMoveIntoSlotSuspended;

			public bool isSlotMatchingSuspended;

			public bool isAvailableForDiscoBombSuspended;

			public bool isBlockingBurriedElement;

			public bool isAvailableForDiscoBombReplaceBombs;

			public bool isAttachGrowingElementSuspended;

			public WobbleAnimation.Settings wobbleSettings;

			public bool isDestroyByMatchingNeighborSuspended;

			public bool canFallthroughPickup;

			public int level;

			public ChipType chipType;

			public int sortingOrder;

			private bool overrideDisplayChipType;

			private ChipType displayChipType_;

			public bool useSound;

			public GGSoundSystem.SFXType soundType;

			public ChipType displayChipType => default(ChipType);

			public void SetDisplayChipType(ChipType type)
			{
			}
		}

		private WobbleAnimation wobbleAnimation;

		private int level;

		private InitProperties initProperties;

		private MultiLayerItemBehaviour itemBehaviour => null;

		public override bool isBlockingBurriedElement => false;

		public override bool isBlockingCarpetSpread => false;

		public override bool isAttachGrowingElementSuspended => false;

		public override bool isPlaceBubbleSuspended => false;

		public override int sortingOrder => 0;

		public override bool isBlockingChip => false;

		public override int blockerLevel => 0;

		public override bool isSlotMatchingSuspended => false;

		public override bool isMoveIntoSlotSuspended => false;

		public override bool isSlotGravitySuspended => false;

		public override bool isSlotSwapSuspended => false;

		public override bool isPreventingGravity => false;

		public override bool isPowerupReplacementSuspended => false;

		public override bool isCreatePowerupWithThisSlotSuspended => false;

		public override bool isMovingWithConveyor => false;

		public override bool isDestroyedByMatchingNextTo => false;

		public override void AddToGoalsAtStart(Match3Goals goals)
		{
		}

		public override bool IsCompatibleWithPickupGoal(Match3Goals.ChipTypeDef chipTypeDef)
		{
			return false;
		}

		public void Init(InitProperties initProperties)
		{
		}

		public override bool IsAvailableForDiscoBombSuspended(bool replaceWithBombs)
		{
			return false;
		}

		public override SlotDestroyResolution OnDestroyNeighbourSlotComponent(Slot slotBeingDestroyed, SlotDestroyParams destroyParams)
		{
			return default(SlotDestroyResolution);
		}

		public override SlotDestroyResolution OnDestroySlotComponent(SlotDestroyParams destroyParams)
		{
			return default(SlotDestroyResolution);
		}

		private SlotDestroyResolution DestroyLayer(SlotDestroyParams destroyParams)
		{
			return default(SlotDestroyResolution);
		}

		public override void Wobble(WobbleAnimation.Settings settings)
		{
		}

		public override void OnUpdate(float deltaTime)
		{
		}
	}
}
