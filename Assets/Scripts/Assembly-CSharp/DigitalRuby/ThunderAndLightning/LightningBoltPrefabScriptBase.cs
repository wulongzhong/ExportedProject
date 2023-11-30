using System;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public abstract class LightningBoltPrefabScriptBase : LightningBoltScript
	{
		private readonly List<LightningBoltParameters> batchParameters;

		private readonly System.Random random;

		public RangeOfFloats IntervalRange;

		public RangeOfIntegers CountRange;

		public float CountProbabilityModifier;

		public RangeOfFloats DelayRange;

		public RangeOfFloats DurationRange;

		public RangeOfFloats TrunkWidthRange;

		public float LifeTime;

		public int Generations;

		public float ChaosFactor;

		public float ChaosFactorForks;

		public float Intensity;

		public float GlowIntensity;

		public float GlowWidthMultiplier;

		public float FadePercent;

		public float FadeInMultiplier;

		public float FadeFullyLitMultiplier;

		public float FadeOutMultiplier;

		public float GrowthMultiplier;

		public float EndWidthMultiplier;

		public float Forkedness;

		public float ForkLengthMultiplier;

		public float ForkLengthVariance;

		public float ForkEndWidthMultiplier;

		public LightningLightParameters LightParameters;

		public int MaximumLightsPerBatch;

		public bool ManualMode;

		public float AutomaticModeSeconds;

		public LightningCustomTransformDelegate CustomTransformHandler;

		private System.Random _003CRandomOverride_003Ek__BackingField;

		private float nextLightningTimestamp;

		private float lifeTimeRemaining;

		public System.Random RandomOverride
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void CalculateNextLightningTimestamp(float offset)
		{
		}

		private void CustomTransform(LightningCustomTransformStateInfo state)
		{
		}

		private void CallLightning()
		{
		}

		private void CallLightning(Vector3? start, Vector3? end)
		{
		}

		protected void CreateLightningBoltsNow()
		{
		}

		protected override void PopulateParameters(LightningBoltParameters p)
		{
		}

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		public override void CreateLightningBolt(LightningBoltParameters p)
		{
		}

		public void Trigger()
		{
		}

		public void Trigger(float seconds)
		{
		}

		public void Trigger(Vector3? start, Vector3? end)
		{
		}
	}
}
