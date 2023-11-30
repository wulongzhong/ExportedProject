using System.Collections.Generic;

namespace GGMatch3
{
	public class BubblesBoardComponent : BoardComponent
	{
		private Match3Game game;

		private bool isAnyBubbleBurst;

		private int movesCountWhenTookAction;

		private LockContainer lockContainer;

		private Lock globalLock;

		private List<Slot> allSlotsList;

		private List<Slot> slotsWhereCanPlaceNewBubble;

		private bool _isCleared;

		private bool isCleared => false;

		private List<Slot> allSlotsContainingBubbles => null;

		public bool isWaitingForBubblesToBurst => false;

		public void OnBubbleBurst(BubblesPieceBlocker bubble)
		{
		}

		public void Init(Match3Game game)
		{
		}

		public void CancelSpread()
		{
		}

		public void OnUserMadeMove()
		{
		}

		public override void Update(float deltaTime)
		{
		}
	}
}
