namespace GGMatch3
{
	public class CarpetSpread
	{
		public struct SlotData
		{
			public IntVector2 position;

			public bool hasCarpet;

			public bool isCarpetPossible;

			public bool isCarpetSuspended => false;
		}

		private int slotsWithCarpet;

		public SlotData[] slots;

		private CarpetSpreadBehaviour carpetBehaviour;

		private Match3Game game;

		public bool isCarpetPossible => false;

		public bool HasCarpet(IntVector2 position)
		{
			return false;
		}

		public void AddToGoalsAtStart(Match3Goals goals)
		{
		}

		public void Init(Match3Game game, LevelDefinition level)
		{
		}

		private void RefreshVisually()
		{
		}

		public bool IsPossibleToAddCarpet(IntVector2 slotPosition)
		{
			return false;
		}

		public void AddCarpetFromGame(IntVector2 slotPosition)
		{
		}

		private void AddCarpetToSlot(IntVector2 slotPosition)
		{
		}
	}
}
