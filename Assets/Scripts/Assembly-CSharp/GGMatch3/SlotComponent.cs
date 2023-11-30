using System.Collections.Generic;

namespace GGMatch3
{
	public class SlotComponent
	{
		public struct SlotStartMoveParams
		{
			public Slot fromSlot;

			public Slot toSlot;

			public SlotComponent slotComponent;
		}

		public Slot slot;

		public Slot lastConnectedSlot;

		public bool isRemovedFromGame;

		private readonly float _003ClastMoveTime_003Ek__BackingField;

		protected List<SlotComponentBehavoiour> monoBehaviours;

		public List<SlotComponentLock> slotComponentLocks;

		private readonly bool _003CisSlotSwapSuspended_003Ek__BackingField;

		private readonly bool _003CisSlotTapSuspended_003Ek__BackingField;

		private readonly bool _003CisSlotMatchingSuspended_003Ek__BackingField;

		private readonly bool _003CisSlotGravitySuspended_003Ek__BackingField;

		private readonly bool _003CisPlaceBubbleSuspended_003Ek__BackingField;

		private readonly bool _003CisMoving_003Ek__BackingField;

		private readonly bool _003CisMoveIntoSlotSuspended_003Ek__BackingField;

		private readonly int _003CblockerLevel_003Ek__BackingField;

		private readonly bool _003CisBlockingBurriedElement_003Ek__BackingField;

		private readonly bool _003CisBlockingCarpetSpread_003Ek__BackingField;

		private readonly bool _003CisBlockingChip_003Ek__BackingField;

		private readonly bool _003CisMoveByConveyorSuspended_003Ek__BackingField;

		private readonly bool _003CcanReactWithBomb_003Ek__BackingField;

		private readonly bool _003CisCreatePowerupWithThisSlotSuspended_003Ek__BackingField;

		private readonly bool _003CisMovingWithConveyor_003Ek__BackingField;

		private readonly bool _003CisMovedByGravity_003Ek__BackingField;

		private readonly bool _003CisPreventingGravity_003Ek__BackingField;

		private readonly bool _003CisPreventingOtherChipsToFallIntoSlot_003Ek__BackingField;

		private readonly bool _003CisPreventingReplaceByOtherChips_003Ek__BackingField;

		public virtual int sortingOrder => 0;

		public virtual bool isMovingElementRequired => false;

		public virtual long lastMoveFrameIndex => 0L;

		public virtual float lastMoveTime => 0f;

		public bool isRemoveFromGameDestroySuspended => false;

		public virtual bool isSlotSwapSuspended => false;

		public virtual bool isSlotTapSuspended => false;

		public virtual bool isSlotMatchingSuspended => false;

		public virtual bool isSlotGravitySuspended => false;

		public virtual bool isPlaceBubbleSuspended => false;

		public virtual bool isMoving => false;

		public virtual bool isMoveIntoSlotSuspended => false;

		public virtual int blockerLevel => 0;

		public virtual bool isBlockingBurriedElement => false;

		public virtual bool isBlockingCarpetSpread => false;

		public virtual bool isBlockingChip => false;

		public virtual bool isMoveByConveyorSuspended => false;

		public virtual bool canReactWithBomb => false;

		public virtual bool isAttachGrowingElementSuspended => false;

		public virtual bool isPowerupReplacementSuspended => false;

		public virtual bool isCreatePowerupWithThisSlotSuspended => false;

		public virtual bool isMovingWithConveyor => false;

		public virtual bool isMovedByGravity => false;

		public virtual bool isDestroyedByMatchingNextTo => false;

		public virtual bool isPreventingGravity => false;

		public virtual bool isPreventingOtherChipsToFallIntoSlot => false;

		public virtual bool isPreventingReplaceByOtherChips => false;

		public virtual void OnSlotComponentMadeAStartMove(SlotStartMoveParams moveParams)
		{
		}

		public virtual void OnSlotComponentMadeATransformChange(SlotComponent component)
		{
		}

		public virtual void AddToGoalsAtStart(Match3Goals goals)
		{
		}

		public virtual SlotDestroyResolution OnDestroyNeighbourSlotComponent(Slot slotBeingDestroyed, SlotDestroyParams destroyParams)
		{
			return default(SlotDestroyResolution);
		}

		public virtual SlotDestroyResolution OnDestroySlotComponent(SlotDestroyParams destroyParams)
		{
			return default(SlotDestroyResolution);
		}

		public void RemoveFromSlot()
		{
		}

		public void RemoveFromGame()
		{
		}

		public void Add(SlotComponentBehavoiour beh)
		{
		}

		public T GetComponentBehaviour<T>() where T : SlotComponentBehavoiour
		{
			return null;
		}

		public void AddLock(SlotComponentLock slotComponentLock)
		{
		}

		public void RemoveLock(SlotComponentLock slotComponentLock)
		{
		}

		public virtual bool IsCompatibleWithPickupGoal(Match3Goals.ChipTypeDef chipTypeDef)
		{
			return false;
		}

		public virtual bool isBlockingDirection(IntVector2 direction)
		{
			return false;
		}

		public virtual bool IsAvailableForDiscoBombSuspended(bool replaceWithBombs)
		{
			return false;
		}

		public virtual void Wobble(WobbleAnimation.Settings settings)
		{
		}

		public virtual void OnUpdate(float deltaTime)
		{
		}

		public virtual void OnMovedBySlotGravity(Slot fromSlot, Slot toSlot, MoveContentsToSlotParams moveParams)
		{
		}

		public virtual void OnCreatedBySlot(Slot toSlot)
		{
		}

		public virtual void OnAddedToSlot(Slot slot)
		{
		}

		public virtual void OnRemovedFromSlot(Slot slot)
		{
		}
	}
}
