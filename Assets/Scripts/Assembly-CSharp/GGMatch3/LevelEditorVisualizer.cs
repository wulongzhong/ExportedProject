using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GGMatch3
{
	[ExecuteInEditMode]
	public class LevelEditorVisualizer : MonoBehaviour, Match3GameListener
	{
		[Serializable]
		public class UIElementPool
		{
			public GameObject prefab;

			public Transform parent;

			public List<GameObject> usedObjects;

			public List<GameObject> notUsedObjects;

			public float prefabWidth => 0f;

			public float prefabHeight => 0f;

			public void DestroyObjectsFromPool()
			{
			}

			public void Init()
			{
			}

			public void Clear(bool hideNotActive)
			{
			}

			public void HideNotActive()
			{
			}

			public T Next<T>(bool activate = true) where T : MonoBehaviour
			{
				return null;
			}
		}

		public struct GeneratorSetupHit
		{
			public bool isHit;

			public int generatorSetupIndex;

			public int generatorSetupChipIndex;
		}

		[SerializeField]
		public StagesAnalyticsDB analyticsDB;

		[SerializeField]
		public string levelDBName;

		[SerializeField]
		public List<string> possibleLevelDB;

		[SerializeField]
		public MainConfig config;

		public TestExecutor test;

		[SerializeField]
		public bool justEditMode;

		[SerializeField]
		public bool showDifficulties;

		[SerializeField]
		public bool limitStages;

		[SerializeField]
		public int minStage;

		[SerializeField]
		public int maxStage;

		[NonSerialized]
		public bool isGamePlaying;

		[SerializeField]
		private UIElementPool slotPool;

		[SerializeField]
		private UIElementPool burriedElementPool;

		[SerializeField]
		private UIElementPool monsterElementPool;

		[SerializeField]
		private UIElementPool generatorSetupPool;

		[SerializeField]
		public RectTransform container;

		[SerializeField]
		public RectTransform screenContainer;

		[SerializeField]
		private RectTransform buttonsContainer;

		[SerializeField]
		private Text buttonLabel;

		[SerializeField]
		private RectTransform innerContainer;

		[SerializeField]
		private LevelEditorSlot markerSlot;

		[SerializeField]
		public LevelDefinition.SlotDefinition markerSlotDefinition;

		[SerializeField]
		public int repeatTimes;

		[SerializeField]
		public bool isHudDissabled;

		[SerializeField]
		public int stepsPerFrame;

		[SerializeField]
		public bool humanVisibleDebug;

		[SerializeField]
		public bool setRandomSeed;

		[SerializeField]
		public int randomSeed;

		[SerializeField]
		public GameResults lastResult;

		[SerializeField]
		public string resultString;

		private LevelDB loadedLevelDB;

		private string loadedLevelDBName;

		[NonSerialized]
		public long lastShownLevelIndex;

		[NonSerialized]
		public string lastShownLevelName;

		private List<GeneratorSetup> generatorSetupsInSameRow;

		public bool isShowDifficiltiesVisible => false;

		public bool isShowLevelsVisible => false;

		public bool isShowStagesVisible => false;

		public LevelDB levelDB => null;

		public string levelName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LevelDefinition level => null;

		public bool IsWorldToPositionOnBoard(Vector3 wordPos)
		{
			return false;
		}

		public IntVector2 WorldToBoardPositionClamped(Vector3 wordPos)
		{
			return default(IntVector2);
		}

		public IntVector2 WorldToBoardPosition(Vector3 wordPos)
		{
			return default(IntVector2);
		}

		public void HideMarker()
		{
		}

		public void SetSlot(IntVector2 position, LevelDefinition.SlotDefinition slotDefinition)
		{
		}

		public void ShowMarker(LevelDefinition.SlotDefinition slotDefiniton)
		{
		}

		public void Refresh()
		{
		}

		public Vector3 GetLocalPosition(LevelDefinition level, IntVector2 position)
		{
			return default(Vector3);
		}

		public void ShowLevel(LevelDefinition level)
		{
		}

		public GeneratorSetupHit GetGeneratorSetupHit(Vector3 worldPos)
		{
			return default(GeneratorSetupHit);
		}

		public Vector3 GetStartPositionForGeneratorSetup(int generatorSetupIndex)
		{
			return default(Vector3);
		}

		public void GrowLevel(int cellsToAdd)
		{
		}

		public void GrowLevelWidth(int cellsToAdd)
		{
		}

		public void GrowLevelHeight(int cellsToAdd)
		{
		}

		public void ClearLevel()
		{
		}

		public void TrimLevel()
		{
		}

		private void CopyWithOffsetBounds(List<LevelDefinition.SlotDefinition> copyFrom, LevelDefinition level, IntVector2 offset)
		{
		}

		private void CopyWithOffset(List<LevelDefinition.SlotDefinition> copyFrom, LevelDefinition level, IntVector2 offset)
		{
		}

		public void PopulateBoardRandom()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		public void OnGameComplete(GameCompleteParams completeParams)
		{
		}

		public void OnGameStarted(GameStartedParams startedParams)
		{
		}

		public void PlayGame()
		{
		}

		public void StopMultipleTests()
		{
		}

		public void PlayMultipleTests()
		{
		}

		public void PlayTestGame()
		{
		}

		public void PlayGame(Match3GameParams initParams)
		{
		}

		private void SetLabel(Text label, string text)
		{
		}

		public void StopGame()
		{
		}

		public void ClearPools()
		{
		}

		public void Callback_TogglePlay()
		{
		}
	}
}
