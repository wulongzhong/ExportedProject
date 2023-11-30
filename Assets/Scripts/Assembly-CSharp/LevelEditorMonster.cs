using System;
using System.Collections.Generic;
using GGMatch3;
using UnityEngine;
using UnityEngine.UI;

public class LevelEditorMonster : MonoBehaviour
{
	[Serializable]
	public class ElementDesc
	{
		public IntVector2 size;

		public Image image;
	}

	[SerializeField]
	private List<ElementDesc> elements;

	public void Init(LevelEditorVisualizer viz, LevelDefinition level, LevelDefinition.MonsterElement monsterElement)
	{
	}
}
