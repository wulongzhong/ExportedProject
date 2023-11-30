using System;
using System.Collections.Generic;

namespace GGMatch3
{
	[Serializable]
	public class ExtraFallingElements
	{
		[Serializable]
		public class ExtraFallingElement
		{
			public int minMovesBeforeActive;

			public int minCreatedChipsBeforeReactivate;

			public ExtraFallingElement Clone()
			{
				return null;
			}

			public bool IsEqualTo(ExtraFallingElement e)
			{
				return false;
			}
		}

		public List<ExtraFallingElement> fallingElementsList;

		public bool IsEqualTo(ExtraFallingElements e)
		{
			return false;
		}

		public ExtraFallingElements Clone()
		{
			return null;
		}
	}
}
