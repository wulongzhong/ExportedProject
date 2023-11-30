using System.Collections.Generic;

namespace GGMatch3
{
	public class Match3Goals
	{
		public struct ChipTypeDef
		{
			public ChipType chipType;

			public ItemColor itemColor;

			public static bool HasColor(ChipType chipType)
			{
				return false;
			}

			public static ChipTypeDef Create(GoalConfig goalConfig)
			{
				return default(ChipTypeDef);
			}

			public static ChipTypeDef Create(Chip chip)
			{
				return default(ChipTypeDef);
			}

			private bool IsColorCompatible(ItemColor a, ItemColor b)
			{
				return false;
			}

			public bool IsEqual(ChipTypeDef b)
			{
				return false;
			}
		}

		public class ChipTypeCounter
		{
			public ChipTypeDef chipTypeDef;

			public int count;

			public int countAtStart;
		}

		private struct SlotData
		{
			public Slot slot;

			public int score;

			public int carpetScore;

			public int blockingLevel;

			public bool isAvailableToSelect;

			public int fallingPickupScore;

			public int chipScore;

			public int TotalScore(bool hasCarpet)
			{
				return 0;
			}

			public void Init(Slot slot)
			{
			}

			public bool IsDestroyable(int additionalLevelsDown)
			{
				return false;
			}

			//public SlotData(Slot slot, int score)
			//{
			//}
		}

		private struct SlotWithScore
		{
			public Slot slot;

			public int score;

			private ActionScore actionScore;
		}

		public class GoalBase
		{
			public GoalConfig config;

			public Match3Goals goals;

			private readonly int _003CCountAtStart_003Ek__BackingField;

			private readonly int _003CRemainingCount_003Ek__BackingField;

			public virtual int CountAtStart => 0;

			public virtual int RemainingCount => 0;

			public virtual void Init(GoalConfig config, Match3Goals goals)
			{
			}

			public virtual bool IsComplete()
			{
				return false;
			}

			public virtual bool IsPartOfGoal(ChipTypeDef chipType)
			{
				return false;
			}

			public virtual int ScoreForSlot(Slot slot)
			{
				return 0;
			}
		}

		public class CollectItemsGoal : GoalBase
		{
			private ChipTypeDef chipTypeDef => default(ChipTypeDef);

			public override int CountAtStart => 0;

			public override int RemainingCount => 0;

			public override bool IsPartOfGoal(ChipTypeDef chipType)
			{
				return false;
			}

			public override bool IsComplete()
			{
				return false;
			}

			public override int ScoreForSlot(Slot slot)
			{
				return 0;
			}
		}

		private List<ChipTypeCounter> chipTypeCounters;

		public List<GoalBase> goals;

		private GoalsDefinition goalsDefinition;

		private SlotData[] slotData;

		private List<Slot> bestSlotsForSeekingMissle;

		private List<SlotData> potentialSlotsForSeekingMissle;

		private List<SlotData> potentialSlotsForSeekingMissleJustBlockers;

		private List<SlotWithScore> potentialSlotsForSeekingMissleWithChip;

		private List<Slot> slotsWithFallingPickups;

		public bool isAllGoalsComplete => false;

		public int TotalMovesCount => 0;

		public ActionScore ActionScoreForDestroyingSwitchingSlots(Slot exchangeSlot, Slot slotToSwipe, Match3Game game, bool isHavingCarpet, bool includeNeighbours)
		{
			return default(ActionScore);
		}

		public ActionScore ActionScoreForDestroyingSlot(Slot slot, Match3Game game, bool isHavingCarpet, bool includeNeighbours)
		{
			return default(ActionScore);
		}

		private ActionScore ActionScoreForDestroyingSwitchingSlots(Slot exchangeSlot, Slot slotToSwipe, bool isHavingCarpet)
		{
			return default(ActionScore);
		}

		private ActionScore ActionScoreForDestroyingSlot(Slot slot, bool isHavingCarpet)
		{
			return default(ActionScore);
		}

		public ActionScore FreshActionScoreForDestroyingSlot(Slot slot)
		{
			return default(ActionScore);
		}

		public bool IsDestroyingSlotCompleatingAGoal(Slot slot, Match3Game game, bool includeNeighbours)
		{
			return false;
		}

		private bool IsDestroyingSlotCompleatingAGoal(Slot slot)
		{
			return false;
		}

		public void FillSlotData(Match3Game game)
		{
		}

		public List<Slot> BestSlotsForSeekingMissleWithChip(Match3Game game, Slot originSlot, ChipType otherChipType)
		{
			return null;
		}

		public List<Slot> BestSlotsForSeekingMissle(Match3Game game, Slot originSlot)
		{
			return null;
		}

		public GoalBase GetActiveGoal(ChipTypeDef chipTypeDef)
		{
			return null;
		}

		public List<GoalBase> GetActiveGoals()
		{
			return null;
		}

		public void OnPickupGoal(GoalBase goal)
		{
		}

		public ChipTypeCounter GetChipTypeCounter(ChipTypeDef chipTypeDef)
		{
			return null;
		}

		public void Init(LevelDefinition levelDefinition, Match3Game game)
		{
		}

		public GoalBase Create(GoalConfig goalConfig)
		{
			return null;
		}
	}
}
