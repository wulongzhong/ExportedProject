using System;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	[Serializable]
	public class LightningLightParameters
	{
		public LightRenderMode RenderMode;

		public Color LightColor;

		public float LightPercent;

		public float LightShadowPercent;

		public float LightIntensity;

		public float BounceIntensity;

		public float ShadowStrength;

		public float ShadowBias;

		public float ShadowNormalBias;

		public float LightRange;

		public LayerMask CullingMask;

		public float OrthographicOffset;

		public float FadeInMultiplier;

		public float FadeFullyLitMultiplier;

		public float FadeOutMultiplier;

		public bool HasLight => false;
	}
}
