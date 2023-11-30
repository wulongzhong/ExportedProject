using System;
using UnityEngine;

namespace GGMatch3
{
	public class SwipeAffector : PlayerInput.AffectorBase
	{
		[Serializable]
		public class Settings
		{
			public float upScale;

			public float createPowerupScale;

			public float pullOffset;

			public bool offsetTillMoveEnd;

			public float moveDuration;

			public AnimationCurve moveCurve;

			public float brightness;

			public float angleSpeed;

			public float phaseOffsetMult;

			public float amplitude;

			public float minAffectorDuration;

			public bool ignoreBoltsWithoutPowerup;

			public bool hasMaxAffectorDuration;

			public float maxMaxAffectorDuration;

			public float minAutoMatchDuration;

			public float minAffectorDurationPowerup;

			public float minAffectorDurationMix;

			public float lightIntensity;

			public float shockWaveOffset;

			public bool useParticles;

			public bool autoMatchesProduceLighting;

			public float activeGoalUpScale;

			public bool useAutoMatchDuration;

			public float autoMatchDuration;
		}

		private static IntVector2[] directions;
	}
}
