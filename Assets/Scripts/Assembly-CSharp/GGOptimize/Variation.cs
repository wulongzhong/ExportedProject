using System;
using System.Collections.Generic;

namespace GGOptimize
{
	[Serializable]
	public class Variation
	{
		public string name;

		public List<NamedProperty> properties;

		protected Dictionary<string, NamedProperty> propertyDictionary_;

		protected Dictionary<string, NamedProperty> propertyDictionary => null;

		public Variation()
		{
		}

		public Variation(string name)
		{
		}

		public NamedProperty GetProperty(string name)
		{
			return null;
		}
	}
}
