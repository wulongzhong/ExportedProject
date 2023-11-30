using System.Collections.Generic;

namespace GGMatch3
{
	public class PowerupActivations
	{
		public class PowerupActivation
		{
			public Slot powerupSlot;

			public ChipType powerupType;

			public Slot exchangeSlot;

			public bool isSwipe => false;

			public bool isTap => false;

			public ActionScore GetActionScore(Match3Game game, Match3Goals goals)
			{
				return default(ActionScore);
			}

			public void InitWithTap(Slot slot, ChipType chipType)
			{
			}

			public void InitWithTap(Slot slot)
			{
			}

			public void InitWithSwap(Slot powerupSlot, Slot exchangeSlot)
			{
			}

			public void InitWithSwap(Slot powerupSlot, Slot exchangeSlot, ChipType chipType)
			{
			}
		}

		public List<PowerupActivation> powerups;

		private List<PowerupActivation> powerupsPool;

		private void ReturnToPool()
		{
		}

		private PowerupActivation GetPowerupActivation()
		{
			return null;
		}

		private bool IsValidSpaceToSwapPowerup(Slot slot)
		{
			return false;
		}

		private bool IsValidPowerupInSlot(Slot slot)
		{
			return false;
		}

		public List<PowerupActivation> CreatePotentialActivations(ChipType chipType, Slot slot)
		{
			return null;
		}

		public void Fill(Match3Game game)
		{
		}
	}
}
