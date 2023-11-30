using System.Collections.Generic;

namespace GGMatch3
{
	public class PotentialMatches
	{
		public class CompoundSlotsSet
		{
			public enum MatchType
			{
				Match = 0,
				DiscoBall = 1,
				Bomb = 2,
				Rocket = 3,
				SeekingMissle = 4,
				CompleatingGoals = 5
			}

			public struct SlotsCount
			{
				public int count;

				public BoardRepresentation.RepresentationSlot slot;
			}

			public List<SlotsSet> slotsSets;

			public BoardRepresentation.RepresentationSlot swipeSlot;

			private List<SlotsCount> slotsCount;

			private List<BoardRepresentation.RepresentationSlot> slotsThatCanSwipe_;

			public IntVector2 positionOfSlotMissingForMatch => default(IntVector2);

			public ChipType createdPowerup => default(ChipType);

			public MatchType matchType => default(MatchType);

			private bool isDiscoBall => false;

			private bool isBomb => false;

			private bool isRocket => false;

			private bool isSeekingMissle => false;

			public bool HasCarpet(Match3Game game)
			{
				return false;
			}

			public ActionScore GetActionScore(Match3Game game, Match3Goals goals)
			{
				return default(ActionScore);
			}

			public void CopyFrom(CompoundSlotsSet c)
			{
			}

			public int CountOfType(SlotsSet.ConnectionType connectionType)
			{
				return 0;
			}

			public bool IsAcceptable(SlotsSet otherSlotSet, BoardRepresentation.RepresentationSlot slotToSwipe)
			{
				return false;
			}

			public void Add(SlotsSet slotsSet)
			{
			}

			public void Clear()
			{
			}
		}

		public class SlotsSet
		{
			public struct ColorCount
			{
				public ItemColor color;

				public int count;
			}

			public enum ConnectionType
			{
				Vertical = 0,
				Horizontal = 1,
				Square = 2
			}

			public List<BoardRepresentation.RepresentationSlot> sameColorSlots;

			public List<BoardRepresentation.RepresentationSlot> differentColorSlots;

			public List<BoardRepresentation.RepresentationSlot> slotsThatCanSwipeToMatch;

			public List<BoardRepresentation.RepresentationSlot> allSlots;

			public List<ColorCount> colorCount;

			public ConnectionType connectionType;

			public ItemColor itemColor => default(ItemColor);

			public IntVector2 positionOfSlotMissingForMatch => default(IntVector2);

			public bool isMatch => false;

			public bool isPotentialMatch => false;

			public bool isMatchWhenSwipe => false;

			public ColorCount DominantColorCount => default(ColorCount);

			public bool HasCarpet(Match3Game game)
			{
				return false;
			}

			public void CopyFrom(SlotsSet s)
			{
			}

			public void AddToAllSlots(BoardRepresentation.RepresentationSlot slot)
			{
			}

			public void SortSlotsUsingDominantColor()
			{
			}

			private void IncrementColorCount(ItemColor color)
			{
			}

			public void AddSlot(BoardRepresentation.RepresentationSlot slot)
			{
			}

			public void Clear(ConnectionType connectionType)
			{
			}

			public bool SwipeSlotsContains(BoardRepresentation.RepresentationSlot slot)
			{
				return false;
			}

			public bool MatchingSlotsContains(BoardRepresentation.RepresentationSlot slot)
			{
				return false;
			}

			private void TryAddSlotThatCanSwipeToMatch(PotentialMatches potentialMatches, BoardRepresentation.RepresentationSlot fromSlot, BoardRepresentation.RepresentationSlot slot, ItemColor desiredItemColor)
			{
			}

			public void FillSlotsThatCanSwipeToMatch(PotentialMatches potentialMatches, BoardRepresentation board)
			{
			}
		}

		public List<SlotsSet> slotSetPool;

		public List<CompoundSlotsSet> compoundPool;

		private List<CompoundSlotsSet> filteredList;

		public List<CompoundSlotsSet> matchesList;

		public BoardRepresentation board;

		public List<SlotsSet> setsThatCanFormMatches;

		public List<SlotsSet> setsThatAreInMatch;

		private SlotsSet searchingSlotSet;

		private CompoundSlotsSet searchingCompoundSlotsSet;

		public int MatchesCount => 0;

		public List<CompoundSlotsSet> FilterForTypeCompleatingGoals(Match3Game game)
		{
			return null;
		}

		public List<CompoundSlotsSet> FilterForType(CompoundSlotsSet.MatchType matchType)
		{
			return null;
		}

		private void Clear()
		{
		}

		private CompoundSlotsSet NextCompound()
		{
			return null;
		}

		private SlotsSet NextSlotsSet()
		{
			return null;
		}

		private void AddMatch(CompoundSlotsSet c)
		{
		}

		private bool IsPartOfMatchList(IntVector2 positionOfSlotMissingForMatch, IntVector2 positionToSwipeFrom)
		{
			return false;
		}

		private void AddSetThatCanFormMatches(SlotsSet slotsSet)
		{
		}

		private void AddSetThatIsInMatch(SlotsSet slotsSet)
		{
		}

		public bool IsPartOfMatch(BoardRepresentation.RepresentationSlot slot)
		{
			return false;
		}

		private SlotsSet FillLineSet(BoardRepresentation board, IntVector2 pos, IntVector2 direction, SlotsSet.ConnectionType connectionType)
		{
			return null;
		}

		private SlotsSet FillSquareSet(BoardRepresentation board, IntVector2 pos)
		{
			return null;
		}

		public void FindPotentialMatches(Match3Game match3Game)
		{
		}

		private int MatchLength(BoardRepresentation board, IntVector2 pos, IntVector2 direction)
		{
			return 0;
		}
	}
}
