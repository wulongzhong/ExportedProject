using System;
using System.Collections.Generic;
using GGMatch3;
using UnityEngine;
using UnityEngine.UI;

public class LevelEditorGeneratorSetupChip : MonoBehaviour
{
	[Serializable]
	public class ChipDescriptor
	{
		public ItemColor color;

		public RectTransform container;
	}

	[SerializeField]
	private List<ChipDescriptor> chips;

	[SerializeField]
	private RectTransform chipsContainer;

	[SerializeField]
	private RectTransform emptyContainer;

	[SerializeField]
	private Image colorCodeImage;

	public void Init(GeneratorSetup.GeneratorChipSetup chip, GeneratorSetup setup)
	{
	}

	public void SetColorCode(GeneratorSetup setup)
	{
	}
}
