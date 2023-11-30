using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	public class TilesSlotsProvider
	{
		public struct Slot
		{
			public bool isOccupied;

			public IntVector2 position;

			public bool isEmpty => false;

			//public Slot(IntVector2 position, bool isOccupied)
			//{
			//}
		}

		public virtual int MaxSlots => 0;

		public virtual Vector2 StartPosition(float slotSize)
		{
			return default(Vector2);
		}

		public virtual Slot GetSlot(IntVector2 position)
		{
			return default(Slot);
		}

		public virtual List<Slot> GetAllSlots()
		{
			return null;
		}
	}
}
