using System;
using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	public class Slot
	{
		public struct PositionIntegrator
		{
			public Vector3 currentPosition;

			public Vector3 prevPosition;

			public Vector3 acceleration;

			public float time;

			public void ResetAcceleration()
			{
			}

			public void SetPosition(Vector3 position)
			{
			}

			public void Update(float deltaTime, float dampingFactor, float stiffness)
			{
			}

			private void FixedUpdate(float fixedTime, float dampingFactor, float stiffness)
			{
			}
		}

		public enum MoveToSlotType
		{
			Gravity = 0,
			Sandflow = 1,
			Portal = 2,
			Jump = 3
		}

		public struct MoveToSlot
		{
			public MoveToSlotType type;

			public Slot slot;

			//public MoveToSlot(MoveToSlotType type, Slot slot)
			//{
			//}
		}

		public class StatsToBottom
		{
			public int emptySpaces;

			public int movingChips;

			public int totalDepth;

			public Chip firstChipBelow;

			public List<Slot> pathSlots;

			public List<ItemColor> availableColors;

			public Slot GetPathSlot(int placesToGoDown)
			{
				return null;
			}

			public void Fill(Slot firstSlot)
			{
			}

			public void Clear()
			{
			}

			public void TryAddChip(Chip firstChip)
			{
			}
		}

		public bool wasRenderedForChocolateLastFrame;

		public Match3Game game;

		public IntVector2 position;

		public PipeBehaviour entrancePipe;

		public PipeBehaviour exitPipe;

		[NonSerialized]
		public GeneratorSetup generatorSetup;

		[NonSerialized]
		public GeneratorSlotSettings generatorSlotSettings;

		private bool isMaxDistanceToEndSet;

		private int _003CmaxDistanceToEnd_003Ek__BackingField;

		public Gravity gravity;

		public bool isExitForFallingChip;

		public PositionIntegrator positionIntegrator;

		public Vector3 prevOffsetPosition;

		public Vector3 offsetPosition;

		public Vector3 offsetScale;

		public List<Slot> portalDestinationSlots;

		public List<Slot> jumpOriginSlots;

		public List<Slot> jumpDestinationSlots;

		public List<Slot> incomingGravitySlots;

		public List<SlotComponent> components;

		private List<Lock> slotLocks;

		private List<SetLock> setSlotLocks;

		public bool canGenerateChip;

		private int generatedFallingElements;

		public LevelDefinition.GeneratorSettings generatorSettings;

		public LightSlotComponent backLight;

		private List<MoveToSlot> allMoveToSlots_;

		private List<SlotComponent> componentsToRemove;

		private List<Slot> neigbourSlots_;

		private bool isNeigbourSlotsListSet;

		private List<SlotComponent> tempSlotComponentsList;

		private StatsToBottom statsToBottom;

		private List<ItemColor> selectedColors;

		private int maxSelectedColorCount;

		[NonSerialized]
		public int createdChips;

		public bool isBackgroundPatternActive => false;

		public Vector2 normalizedPositionWithinBoard => default(Vector2);

		public int maxDistanceToEnd
		{
			get
			{
				return 0;
			}
			protected set
			{
			}
		}

		public Vector3 localPositionOfCenter => default(Vector3);

		public int LockCount => 0;

		public LightSlotComponent light => null;

		public bool isPreventingOtherChipsToFallIntoSlot => false;

		public bool isEmpty => false;

		public bool isDestroyedByMatchingNextTo => false;

		public bool isReacheableByGeneratorOrChip => false;

		public bool isMovingElementRequired => false;

		public bool isLockedForDiscoBomb => false;

		public bool isAttachGrowingElementSuspended => false;

		public bool hasCarpet => false;

		public bool canCarpetSpreadFromHere => false;

		public bool isCreatePowerupWithThisSlotSuspended => false;

		public bool canBeTappedToActivate => false;

		public bool isTapToActivateSuspended => false;

		public bool isChipGeneratorSuspended => false;

		public bool isMoveByConveyorSuspended => false;

		public bool isBlockForGravity => false;

		public int totalBlockerLevelForFalling => 0;

		public int maxBlockerLevel => 0;

		public bool isBlockingBurriedElement => false;

		public int totalBlockerLevel => 0;

		public bool isMoveIntoSlotSuspended => false;

		public bool isSlotGravitySuspendedByComponent => false;

		public bool isMoving => false;

		public bool isSlotGravitySuspended => false;

		public bool isPlaceBubbleSuspended => false;

		public bool isDestroySuspended => false;

		public bool isChipGravitySuspended => false;

		public bool isSlotSwapSuspended => false;

		public bool isPowerupReplacementSuspended => false;

		public bool isSlotMatchingSuspended => false;

		public bool isSlotTouchingSuspended => false;

		public bool isSlotSwipingSuspended => false;

		public bool isPreventingGravity => false;

		public bool isSomethingMoveableByGravityInSlot => false;

		public float lastMoveTime => 0f;

		public long lastMoveFrameIndex => 0L;

		protected List<MoveToSlot> allMoveToSlots => null;

		public List<Slot> neigbourSlots => null;

		public void AddLock(Lock slotLock)
		{
		}

		public void ClearLocks()
		{
		}

		public void RemoveLock(Lock slotLock)
		{
		}

		public void AddSetLock(SetLock slotLock)
		{
		}

		public void RemoveSetLock(SetLock slotLock)
		{
		}

		public void Init(Match3Game game)
		{
		}

		public void AddToGoalsAtStart(Match3Goals goals)
		{
		}

		public T GetSlotComponent<T>() where T : SlotComponent
		{
			return null;
		}

		public bool IsCompatibleWithPickupGoal(Match3Goals.ChipTypeDef chipTypeDef)
		{
			return false;
		}

		public void FillIncomingGravitySlots()
		{
		}

		private static bool IsReacheableByGeneratorOrChip(Slot slot, int depth = 0)
		{
			return false;
		}

		private static Chip FirstReacheableChip(Slot slot, int depth = 0)
		{
			return null;
		}

		public void OnSlotComponentMadeAStartMove(SlotComponent.SlotStartMoveParams startMoveParams)
		{
		}

		public void OnSlotComponentMadeATransformChange(SlotComponent component)
		{
		}

		public bool CanAcceptFallingChip(Slot slotFromWhichToAccept)
		{
			return false;
		}

		public bool CanAttachGrowingElement()
		{
			return false;
		}

		public bool CanParticipateInDiscoBombAffectedArea(ItemColor itemColor, bool replaceWithBombs)
		{
			return false;
		}

		public int IsAboutToBeDestroyedLocksCount()
		{
			return 0;
		}

		public bool isSlotGravitySuspendedByComponentOtherThan(SlotComponent excludedComponent)
		{
			return false;
		}

		private bool IsBlockingPassTo(Slot to)
		{
			return false;
		}

		public bool isSwipeSuspendedTo(Slot slot)
		{
			return false;
		}

		public bool isSlotSwipingSuspendedForSlot(Slot slot)
		{
			return false;
		}

		public void OnUpdate(float deltaTime)
		{
		}

		public Slot NextSlotToPushToWithoutSandflow()
		{
			return null;
		}

		public void Wobble(WobbleAnimation.Settings wobbleSettings)
		{
		}

		public void SetMaxDistanceToEnd(int depth = 0)
		{
		}

		public static bool IsWallBetween(Match3Game game, IntVector2 originPos, IntVector2 destinationPos)
		{
			return false;
		}

		public static bool IsPathBlockedBetween(Slot origin, Slot destination)
		{
			return false;
		}

		public bool IsBlockingPath(IntVector2 direction)
		{
			return false;
		}

		public void ApplySlotGravity()
		{
		}

		public void AddComponent(SlotComponent c)
		{
		}

		public void RemoveComponent(SlotComponent c)
		{
		}

		public void OnDestroyNeighbourSlot(Slot slotBeingDestroyed, SlotDestroyParams destroyParams)
		{
		}

		public void OnDestroySlot(SlotDestroyParams destroyParams)
		{
		}

		private void MoveContentsToSlotByGravity(Slot nextSlot, MoveContentsToSlotParams moveParams)
		{
		}

		private ItemColor ColorToIgnore()
		{
			return default(ItemColor);
		}

		private bool TryGenerateFallingChip()
		{
			return false;
		}

		private void GenerateChip()
		{
		}

		public static void GetStatsToBottom(Slot slot, StatsToBottom sb)
		{
		}

		public static void SwitchChips(Slot slot1, Slot slot2, bool changePosition = false)
		{
		}

		public static bool HasNeighboursAffectedByMatchingSlots(List<Slot> matchingSlots, Match3Game game)
		{
			return false;
		}

		public static void RemoveLocks(Slot slot, Lock slotLock)
		{
		}
	}
}
