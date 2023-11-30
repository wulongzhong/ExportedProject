using System;
using System.Collections.Generic;
using GGMatch3;
using TMPro;
using UnityEngine;

public class PreGameDialog : MonoBehaviour
{
	public struct ShowParams
	{
		public MainConfig config;

		public Match3StagesDB.Stage stage;

		public DecorateRoomScreen screen;

		public Action onHide;

		public Action<Match3GameParams> onStart;

		public string textToDisplay;

		public Match3GameParams gameParams;
	}

	public class StageGoalsConfig
	{
		public List<GoalConfig> goals;

		public void AddGoal(GoalConfig newGoal)
		{
		}
	}

	[SerializeField]
	private List<Transform> levelDifficultyWidgets;

	[SerializeField]
	private VisualStyleSet normalDifficultySlyle;

	[SerializeField]
	private VisualStyleSet hardDifficultySlyle;

	[SerializeField]
	private VisualStyleSet nightmareDifficultySlyle;

	[SerializeField]
	private TextMeshProUGUI stageNameLabel;

	[SerializeField]
	private ComponentPool goalsPool;

	[SerializeField]
	private ComponentPool boostersPool;

	private DecorateRoomScreen screen;

	private List<PreGameDialogBoosterPrefab> usedBoosters;

	[SerializeField]
	private List<RectTransform> widgetsToHide;

	[SerializeField]
	private VisualStyleSet starStyle;

	[SerializeField]
	private VisualStyleSet cashNeededStyle;

	[SerializeField]
	private List<TextMeshProUGUI> cashNeededText;

	[SerializeField]
	private VisualStyleSet boostersStyle;

	[SerializeField]
	private VisualStyleSet boostersCashNeededStyle;

	[SerializeField]
	private VisualStyleSet collectableGoalStyle;

	[SerializeField]
	private VisualStyleSet messageGoalStyleA;

	[SerializeField]
	private VisualStyleSet messageGoalStyleB;

	[SerializeField]
	private RankedBoostersContainer rankedBooster;

	public Action onHide;

	public Action<Match3GameParams> onStart;

	public Match3StagesDB.Stage stage;

	private ShowParams shopParams;

	public void Show(Match3StagesDB.Stage stage, DecorateRoomScreen screen, MainConfig config, Action onHide = null, Action<Match3GameParams> onStart = null)
	{
	}

	public void Show(ShowParams showParams)
	{
	}

	private void Init(ShowParams showParams)
	{
	}

	public void ButtonCallback_OnPlayButtonClicked()
	{
	}

	public void OnBoosterClicked(PreGameDialogBoosterPrefab.BoosterDefinition booster)
	{
	}

	public void ButtonCallback_Hide()
	{
	}

	private void OnEnable()
	{
	}
}
