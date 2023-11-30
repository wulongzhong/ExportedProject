using System;
using System.Collections.Generic;
using UnityEngine;

public class StagesAnalyticsDB : ScriptableObject
{
	[Serializable]
	public class StageData
	{
		[Serializable]
		public class MovesData
		{
			public enum PassedType
			{
				Passed = 0,
				NotPassed = 1
			}

			[SerializeField]
			public PassedType passed;

			[SerializeField]
			public int moves;

			[SerializeField]
			public int games;
		}

		[Serializable]
		public class PlayedData
		{
			[SerializeField]
			public int timesPlayed;

			[SerializeField]
			public int games;
		}

		public int stageIndex;

		[SerializeField]
		public List<MovesData> moves;

		[SerializeField]
		public List<PlayedData> playedData;

		[SerializeField]
		public int usersStarted;
	}

	[SerializeField]
	public List<StageData> stages;

	public StageData GetOrCreateStageData(int index)
	{
		return null;
	}

	public StageData GetStageData(int index)
	{
		return null;
	}
}
