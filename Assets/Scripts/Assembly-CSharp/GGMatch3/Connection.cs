using System.Collections.Generic;

namespace GGMatch3
{
	public class Connection
	{
		public enum ConnectionType
		{
			Vertical = 0,
			Horizontal = 1,
			Square = 2
		}

		public List<Slot> slotsList;

		public ConnectionType type;

		public ItemColor itemColor => default(ItemColor);

		public bool isUsable => false;

		public bool ContainsPosition(IntVector2 position)
		{
			return false;
		}

		public bool IsIntersecting(Connection c)
		{
			return false;
		}

		public bool IsChipAcceptable(Chip chip)
		{
			return false;
		}

		public void Clear()
		{
		}

		public void CopyFrom(Connection c)
		{
		}
	}
}
