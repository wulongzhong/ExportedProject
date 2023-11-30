using System;
using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class IceBehaviour : MonoBehaviour
{
	[Serializable]
	public class GraphicsDefinition
	{
		[Serializable]
		public class TypeDefinition
		{
			public ChipType chipType;

			public ItemColor itemColor;

			public bool ContainsType(ChipType chipType, ItemColor itemColor)
			{
				return false;
			}
		}

		public List<TypeDefinition> types;

		public Transform container;

		public List<Transform> levels;

		public bool isChipActive;

		public bool isForAnyChip;

		public bool ContainsType(ChipType chipType, ItemColor itemColor)
		{
			return false;
		}

		public void ShowLevel(int level)
		{
		}

		public void Hide()
		{
		}
	}

	private ChipType shownType;

	private ItemColor shownColor;

	private int shownLevel;

	[SerializeField]
	private List<GraphicsDefinition> graphics;

	public void DoOnDestroy(Chip chip)
	{
	}

	public void TryInitIfDifferent(Chip chip, int level)
	{
	}

	public void Init(Chip chip, int level)
	{
	}

	private GraphicsDefinition DefinitionForChip(Chip chip)
	{
		return null;
	}
}
