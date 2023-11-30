using System;
using GGMatch3;
using TMPro;
using UnityEngine;

public class LevelEditorGoalsPanel : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI movesCountLabel;

	[SerializeField]
	private ComponentPool goalsPool;

	[NonSerialized]
	private InGameLevelEditorScreen screen;

	public void Init(InGameLevelEditorScreen screen)
	{
	}

	private void Callback_OnSelectGoal(GoalsPanelGoal uiGoal)
	{
	}

	private void Callback_OnGoalChanged(SelectGoalDialog dialog)
	{
	}

	private void Callback_OnDeleteGoal(GoalsPanelGoal uiGoal)
	{
	}

	public void ButtonCallback_MoreMoves()
	{
	}

	public void ButtonCallback_LessMoves()
	{
	}

	public void ButtonCallback_AddGoal()
	{
	}
}
