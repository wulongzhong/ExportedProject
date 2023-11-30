using System.Collections.Generic;

namespace GGMatch3
{
	public class CompositeAffector : PlayerInput.AffectorBase
	{
		public class SwipedSlot
		{
			public IntVector2 cameFromPosition;

			public Chip otherChipToMove;

			public Slot slot;

			public bool isCreatingPowerup;

			public Slot mixSlot;

			public PlayerInput.MixClass mixClass;

			public bool isDiscoCombine;

			public List<Slot> matchingSlots;

			public bool isMix => false;

			public bool isPowerup => false;

			public ChipType chipType => default(ChipType);

			public bool isMatching => false;

			public void SetMix(Slot mixSlot)
			{
			}

			public void SetOtherChipMatch(Slot otherSlot, Island otherIsland)
			{
			}

			public void SetMatch(Island island)
			{
			}
		}

		public class InitArguments
		{
			public Match3Game game;

			public List<SwipedSlot> swipedSlots;

			public SwipedSlot AddSwipedSlot(Slot slot)
			{
				return null;
			}
		}

		private InitArguments initArguments;

		private List<ChipAffectorBase> chipAffectors;

		private List<Slot> ignoreSlots;

		public override bool wantsToEnd => false;

		public override bool canFinish => false;

		public override float minAffectorDuration => 0f;

		public override void ReleaseLocks()
		{
		}

		public override void ApplyLocks()
		{
		}

		public void Init(InitArguments initArguments)
		{
		}

		public override void AddToSwitchSlotArguments(ref Match3Game.SwitchSlotsArguments switchSlotsArguments)
		{
		}

		public override void Clear()
		{
		}

		public override void OnBeforeDestroy()
		{
		}

		public override void OnUpdate(PlayerInput.AffectorUpdateParams updateParams)
		{
		}
	}
}
