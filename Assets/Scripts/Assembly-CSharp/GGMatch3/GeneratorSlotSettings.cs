using System;
using System.Collections.Generic;

namespace GGMatch3
{
	[Serializable]
	public class GeneratorSlotSettings
	{
		public float weight;

		public bool hasIce;

		public int iceLevel;

		public List<LevelDefinition.ChipGenerationSettings.ChipSetting> chipSettings;

		public bool IsEqualTo(GeneratorSlotSettings g)
		{
			return false;
		}

		public GeneratorSlotSettings Clone()
		{
			return null;
		}
	}
}
