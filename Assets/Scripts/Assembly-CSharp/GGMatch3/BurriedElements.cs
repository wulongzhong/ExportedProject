using System.Collections.Generic;

namespace GGMatch3
{
	public class BurriedElements
	{
		private Match3Game game;

		public List<BurriedElementPiece> elementPieces;

		private List<BurriedElementPiece> tempList;

		public void Init(Match3Game game, LevelDefinition level)
		{
		}

		public bool IsCompatibleWithPickupGoal(Slot slot, Match3Goals.ChipTypeDef chipTypeDef)
		{
			return false;
		}

		public bool ContainsPosition(IntVector2 position)
		{
			return false;
		}

		public void AddToGoalsAtStart(Match3Goals goals)
		{
		}

		public void Remove(BurriedElementPiece piece)
		{
		}

		public void WobbleAll()
		{
		}

		public void OnSlateDestroyed(Slot slot, SlotDestroyParams destroyParams)
		{
		}

		public void Update(float deltaTime)
		{
		}
	}
}
