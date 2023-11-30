using System.Collections.Generic;

namespace GGMatch3
{
	public class SlotDestroyParams
	{
		public bool isFromTap;

		public bool isFromSwap;

		public bool isHitByBomb;

		public ChipType bombType;

		public float activationDelay;

		public Island matchIsland;

		public bool isBombAllowingNeighbourDestroy;

		public bool isHavingCarpet;

		public bool isCreatingPowerupFromThisMatch;

		public bool isNeigbourDestroySuspended;

		public bool isExplosion;

		public int goalsCollected;

		public IntVector2 explosionCentre;

		public bool isRocketStopped;

		public int chipBlockersDestroyed;

		public int chipsDestroyed;

		public int scoreAdded;

		public SwapParams swapParams;

		public List<Chip> chipsAvailableForPowerupCreateAnimation;

		public List<Slot> slotsWithSuspendCheckNeighbor;

		public bool isFromSwapOrTap => false;

		public void StartSlot(Slot slot)
		{
		}

		public void EndSlot(Slot slot)
		{
		}

		public void AddChipForPowerupCreateAnimation(Chip chip)
		{
		}

		public void AddSlotForSuspendedNeighbor(Slot slot)
		{
		}

		public bool IsNeigborDestraySuspended(Slot slot)
		{
			return false;
		}
	}
}
