using System;
using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	[Serializable]
	public class LevelDB : ScriptableObject
	{
		[SerializeField]
		private string _currentLevelName;

		public List<LevelDefinition> levels;

		public string currentLevelName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int currentLevelIndex => 0;

		public int GetLevelIndex(string levelName)
		{
			return 0;
		}

		public LevelDefinition Get(string levelName)
		{
			return null;
		}
	}
}
