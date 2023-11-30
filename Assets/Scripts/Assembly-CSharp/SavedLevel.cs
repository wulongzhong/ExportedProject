using System;
using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

[Serializable]
public class SavedLevel
{
	[SerializeField]
	public LevelDefinition level;

	[SerializeField]
	public List<LevelDefinition> undoList;

	[SerializeField]
	public List<LevelDefinition> redoList;

	public static string DirectoryPath => null;

	public void Save(string path)
	{
	}

	public static SavedLevel Load(string path)
	{
		return null;
	}

	public static bool IsExtensionCorrect(string fullPath)
	{
		return false;
	}

	public static string NameFromFullPath(string fullPath)
	{
		return null;
	}

	public static string FullPath(string name)
	{
		return null;
	}
}
