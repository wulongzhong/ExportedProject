using System;
using System.Collections.Generic;

namespace GGOptimize
{
	[Serializable]
	public class ExperimentsDefinition
	{
		public Variation defaultProperties;

		public List<Experiment> experiments;
	}
}
