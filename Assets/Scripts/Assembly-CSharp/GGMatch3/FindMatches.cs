using System.Collections.Generic;

namespace GGMatch3
{
	public class FindMatches
	{
		public Match3Board board;

		public Matches matches;

		private Connection currentConnection;

		private List<Island> connectedIslands;

		public IntVector2 size => default(IntVector2);

		public void Init(Match3Board board)
		{
		}

		private Slot GetSlot(IntVector2 pos)
		{
			return null;
		}

		private bool CanParticipateInMatch(Slot slot)
		{
			return false;
		}

		private void AddSlotToLineConnectionIfPossible(Connection currentConnection, int x, int y, bool isLast, Matches matches)
		{
		}

		public Matches FindAllMatches()
		{
			return null;
		}
	}
}
