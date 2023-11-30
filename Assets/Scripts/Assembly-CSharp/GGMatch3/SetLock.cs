using System.Collections.Generic;

namespace GGMatch3
{
	public class SetLock
	{
		public List<Slot> slots;

		public bool isSwapingSuspended;

		public bool GetIsSwappingSuspended(Slot slot)
		{
			return false;
		}
	}
}
