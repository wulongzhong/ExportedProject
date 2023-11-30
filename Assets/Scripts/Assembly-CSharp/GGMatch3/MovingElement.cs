namespace GGMatch3
{
	public class MovingElement : SlotComponent
	{
		private ChipPhysics physics;

		private TeleporterAnimation teleportAnimation;

		public override int sortingOrder => 0;

		public override bool isMovingWithConveyor => false;

		public override bool isMovedByGravity => false;

		public override bool isPreventingOtherChipsToFallIntoSlot => false;

		public override long lastMoveFrameIndex => 0L;

		public override float lastMoveTime => 0f;

		public override bool isSlotSwapSuspended => false;

		public override bool isSlotMatchingSuspended => false;

		public override bool isMoving => false;

		public override bool isMoveByConveyorSuspended => false;

		public override bool isSlotGravitySuspended => false;

		public override void OnCreatedBySlot(Slot toSlot)
		{
		}

		public override void OnMovedBySlotGravity(Slot fromSlot, Slot toSlot, MoveContentsToSlotParams moveParams)
		{
		}

		public override void OnUpdate(float deltaTime)
		{
		}

		public override void OnAddedToSlot(Slot slot)
		{
		}
	}
}
