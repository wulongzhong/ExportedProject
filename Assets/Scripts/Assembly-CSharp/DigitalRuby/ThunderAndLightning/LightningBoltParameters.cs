using System;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	[Serializable]
	public sealed class LightningBoltParameters
	{
		private static int randomSeed;

		private static readonly List<LightningBoltParameters> cache;

		internal int generationWhereForksStop;

		internal int forkednessCalculated;

		internal LightningBoltQualitySetting quality;

		internal float delaySeconds;

		internal int maxLights;

		public static float Scale;

		public static readonly Dictionary<int, LightningQualityMaximum> QualityMaximums;

		public LightningGenerator Generator;

		public Vector3 Start;

		public Vector3 End;

		public Vector3 StartVariance;

		public Vector3 EndVariance;

		public Action<LightningCustomTransformStateInfo> CustomTransform;

		private int generations;

		public float LifeTime;

		public float Delay;

		public RangeOfFloats DelayRange;

		public float ChaosFactor;

		public float ChaosFactorForks;

		public float TrunkWidth;

		public float EndWidthMultiplier;

		public float Intensity;

		public float GlowIntensity;

		public float GlowWidthMultiplier;

		public float Forkedness;

		public int GenerationWhereForksStopSubtractor;

		public Color32 Color;

		private System.Random random;

		private System.Random currentRandom;

		private System.Random randomOverride;

		public float FadePercent;

		public float FadeInMultiplier;

		public float FadeFullyLitMultiplier;

		public float FadeOutMultiplier;

		private float growthMultiplier;

		public float ForkLengthMultiplier;

		public float ForkLengthVariance;

		public float ForkEndWidthMultiplier;

		public LightningLightParameters LightParameters;

		private List<Vector3> _003CPoints_003Ek__BackingField;

		public int SmoothingFactor;

		public int Generations
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public System.Random Random => null;

		public System.Random RandomOverride
		{
			set
			{
			}
		}

		public float GrowthMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public List<Vector3> Points
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		static LightningBoltParameters()
		{
		}

		public float ForkMultiplier()
		{
			return 0f;
		}

		public Vector3 ApplyVariance(Vector3 pos, Vector3 variance)
		{
			return default(Vector3);
		}

		public void Reset()
		{
		}

		public static LightningBoltParameters GetOrCreateParameters()
		{
			return null;
		}

		public static void ReturnParametersToCache(LightningBoltParameters p)
		{
		}
	}
}
