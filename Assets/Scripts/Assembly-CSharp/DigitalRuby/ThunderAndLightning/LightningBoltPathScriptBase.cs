using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public abstract class LightningBoltPathScriptBase : LightningBoltPrefabScriptBase
	{
		public List<GameObject> LightningPath;

		private readonly List<GameObject> currentPathObjects;

		protected List<GameObject> GetCurrentPathObjects()
		{
			return null;
		}

		protected override LightningBoltParameters OnCreateParameters()
		{
			return null;
		}
	}
}
