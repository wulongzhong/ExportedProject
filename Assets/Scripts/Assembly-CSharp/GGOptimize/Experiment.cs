using System;
using System.Collections.Generic;

namespace GGOptimize
{
	[Serializable]
	public class Experiment
	{
		public string name;

		public string guid;

		public BucketRange bucketRange;

		public string customDimensionToMark;

		public bool onlyNewUsers;

		public bool acceptsNewUsers;

		public bool useLocalBucket;

		public bool isArchived;

		public List<Variation> variations;

		public bool IsActive(Optimize optimize)
		{
			return false;
		}

		public Variation GetActiveVariation(int userBucket)
		{
			return null;
		}
	}
}
