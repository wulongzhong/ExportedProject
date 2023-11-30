using System;
using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class FlyingSaucerBehaviour : MonoBehaviour
{
	[Serializable]
	public class VisualStyle
	{
		[SerializeField]
		private ChipType chipType;

		[SerializeField]
		private ItemColor itemColor;

		[SerializeField]
		private List<Transform> visualItems;

		public bool IsApplicable(ChipType chipType, ItemColor itemColor)
		{
			return false;
		}

		public void SetActive(bool active)
		{
		}
	}

	[SerializeField]
	private SpriteRenderer iconSprite;

	[SerializeField]
	private List<VisualStyle> visualStyles;

	public void Init(ChipType chipType, ItemColor itemColor)
	{
	}

	public void RemoveFromGame()
	{
	}
}
