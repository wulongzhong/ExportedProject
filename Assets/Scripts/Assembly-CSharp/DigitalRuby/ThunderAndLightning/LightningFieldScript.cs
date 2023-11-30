using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningFieldScript : LightningBoltPrefabScriptBase
	{
		public float MinimumLength;

		private float minimumLengthSquared;

		public Bounds FieldBounds;

		public Light Light;

		private Vector3 RandomPointInBounds()
		{
			return default(Vector3);
		}

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}
	}
}
