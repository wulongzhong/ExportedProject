namespace GGMatch3
{
	public class MonsterElementSlotComponent : SlotComponent
	{
		public override int sortingOrder => 0;

		public override bool isMoveIntoSlotSuspended => false;

		public override bool isSlotGravitySuspended => false;

		public override bool isSlotSwapSuspended => false;

		public override bool isPreventingOtherChipsToFallIntoSlot => false;

		public override bool isPreventingGravity => false;

		public override bool isCreatePowerupWithThisSlotSuspended => false;

		public override bool isMovingWithConveyor => false;

		public override bool isAttachGrowingElementSuspended => false;

		public override bool isPlaceBubbleSuspended => false;
	}
}
