using System.Collections.Generic;

namespace GGMatch3
{
	public class Island
	{
		public List<Connection> connectionsList;

		private List<Slot> slotsList;

		public bool isFromSwap;

		public bool isCreatingPowerup => false;

		public ChipType powerupToCreate => default(ChipType);

		public bool isDiscoBall => false;

		public bool isBomb => false;

		public bool isRocket => false;

		public bool isHorizontalRocket => false;

		public bool isSeakingMissle => false;

		public List<Slot> allSlots => null;

		public Connection squareConnection => null;

		public bool ContainsPosition(IntVector2 position)
		{
			return false;
		}

		public void Clear()
		{
		}

		public void AddConnection(List<Connection> list)
		{
		}

		public void AddConnection(Connection c)
		{
		}
	}
}
