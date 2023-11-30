using UnityEngine;

namespace GGMatch3
{
	public class Chip : SlotComponent
	{
		public int chipTag;

		public bool hasGrowingElement;

		private TransformBehaviour growingElementGraphics;

		private ChipPhysics physics;

		private TeleporterAnimation teleportAnimation;

		public ChipType chipType;

		public ItemColor itemColor;

		public int itemLevel;

		public ChipJumpBehaviour jumpBehaviour;

		private WobbleAnimation wobbleAnimation;

		public int carriesCoins;

		private bool _003CisFeatherShown_003Ek__BackingField;

		public override int sortingOrder => 0;

		public override bool isPlaceBubbleSuspended => false;

		public override bool isPreventingReplaceByOtherChips => false;

		public int moreMovesCount => 0;

		public bool canBeTappedToActivate => false;

		public bool isRocket => false;

		public bool isPowerup => false;

		public override bool isAttachGrowingElementSuspended => false;

		public bool isPickupElement => false;

		public bool isStoppingRocket => false;

		public bool isFallingPickupElement => false;

		public bool canFormColorMatches => false;

		public override long lastMoveFrameIndex => 0L;

		public override float lastMoveTime => 0f;

		public override bool isSlotSwapSuspended => false;

		public override bool isSlotMatchingSuspended => false;

		public override bool isMoving => false;

		public override bool isMoveByConveyorSuspended => false;

		public override bool isDestroyedByMatchingNextTo => false;

		public override bool isSlotGravitySuspended => false;

		public override bool isMovingWithConveyor => false;

		public bool canBeDestroyed => false;

		public override bool canReactWithBomb => false;

		public override bool isMovedByGravity => false;

		public override bool isPreventingOtherChipsToFallIntoSlot => false;

		private MonsterElements.MonsterElementPieces pieceThatWillBeFedThisPiece => null;

		public bool isPartOfActiveGoal => false;

		public bool isFeatherShown => false;

		public void DestroyGrowingElement()
		{
		}

		public void AttachGrowingElement(TransformBehaviour growingElementGraphics)
		{
		}

		public override void AddToGoalsAtStart(Match3Goals goals)
		{
		}

		public void Init(ChipType chipType, ItemColor itemColor)
		{
		}

		public void SetTransformToMove(Transform t)
		{
		}

		public override bool IsCompatibleWithPickupGoal(Match3Goals.ChipTypeDef chipTypeDef)
		{
			return false;
		}

		public override void OnMovedBySlotGravity(Slot fromSlot, Slot toSlot, MoveContentsToSlotParams moveParams)
		{
		}

		public override void Wobble(WobbleAnimation.Settings settings)
		{
		}

		public override void OnCreatedBySlot(Slot toSlot)
		{
		}

		public override void OnUpdate(float deltaTime)
		{
		}

		public void UpdateFeatherShow()
		{
		}

		public override void OnAddedToSlot(Slot slot)
		{
		}

		public override SlotDestroyResolution OnDestroyNeighbourSlotComponent(Slot slotBeingDestroyed, SlotDestroyParams destroyParams)
		{
			return default(SlotDestroyResolution);
		}

		public void DestroyBomb(SlotDestroyParams destroyParams)
		{
		}

		public void RemoveFromGameWithPickupGoal(SlotDestroyParams destroyParams)
		{
		}

		public override SlotDestroyResolution OnDestroySlotComponent(SlotDestroyParams destroyParams)
		{
			return default(SlotDestroyResolution);
		}

		private void DoDestroyFallingPickupElement()
		{
		}

		private SlotDestroyResolution RemoveLevelOnDestroyNeighbourSlotComponent(Slot slotBeingDestroyed, SlotDestroyParams destroyParams)
		{
			return default(SlotDestroyResolution);
		}

		private SlotDestroyResolution RemoveLevelOnDestroy(SlotDestroyParams destroyParams)
		{
			return default(SlotDestroyResolution);
		}

		private void PickupMoreMovesChip(Slot slotBeingDestroyed, SlotDestroyParams destroyParams)
		{
		}

		private void DoDestroyLevel(Slot slotBeingDestroyed, SlotDestroyParams destroyParams)
		{
		}
	}
}
