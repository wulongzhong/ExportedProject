using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	public class LevelDefinitionTilesSlotsProvider : TilesSlotsProvider
	{
		public LevelDefinition level;

		private List<Slot> allSlots;

		public override int MaxSlots => 0;

		public LevelDefinitionTilesSlotsProvider(LevelDefinition level)
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

		private bool IsOccupied(LevelDefinition.SlotDefinition levelSlot)
		{
			return false;
		}

		public override List<Slot> GetAllSlots()
		{
			return null;
		}
	}
}
