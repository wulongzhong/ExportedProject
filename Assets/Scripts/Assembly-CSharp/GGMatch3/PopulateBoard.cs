using System.Collections.Generic;

namespace GGMatch3
{
	public class PopulateBoard
	{
		public class BoardRepresentation
		{
			public class RepresentationSlot
			{
				public bool needsToBeGenerated;

				public bool isGenerated;

				public ItemColor cachedColor;

				public bool wallLeft;

				public bool wallRight;

				public bool wallUp;

				public bool wallDown;

				public bool isFormingColorMatchesSuspended;

				public IntVector2 position;

				public ItemColor itemColor;

				public bool canMove;

				public bool isOutOfPlayArea;

				public bool isPositionInEmptyNeighbourhoodAtStart;

				public bool isMatchCheckingRequired;

				public bool canFormColorMatches => false;

				private bool IsBlocked(IntVector2 direction)
				{
					return false;
				}

				public bool IsBlockedTo(RepresentationSlot slot)
				{
					return false;
				}
			}

			public IntVector2 size;

			public List<RepresentationSlot> slots;

			private List<IntVector2> slotNeighboursOffsets_;

			public List<IntVector2> slotNeighboursOffsets => null;

			public RepresentationSlot GetSlot(IntVector2 pos)
			{
				return null;
			}

			public void Init(LevelDefinition level)
			{
			}

			public void Init(Match3Game game, bool generateFlowerChips)
			{
			}
		}

		public class PotentialMatch
		{
			public List<BoardRepresentation.RepresentationSlot> slotsThatNeedToBeTheSame;

			public PotentialMatch(BoardRepresentation.RepresentationSlot slot1, BoardRepresentation.RepresentationSlot slot2, BoardRepresentation.RepresentationSlot slot3)
			{
			}
		}

		public class Params
		{
			public List<ItemColor> availableColors;

			public int maxPotentialMatches;

			public RandomProvider randomProvider;
		}

		public class MatchBuilder
		{
			public class Match
			{
				public List<BoardRepresentation.RepresentationSlot> slots;

				public List<BoardRepresentation.RepresentationSlot> allSlots_;

				public BoardRepresentation.RepresentationSlot movingSlot;

				public List<ItemColor> availableColor;

				public List<BoardRepresentation.RepresentationSlot> allSlots => null;
			}

			public class MatchPattern
			{
				public List<SlotCandidate> matching;

				public SlotCandidate moving;

				public BoardRepresentation.RepresentationSlot swipeSlot;

				public List<ItemColor> availableColors;

				public List<ItemColor> swipeSlotAvailableColors;

				public int match1Index;

				public int match2Index;

				public int movingIndex;

				public bool isMatch => false;

				public MatchPattern(int match1Index, int match2Index, int movingIndex)
				{
				}

				public void Clear()
				{
				}

				public void Init(List<SlotCandidate> candidates)
				{
				}

				public void FillAvailableColors()
				{
				}

				private bool IsInList(BoardRepresentation.RepresentationSlot slot, List<SlotCandidate> list)
				{
					return false;
				}

				public void FindSwipeSlot(BoardRepresentation board, MatchingCheck matchingCheck)
				{
				}
			}

			public class SlotCandidate
			{
				public BoardRepresentation.RepresentationSlot slot;

				public List<ItemColor> availableColors;

				public ItemColor originalItemColor;

				public bool originalIsGenerated;

				public void Init(BoardRepresentation.RepresentationSlot slot)
				{
				}
			}

			public List<SlotCandidate> candidates;

			private List<MatchPattern> matchPatterns;

			public void Init(BoardRepresentation.RepresentationSlot slot1, BoardRepresentation.RepresentationSlot slot2, BoardRepresentation.RepresentationSlot slot3)
			{
			}

			public bool Find(MatchingCheck matchCheck, BoardRepresentation board, List<ItemColor> availableColors)
			{
				return false;
			}

			public void FillMatchesIn(List<Match> matchesList)
			{
			}

			private void FillAvailableColorsForAllCandidates(MatchingCheck matchCheck, BoardRepresentation board, List<ItemColor> availableColors)
			{
			}
		}

		public class MatchingCheck
		{
			public struct MatchingResult
			{
				public bool isMatching;

				public ItemColor itemColor;
			}

			public class MatchPositionList
			{
				public List<IntVector2> positionOffsets;

				public MatchPositionList(IntVector2 pos1, IntVector2 pos2)
				{
				}

				public MatchPositionList(IntVector2 pos1, IntVector2 pos2, IntVector2 pos3)
				{
				}

				public MatchingResult GetMatchingResult(BoardRepresentation board, IntVector2 originPos)
				{
					return default(MatchingResult);
				}
			}

			private BoardRepresentation board;

			private IntVector2 originPos;

			public List<ItemColor> colorsThatWouldFormAMatch;

			public List<ItemColor> availableColors;

			private List<MatchPositionList> matchingPositionsList;

			private void Init()
			{
			}

			private void Clear()
			{
			}

			private void AddColorThatWouldFormAMatch(ItemColor color)
			{
			}

			public void Check(BoardRepresentation board, IntVector2 pos, List<ItemColor> availableColors)
			{
			}

			public static bool IsMatching(BoardRepresentation.RepresentationSlot slot1, BoardRepresentation.RepresentationSlot slot2)
			{
				return false;
			}
		}

		private List<BoardRepresentation.RepresentationSlot> mustEnsureNoMatching;

		private List<BoardRepresentation.RepresentationSlot> canHaveAnyColor;

		private List<BoardRepresentation.RepresentationSlot> canNotFormMatches;

		private List<IntVector2> cachedList;

		private Params initParams;

		private MatchingCheck matchingCheck;

		private MatchBuilder matchBuilder;

		public BoardRepresentation board;

		private void Clear()
		{
		}

		private ItemColor RandomColor()
		{
			return default(ItemColor);
		}

		private ItemColor RandomColor(List<ItemColor> availableColors)
		{
			return default(ItemColor);
		}

		public void RandomPopulate(LevelDefinition level, Params initParams)
		{
		}

		public bool RandomPopulate(BoardRepresentation board, Params initParams)
		{
			return false;
		}

		private bool IsIntersectingWithList(MatchBuilder.Match match, List<MatchBuilder.Match> list)
		{
			return false;
		}

		private bool IsAvailableForSwap(BoardRepresentation.RepresentationSlot fromSlot, BoardRepresentation.RepresentationSlot slot)
		{
			return false;
		}

		private bool IsInCanHaveAnyColor(BoardRepresentation.RepresentationSlot slot)
		{
			return false;
		}

		private void GenerateSlotInMatch(BoardRepresentation.RepresentationSlot slot)
		{
		}
	}
}
