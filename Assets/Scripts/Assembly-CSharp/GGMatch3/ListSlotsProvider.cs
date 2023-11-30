using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	public class ListSlotsProvider : TilesSlotsProvider
	{
		public Match3Game game;

		public List<Slot> allSlots;

		public override int MaxSlots => 0;

		public bool ContainsPosition(IntVector2 position)
		{
			return false;
		}

		public void Clear()
		{
		}

		public void AddSlot(Slot slot)
		{
		}

		public void Init(Match3Game game)
		{
		}

		public override Vector2 StartPosition(float slotSize)
		{
			return default(Vector2);
		}

		public override Slot GetSlot(IntVector2 position)
		{
			return default(Slot);
		}

		public override List<Slot> GetAllSlots()
		{
			return null;
		}
	}
}
