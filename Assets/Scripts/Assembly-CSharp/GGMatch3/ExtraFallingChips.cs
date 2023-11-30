using System.Collections.Generic;

namespace GGMatch3
{
	public class ExtraFallingChips
	{
		public class FallingChipPickup
		{
			public int chipTag;
		}

		public class FallingChipCreation
		{
			public Slot slot;

			public int userMovesCount;

			public int slotCreatedChipsNum;

			public int chipTag;
		}

		public ExtraFallingElements setup;

		private List<FallingChipCreation> createdList;

		private List<FallingChipPickup> pickedUpList;

		private int generatedFallingChips => 0;

		public int LastSlotCreatedChipsNum(Slot slot)
		{
			return 0;
		}

		public void Init(ExtraFallingElements extraFallingElements)
		{
		}

		private int GeneratedFallingChipsForTag(int chipTag)
		{
			return 0;
		}

		private int PickedUpChipsForTag(int chipTag)
		{
			return 0;
		}

		public bool ShouldGenerateExtraFallingChip(Slot slot)
		{
			return false;
		}

		public void OnExtraFallingChipGenerated(Slot slot)
		{
		}

		public void OnFallingElementPickup(Chip chip)
		{
		}
	}
}
