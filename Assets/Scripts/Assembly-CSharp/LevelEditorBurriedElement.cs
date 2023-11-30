using System;
using System.Collections.Generic;
using GGMatch3;
using UnityEngine;
using UnityEngine.UI;

public class LevelEditorBurriedElement : MonoBehaviour
{
	[Serializable]
	public class BurriedElementDesc
	{
		public IntVector2 size;

		public Image image;
	}

	[SerializeField]
	private List<BurriedElementDesc> elements;

	[SerializeField]
	private RectTransform rotationRect;

	public void Init(LevelEditorVisualizer viz, LevelDefinition level, LevelDefinition.BurriedElement burriedElement)
	{
	}

	public void Init(InGameLevelEditorScreen viz, LevelDefinition level, LevelDefinition.BurriedElement burriedElement)
	{
	}
}
