using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace GGMatch3
{
	public class GoalsPanel : MonoBehaviour
	{
		[SerializeField]
		private List<Transform> widgetsToHide;

		[SerializeField]
		private VisualStyleSet goalsDisplayStyle;

		[SerializeField]
		private VisualStyleSet coinsDisplayStyle;

		[SerializeField]
		private ComponentPool goalsPool;

		[SerializeField]
		public TextMeshProUGUI movesCountLabel;

		[SerializeField]
		private RectTransform goalsContainer;

		[SerializeField]
		public RectTransform coinsTransform;

		[SerializeField]
		private TextMeshProUGUI coinsCountLabel;

		private List<GoalsPanelGoal> uiGoalsList;

		private GameScreen.StageState stageState;

		private VisibilityHelper visibilityHelper;

		[SerializeField]
		private TextMeshProUGUI pointsLabel;

		private int currentDisplayedScore;

		private int desiredScore;

		public void Init(GameScreen.StageState stageState)
		{
		}

		public void UpdateScore()
		{
		}

		public void ShowCoins()
		{
		}

		public void SetCoinsCount(long coinsCount)
		{
		}

		public GoalsPanelGoal GetGoal(Match3Goals.GoalBase goal)
		{
			return null;
		}

		public void UpdateMovesCount()
		{
		}

		private void Update()
		{
		}
	}
}
