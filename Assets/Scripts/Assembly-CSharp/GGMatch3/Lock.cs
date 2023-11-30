using System.Collections.Generic;

namespace GGMatch3
{
	public class Lock
	{
		public bool isSlotGravitySuspended;

		public bool isChipGravitySuspended;

		public bool isChipGeneratorSuspended;

		public bool isSlotMatchingSuspended;

		public bool isSlotTouchingSuspended;

		public bool isSlotSwipeSuspended;

		public bool isDestroySuspended;

		public bool isAvailableForDiscoBombSuspended;

		public bool isAvailableForSeekingMissileSuspended;

		public bool isAboutToBeDestroyed;

		public bool isPowerupReplacementSuspended;

		public bool isAttachGrowingElementSuspended;

		private List<Slot> connectedSlots;

		private List<Slot> temporaryList;

		public void SuspendAll()
		{
		}

		public void LockSlots(List<Slot> slots)
		{
		}

		public void LockSlot(Slot slot)
		{
		}

		public void UnlockAllAndSaveToTemporaryList()
		{
		}

		public void SaveToTemporaryList()
		{
		}

		public void LockTemporaryListAndClear()
		{
		}

		public void Unlock(Slot slot)
		{
		}

		public void UnlockAll()
		{
		}
	}
}
