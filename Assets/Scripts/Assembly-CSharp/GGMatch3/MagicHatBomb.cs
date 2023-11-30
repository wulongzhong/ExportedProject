namespace GGMatch3
{
	public class MagicHatBomb : SlotComponent
	{
		private MagicHatBehaviour hatBehaviour;

		private float timeSinceMissleLaunched;

		private int lastBombLaunchedMove;

		private float timeSinceUp;

		private int bombsFired;

		private bool hasBombsCount;

		private int bombsCount;

		private ChipType chipType;

		public override int sortingOrder => 0;

		private MagicHat.Settings settings => null;

		public override bool isSlotMatchingSuspended => false;

		public override bool isAttachGrowingElementSuspended => false;

		public override bool isPlaceBubbleSuspended => false;

		public override bool isMoveIntoSlotSuspended => false;

		public override bool isSlotGravitySuspended => false;

		public override bool isSlotSwapSuspended => false;

		public override bool isPreventingGravity => false;

		public override bool isCreatePowerupWithThisSlotSuspended => false;

		public override bool isMovingWithConveyor => false;

		public override bool isDestroyedByMatchingNextTo => false;

		private bool isUp => false;

		public void Init(MagicHatBehaviour hatBehaviour, int itemCount, ChipType chipType)
		{
		}

		public override bool IsAvailableForDiscoBombSuspended(bool replaceWithBombs)
		{
			return false;
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

		private void FireRocket(Slot slotBeingDestroyed, SlotDestroyParams destroyParams)
		{
		}

		private void UpdateRocket()
		{
		}

		public override void OnUpdate(float deltaTime)
		{
		}
	}
}
