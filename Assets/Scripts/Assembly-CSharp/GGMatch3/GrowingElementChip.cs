using System.Collections.Generic;

namespace GGMatch3
{
	public class GrowingElementChip : SlotComponent
	{
		public struct PotentialElementToReceieve
		{
			public Slot slot;

			public Chip chip;
		}

		private ItemColor itemColor;

		private WobbleAnimation wobbleAnimation;

		private int currentLevel;

		private List<PotentialElementToReceieve> potentialElements;

		private List<PotentialElementToReceieve> selectedElements;

		public bool isGeneratingSpecificColor => false;

		private GrowingElementBehaviour elementBehaviour => null;

		public override bool isPlaceBubbleSuspended => false;

		public override bool isSlotMatchingSuspended => false;

		public override bool isPreventingOtherChipsToFallIntoSlot => false;

		public override bool isAttachGrowingElementSuspended => false;

		public override bool isMoveIntoSlotSuspended => false;

		public override bool isSlotGravitySuspended => false;

		public override bool isSlotSwapSuspended => false;

		public override bool isPreventingGravity => false;

		public override bool isCreatePowerupWithThisSlotSuspended => false;

		public override bool isMovingWithConveyor => false;

		public override bool isDestroyedByMatchingNextTo => false;

		public void Init(ItemColor itemColor)
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

		private void UpdateLevel(SlotDestroyParams destroyParams)
		{
		}

		private List<PotentialElementToReceieve> PotentialElementToAttach()
		{
			return null;
		}

		private List<PotentialElementToReceieve> PotentialElementToAttachEmptySlots()
		{
			return null;
		}

		public Slot RandomDesiredSlot()
		{
			return null;
		}

		private void CreateFlowers()
		{
		}

		public override void OnUpdate(float deltaTime)
		{
		}

		public override void Wobble(WobbleAnimation.Settings settings)
		{
		}

		private void VisualUpdate()
		{
		}
	}
}
