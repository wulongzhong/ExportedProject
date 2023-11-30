using System;

namespace GGMatch3
{
	[Serializable]
	public class GoalConfig
	{
		public GoalType goalType;

		public ChipType chipType;

		public ItemColor itemColor;

		public int collectCount;

		public bool isCollectAllPresentAtStart => false;

		public GoalConfig Clone()
		{
			return null;
		}

		public bool IsEqualTo(GoalConfig g)
		{
			return false;
		}

		public bool IsCompatible(GoalConfig goalConfig)
		{
			return false;
		}
	}
}
