using System;

namespace GGOptimize
{
	[Serializable]
	public class BucketRange
	{
		public int min;

		public int max;

		public int count => 0;

		public bool IsAcceptable(int bucket)
		{
			return false;
		}
	}
}
