using System;

namespace GGOptimize
{
	[Serializable]
	public class NamedProperty
	{
		public string name;

		public NamedPropertyDataType dataType;

		public int intVal;

		public bool boolVal;

		public string strVal;

		public float floatVal;

		public int GetInt()
		{
			return 0;
		}

		public bool GetBool()
		{
			return false;
		}

		public string GetString()
		{
			return null;
		}
	}
}
