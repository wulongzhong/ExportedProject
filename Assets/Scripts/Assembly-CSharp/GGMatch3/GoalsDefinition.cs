using System;
using System.Collections.Generic;

namespace GGMatch3
{
	[Serializable]
	public class GoalsDefinition
	{
		public int movesCount;

		public List<GoalConfig> goals;

		public bool IsEqualTo(GoalsDefinition g)
		{
			return false;
		}

		public GoalsDefinition Clone()
		{
			return null;
		}
	}
}
