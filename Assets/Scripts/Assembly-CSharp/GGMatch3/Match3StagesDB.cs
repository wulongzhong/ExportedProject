using System;
using System.Collections.Generic;
using ProtoModels;
using UnityEngine;

namespace GGMatch3
{
	public class Match3StagesDB : ScriptableObject
	{
		[Serializable]
		public class LevelReference
		{
			public string levelDBName;

			public string levelName;

			public LevelDB LevelDB(MainConfig config)
			{
				return null;
			}

			public LevelDefinition Level(MainConfig config)
			{
				return null;
			}
		}

		[Serializable]
		public class Stage : Match3GameListener
		{
			public enum Difficulty
			{
				Normal = 0,
				Hard = 1,
				Nightmare = 2
			}

			[Serializable]
			public class Alternative
			{
				[SerializeField]
				public LevelReference levelReference;
			}

			[SerializeField]
			private Difficulty difficulty_;

			[NonSerialized]
			public int index;

			[NonSerialized]
			private Match3StagesDB stages;

			[SerializeField]
			public LevelReference levelReference;

			private List<LevelReference> levelReferencesToPublish;

			[SerializeField]
			public List<LevelReference> multiLevelReference;

			private List<LevelReference> allLevelReferences_;

			[SerializeField]
			public int coinsCount;

			[SerializeField]
			public List<BoosterType> forbittenBoosters;

			[SerializeField]
			public bool hideUIElements;

			[SerializeField]
			private bool showStarDialog;

			[SerializeField]
			public List<string> startMessages;

			[SerializeField]
			public List<Alternative> alternatives;

			private bool isIntroMessageShown_;

			public Difficulty difficulty
			{
				get
				{
					return default(Difficulty);
				}
				set
				{
				}
			}

			private Match3Stages.Stage model => null;

			public List<LevelReference> allLevelReferences => null;

			public int timesPlayed => 0;

			public bool isIntroMessageShown
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool isPassed => false;

			public bool ShouldUseStarDialog(MainConfig config)
			{
				return false;
			}

			public void Init(Match3StagesDB stages, int index)
			{
			}

			public void OnGameComplete(GameCompleteParams completeParams)
			{
			}

			public void OnGameStarted(GameStartedParams startedParams)
			{
			}
		}

		private const string Filename = "st.bytes";

		public List<BoosterConfig> defaultBoosters;

		[SerializeField]
		public int limit;

		[SerializeField]
		public List<Stage> stages;

		private Match3Stages model;

		public Stage currentStage => null;

		public int passedStages => 0;

		public int stagesPassed
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void InitOnLoad()
		{
		}

		public Stage GetStageForLevelName(string levelDBName, string levelName)
		{
			return null;
		}

		public int PassedStagesInRow(int maxStage)
		{
			return 0;
		}

		public Match3Stages.Stage GetModelForStage(Stage stage)
		{
			return null;
		}

		protected void UpdateData()
		{
		}

		public void ResetAll()
		{
		}

		public static Match3Stages LoadLocalModel()
		{
			return null;
		}

		private void ReloadModel()
		{
		}

		public static Match3Stages ModelFromData(CloudSyncData fileSystemData)
		{
			return null;
		}

		public void SaveModel()
		{
		}
	}
}
