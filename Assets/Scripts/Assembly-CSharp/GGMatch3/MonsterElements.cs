using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	public class MonsterElements
	{
		public class MonsterElementPieces
		{
			public LevelDefinition.MonsterElement element;

			public List<MonsterElementSlotComponent> slotComponents;

			public MonsterElementBehaviour elementBehaviour;

			public int collectedCount;

			public int collectedAnimationsStarted;

			public bool isCollected => false;

			public bool isMoreChipsRequiredToCollect => false;

			public Vector3 LocalPositionOfCenter(Match3Game game)
			{
				return default(Vector3);
			}

			public void OnStartCollectAnimation()
			{
			}

			public void OnCollected(Match3Game game)
			{
			}
		}

		public List<MonsterElementPieces> pieces;

		public MonsterElementPieces GetPieceThatNeedsFeeding(Match3Goals.ChipTypeDef chipTypeDef)
		{
			return null;
		}

		public void Init(Match3Game game, LevelDefinition level)
		{
		}

		public void AddToGoalsAtStart(Match3Goals goals)
		{
		}

		public bool IsCompatibleWithPickupGoal(Slot slot, Match3Goals.ChipTypeDef chipTypeDef)
		{
			return false;
		}
	}
}
