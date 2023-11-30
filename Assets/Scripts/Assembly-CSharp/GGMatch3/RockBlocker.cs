namespace GGMatch3
{
	public class RockBlocker : SlotComponent
	{
		public struct InitArguments
		{
			public int level;

			public bool cancelsSnow;

			public int sortingOrder;
		}

		private InitArguments initArguments;

		private int level;

		private WobbleAnimation wobbleAnimation;

		private int sortingOrder_;

		private MultiLayerItemBehaviour itemBehaviour => null;

		public override bool isBlockingBurriedElement => false;

		public override bool isBlockingCarpetSpread => false;

		public override bool isAttachGrowingElementSuspended => false;

		public override bool isPlaceBubbleSuspended => false;

		private ChipType chipType => default(ChipType);

		public override int sortingOrder => 0;

		public override bool isBlockingChip => false;

		public override int blockerLevel => 0;

		public override bool isSlotMatchingSuspended => false;

		public override bool isMoveIntoSlotSuspended => false;

		public override bool isSlotGravitySuspended => false;

		public override bool isSlotSwapSuspended => false;

		public override bool isPreventingOtherChipsToFallIntoSlot => false;

		public override bool isPreventingGravity => false;

		public override bool isPowerupReplacementSuspended => false;

		public override bool isCreatePowerupWithThisSlotSuspended => false;

		public override bool isMovingWithConveyor => false;

		public override void AddToGoalsAtStart(Match3Goals goals)
		{
		}

		public override bool IsCompatibleWithPickupGoal(Match3Goals.ChipTypeDef chipTypeDef)
		{
			return false;
		}

		public void Init(InitArguments initArguments)
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

		public override void OnUpdate(float deltaTime)
		{
		}

		public override void Wobble(WobbleAnimation.Settings settings)
		{
		}
	}
}
