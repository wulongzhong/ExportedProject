using System.Collections.Generic;

namespace GGMatch3
{
	public class MultiLevelGoals
	{
		public class Goal
		{
			public GoalConfig config;

			public List<Match3Goals.GoalBase> goals;

			public bool isComplete => false;

			public int RemainingCount => 0;

			public bool IsCompatible(Match3Goals.GoalBase goal)
			{
				return false;
			}
		}

		private List<Match3Goals> goalsList;

		public List<Goal> allGoals;

		private List<Goal> activeGoals;

		public int TotalMovesCount => 0;

		public List<Goal> GetActiveGoals()
		{
			return null;
		}

		private Goal GetOrCreateGoal(GoalConfig goalConfig)
		{
			return null;
		}

		public void Add(Match3Goals goals)
		{
		}
	}
}
