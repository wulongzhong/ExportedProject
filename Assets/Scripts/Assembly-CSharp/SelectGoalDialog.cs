using System;
using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class SelectGoalDialog : MonoBehaviour
{
	public struct InitParams
	{
		public LevelDefinition level;

		public GoalConfig goalConfig;

		public bool addGoal;

		public Action<SelectGoalDialog> onDone;
	}

	[SerializeField]
	private ComponentPool goalsPool;

	[SerializeField]
	private RectTransform container;

	[SerializeField]
	private GoalsPanelGoal bigGoal;

	private InitParams _003CinitParams_003Ek__BackingField;

	[NonSerialized]
	public GoalConfig selectedConfig;

	[NonSerialized]
	private List<GoalConfig> goalConfigs;

	public InitParams initParams
	{
		get
		{
			return default(InitParams);
		}
		protected set
		{
		}
	}

	public static SelectGoalDialog instance => null;

	private List<GoalConfig> GetAvailableGoalConfigs(LevelDefinition level)
	{
		return null;
	}

	private GoalConfig NewGoalConfig(ChipType chipType, ItemColor itemColor)
	{
		return null;
	}

	public void Show(InitParams initParams)
	{
	}

	private void Init()
	{
	}

	private void OnChange()
	{
	}

	private void Callback_OnSelectGoal(GoalsPanelGoal goal)
	{
	}

	public void ButtonCallback_OnBack()
	{
	}

	public void ButtonCallback_OnCollectAll()
	{
	}

	public void ButtonCallback_OnAddCollectCount()
	{
	}

	public void ButtonCallback_OnRemoveCollectCount()
	{
	}
}
