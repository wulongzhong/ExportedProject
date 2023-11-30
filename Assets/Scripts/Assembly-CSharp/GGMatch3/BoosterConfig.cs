using System;
using ProtoModels;

namespace GGMatch3
{
	[Serializable]
	public class BoosterConfig
	{
		public BoosterType boosterType;

		public ChipType chipType => default(ChipType);

		public static ChipType BoosterToChipType(BoosterType booster)
		{
			return default(ChipType);
		}

		public static ProtoModels.BoosterType BoosterToProtoType(BoosterType booster)
		{
			return default(ProtoModels.BoosterType);
		}
	}
}
