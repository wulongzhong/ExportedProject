using System;
using UnityEngine;

[Serializable]
public class MaterialChangeByTag
{
	public enum Change
	{
		ReplaceMaterial = 0,
		ReplaceColor = 1,
		ReplaceMaterialKeepAO = 2
	}

	[SerializeField]
	public string tagName;

	[SerializeField]
	public Change change;

	[SerializeField]
	public Material material;

	[SerializeField]
	public string colorPropertyName;
}
