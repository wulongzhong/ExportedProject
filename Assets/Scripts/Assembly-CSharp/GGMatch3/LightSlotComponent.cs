using System;
using System.Collections.Generic;

namespace GGMatch3
{
	public class LightSlotComponent : SlotComponent
	{
		public class PermanentLight
		{
			private float _003CcurrentIntensity_003Ek__BackingField;

			public virtual float currentIntensity => 0f;

			public virtual float GetCurrentIntensity(LightSlotComponent component)
			{
				return 0f;
			}
		}

		private class IntensityChangeProcessor
		{
			public IntensityChange change;

			public bool isActive;

			public float timeActive;

			public float currentIntensity => 0f;

			public void Activate(IntensityChange change)
			{
			}
		}

		[Serializable]
		public class Settings
		{
			public float lightFadeoutSpeed;

			public float maxIntensity;

			public IntensityChange fadeOut;
		}

		private List<IntensityChangeProcessor> intensityChanges;

		private List<PermanentLight> permanentLights;

		private SlotLightBehaviour lightBehaviour;

		private Settings settings => null;

		public float maxIntensity => 0f;

		public void Init(SlotLightBehaviour lightBehaviour)
		{
		}

		public void AddIntensityChange(IntensityChange change)
		{
		}

		public void AddLight(PermanentLight light)
		{
		}

		public void RemoveLight(PermanentLight light)
		{
		}

		public void AddLight(float intensity)
		{
		}

		public void AddLightWithDuration(float intensity, float duration)
		{
		}

		public override void OnUpdate(float deltaTime)
		{
		}
	}
}
