using System;
using UnityEngine;

namespace GGMatch3
{
	public class PlayerInputCrossAffector : PlayerInput.AffectorBase
	{
		[Serializable]
		public class Settings
		{
			public float maxDistance;

			public FloatRange displaceRange;

			public AnimationCurve displaceCurve;

			public float affectedOrtho;

			public float displacePull;

			public float angleSpeed;

			public float phaseOffsetMult;

			public float amplitude;

			public float originScale;

			public float lightIntensity;

			public float distanceDelay;

			public FloatRange lightIntensityRange;

			public float maxLightDistance;

			public float timeToFullIntensity;

			public AnimationCurve intensityCurve;

			public bool lockLine;

			public FloatRange scaleRange;

			public float orthoScaleInfluence;
		}
	}
}
