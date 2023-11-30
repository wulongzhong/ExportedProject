namespace GGMatch3
{
	public class IceBlocker : SlotComponent
	{
		public struct InitProperties
		{
			public int level;

			public int sortingOrder;

			public Chip chip;
		}

		private int level;

		private InitProperties initProperties;

		private WobbleAnimation wobbleAnimation;

		private MultiLayerItemBehaviour itemBehaviour => null;

		private TransformBehaviour transformBehaviour => null;

		private IceBehaviour iceBehaviour => null;

		public override int sortingOrder => 0;

		public override bool isBlockingChip => false;

		public override int blockerLevel => 0;

		public override bool isSlotMatchingSuspended => false;

		public override bool isMoveIntoSlotSuspended => false;

		public override bool isSlotGravitySuspended => false;

		public override bool isMovedByGravity => false;

		public override bool isSlotSwapSuspended => false;

		public override bool isPreventingGravity => false;

		public override bool isAttachGrowingElementSuspended => false;

		public override bool isPowerupReplacementSuspended => false;

		public override bool isCreatePowerupWithThisSlotSuspended => false;

		public override bool isMovingWithConveyor => false;

		public void Init(InitProperties initProperties)
		{
		}

		public override bool IsAvailableForDiscoBombSuspended(bool replaceWithBombs)
		{
			return false;
		}

		public override void OnSlotComponentMadeATransformChange(SlotComponent component)
		{
		}

		public override void OnUpdate(float deltaTime)
		{
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
	}
}
