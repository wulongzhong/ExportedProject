namespace GGMatch3
{
	public struct ActionScore
	{
		public int goalsCount;

		public int powerupsCreated;

		public int obstaclesDestroyed;

		public bool isZero => false;

		public int GoalsAndObstaclesScore(int goalsFactor)
		{
			return 0;
		}

		public static ActionScore operator +(ActionScore a, ActionScore b)
		{
			return default(ActionScore);
		}

		public string ToDebugString()
		{
			return null;
		}
	}
}
