using System.Collections.Generic;

namespace GGMatch3
{
	public class PowerupCombines
	{
		public enum CombineType
		{
			Unknown = 0,
			DoubleSeekingMissle = 1,
			DoubleRocket = 2,
			DoubleBomb = 3,
			DoubleDiscoBall = 4,
			DiscoBallColor = 5,
			DiscoBallSeekingMissle = 6,
			DiscoBallRocket = 7,
			DiscoBallBomb = 8,
			RocketSeekingMissle = 9,
			RocketBomb = 10,
			BombSeekingMissle = 11
		}

		public class PowerupCombine
		{
			public Slot powerupSlot;

			public Slot exchangeSlot;

			private List<Slot> affectedSlotsList;

			public CombineType combineType => default(CombineType);

			public ActionScore GetActionScore(Match3Game game, Match3Goals goals)
			{
				return default(ActionScore);
			}

			private bool IsChipType(Slot slot, ChipType chipType)
			{
				return false;
			}

			public int Count(ChipType chipType)
			{
				return 0;
			}

			private bool IsChipType(Slot slot, ChipType chipType, ChipType chipType2)
			{
				return false;
			}

			public int Count(ChipType chipType, ChipType chipType2)
			{
				return 0;
			}
		}

		public List<PowerupCombine> combines;

		private List<PowerupCombine> combinesPool;

		private List<PowerupCombine> filteredCombines;

		private void ReturnToPool()
		{
		}

		private PowerupCombine GetCombineFromPool()
		{
			return null;
		}

		private bool IsValidPowerupInSlot(ChipType chipType, Slot slot)
		{
			return false;
		}

		private bool IsValidPowerupInSlot(Slot slot)
		{
			return false;
		}

		public List<PowerupCombine> FilterCombines(CombineType combineType)
		{
			return null;
		}

		public void Fill(Match3Game game)
		{
		}
	}
}
