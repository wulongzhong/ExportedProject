using System;
using GGMatch3;

public class PowerCrossAffector : PlayerInput.AffectorBase
{
	[Serializable]
	public class Settings
	{
		public float minAffectorDuration;

		public float outDuration;

		public float angleSpeed;

		public float phaseOffsetMult;

		public float amplitude;
	}
}
