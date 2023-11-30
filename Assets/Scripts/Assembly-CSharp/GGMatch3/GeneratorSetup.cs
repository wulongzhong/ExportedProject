using System;
using System.Collections.Generic;

namespace GGMatch3
{
	[Serializable]
	public class GeneratorSetup
	{
		[Serializable]
		public class GeneratorChipSetup
		{
			public ItemColor itemColor;

			public bool IsEqalTo(GeneratorChipSetup g)
			{
				return false;
			}

			public GeneratorChipSetup Clone()
			{
				return null;
			}
		}

		public IntVector2 position;

		public List<GeneratorChipSetup> chips;

		public bool IsEqualTo(GeneratorSetup g)
		{
			return false;
		}

		public GeneratorSetup Clone()
		{
			return null;
		}
	}
}
