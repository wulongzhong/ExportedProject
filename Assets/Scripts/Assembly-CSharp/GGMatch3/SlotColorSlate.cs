namespace GGMatch3
{
	public class SlotColorSlate : SlotComponent
	{
		private int level;

		private MultiLayerItemBehaviour itemBehaviour => null;

		public override bool isBlockingChip => false;

		public override bool isDestroyedByMatchingNextTo => false;

		public override bool isBlockingBurriedElement => false;

		public override bool isBlockingCarpetSpread => false;

		public override int blockerLevel => 0;

		public override int sortingOrder => 0;

		public override bool isMovingWithConveyor => false;

		public void Init(int level)
		{
		}

		private void DestroyLayer(SlotDestroyParams destroyParams)
		{
		}

		public override void AddToGoalsAtStart(Match3Goals goals)
		{
		}

		public override bool IsCompatibleWithPickupGoal(Match3Goals.ChipTypeDef chipTypeDef)
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
	}
}
