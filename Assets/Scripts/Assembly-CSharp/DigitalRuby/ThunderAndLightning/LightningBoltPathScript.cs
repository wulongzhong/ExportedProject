using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBoltPathScript : LightningBoltPathScriptBase
	{
		public float Speed;

		public RangeOfFloats SpeedIntervalRange;

		public bool Repeat;

		private float nextInterval;

		private int nextIndex;

		private Vector3? lastPoint;

		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}

		public void Reset()
		{
		}
	}
}
