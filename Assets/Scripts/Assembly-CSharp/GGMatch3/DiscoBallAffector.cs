using System;
using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	public class DiscoBallAffector : PlayerInput.AffectorBase
	{
		[Serializable]
		public class Settings
		{
			public float displacePull;

			public float angleSpeed;

			public float phaseOffsetMult;

			public float amplitude;

			public float originScale;

			public float lightIntensity;

			public FloatRange lightIntensityRange;

			public float timeToFullIntensity;

			public AnimationCurve intensityCurve;

			public bool lockLine;

			public float durationToGetClose;

			public float maxScale;

			public float normalizedClosePosition;

			public float outDuration;

			public float minDuration;

			public float delayTime;

			public float activationDelay;
		}

		public static void RemoveFromGame(List<LightingBolt> bolts)
		{
		}
	}
}
