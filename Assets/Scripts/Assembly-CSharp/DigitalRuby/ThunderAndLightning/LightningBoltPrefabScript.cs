using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBoltPrefabScript : LightningBoltPrefabScriptBase
	{
		public GameObject Source;

		public GameObject Destination;

		public Vector3 StartVariance;

		public Vector3 EndVariance;

		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}
	}
}
