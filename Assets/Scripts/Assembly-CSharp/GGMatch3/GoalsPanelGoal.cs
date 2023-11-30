using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GGMatch3
{
	public class GoalsPanelGoal : MonoBehaviour
	{
		[Serializable]
		public class ChipDescriptor
		{
			public ItemColor color;

			public RectTransform container;
		}

		[Serializable]
		public class ChipTypeDescriptor
		{
			public ChipType chipType;

			public RectTransform container;
		}

		[SerializeField]
		private Image genericChipImage;

		[SerializeField]
		private List<ChipDescriptor> chips;

		[SerializeField]
		private List<ChipTypeDescriptor> chipsTypes;

		[SerializeField]
		private List<RectTransform> widgetsToHide;

		[SerializeField]
		private TextMeshProUGUI collectedCount;

		[SerializeField]
		private RectTransform completeTickMark;

		[NonSerialized]
		public MultiLevelGoals.Goal goal;

		[NonSerialized]
		public GoalConfig goalConfig;

		[NonSerialized]
		private Action<GoalsPanelGoal> onDelete;

		[NonSerialized]
		private Action<GoalsPanelGoal> onSelect;

		public void Init(MultiLevelGoals.Goal goal)
		{
		}

		public void Init(GoalConfig goal, Action<GoalsPanelGoal> onSelect, Action<GoalsPanelGoal> onDelete)
		{
		}

		public void UpdateCollectedCount()
		{
		}

		public void buttonCallback_OnSelect()
		{
		}

		public void ButtonCallback_OnDelete()
		{
		}
	}
}
