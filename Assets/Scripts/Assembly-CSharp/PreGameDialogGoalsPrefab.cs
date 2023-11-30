using System;
using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class PreGameDialogGoalsPrefab : MonoBehaviour
{
	[Serializable]
	public class NamedSprite
	{
		public ChipType chipType;

		public GoalType goalType;

		public ItemColor itemColor;

		public bool useItemColor;

		public PreGameDialogGoalPrefabVisualConfig iconWithText;

		public bool IsMatching(GoalConfig config)
		{
			return false;
		}

		public void SetActive(bool flag)
		{
		}

		public void SetLabel(string text)
		{
		}
	}

	[SerializeField]
	private List<NamedSprite> namedSprites;

	[SerializeField]
	private List<RectTransform> widgetsToHide;

	[SerializeField]
	private PreGameDialogGoalPrefabVisualConfig genericIconWithText;

	public void Init(GoalConfig config, Match3StagesDB.Stage stage, MainConfig mainConfig)
	{
	}
}
