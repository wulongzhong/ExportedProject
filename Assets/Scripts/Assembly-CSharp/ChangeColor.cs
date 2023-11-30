using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ChangeColor
{
	[Serializable]
	public class PresetColor
	{
		[SerializeField]
		public Color color;

		[SerializeField]
		public List<MaterialChangeByTag> changesByTag;

		public bool HasCustomizationForTag(string tag)
		{
			return false;
		}
	}

	[SerializeField]
	public string colorName;

	[SerializeField]
	public List<PresetColor> presetColors;

	public PresetColor GetPresetColor(int index)
	{
		return null;
	}

	public bool HasCustomizationForTag(string tag)
	{
		return false;
	}
}
