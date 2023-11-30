using System.Collections.Generic;

namespace GGMatch3
{
	public class BoardRepresentation
	{
		public struct RepresentationSlot
		{
			public bool canFormColorMatches;

			public IntVector2 position;

			public ItemColor itemColor;

			public bool isOutsideBoard;

			public bool canMove;

			public bool wallLeft;

			public bool wallRight;

			public bool wallUp;

			public bool wallDown;

			public bool isOutOfPlayArea;

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

		public RepresentationSlot GetSlot(IntVector2 pos)
		{
			return default(RepresentationSlot);
		}

		public void Init(Match3Game match3Game)
		{
		}
	}
}
