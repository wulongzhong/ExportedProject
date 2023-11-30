using System;
using UnityEngine;

namespace EVP
{
	public class VehicleAudio : MonoBehaviour
	{
		[Serializable]
		public class Engine
		{
			public AudioSource audioSource;

			public float idleRpm;

			public float idlePitch;

			public float idleVolume;

			public float maxRpm;

			public float maxPitch;

			public float maxVolume;

			public float throttleRpmBoost;

			public float throttleVolumeBoost;

			public float wheelsToEngineRatio;

			public int gears;

			public float gearDownRpm;

			public float gearUpRpm;

			public float gearUpRpmRate;

			public float gearDownRpmRate;

			public float volumeChangeRateUp;

			public float volumeChangeRateDown;
		}

		[Serializable]
		public class EngineExtras
		{
			public AudioSource turboAudioSource;

			public float turboMinRpm;

			public float turboMaxRpm;

			public float turboMinPitch;

			public float turboMaxPitch;

			public float turboMaxVolume;

			public bool turboRequiresThrottle;

			public AudioClip turboDumpClip;

			public float turboDumpMinRpm;

			public float turboDumpMinInterval;

			public float turboDumpMinThrottleTime;

			public float turboDumpVolume;

			public AudioSource transmissionAudioSource;

			public float transmissionMaxRatio;

			public float transmissionMinPitch;

			public float transmissionMaxPitch;

			public float transmissionMinVolume;

			public float transmissionMaxVolume;
		}

		[Serializable]
		public class Wheels
		{
			public AudioSource skidAudioSource;

			public float skidMinSlip;

			public float skidMaxSlip;

			public float skidMinPitch;

			public float skidMaxPitch;

			public float skidMaxVolume;

			public AudioSource offroadAudioSource;

			public float offroadMinSpeed;

			public float offroadMaxSpeed;

			public float offroadMinPitch;

			public float offroadMaxPitch;

			public float offroadMinVolume;

			public float offroadMaxVolume;

			public AudioClip bumpAudioClip;

			public float bumpMinForceDelta;

			public float bumpMaxForceDelta;

			public float bumpMinVolume;

			public float bumpMaxVolume;
		}

		[Serializable]
		public class Impacts
		{
			public AudioClip hardImpactAudioClip;

			public AudioClip softImpactAudioClip;

			public float minSpeed;

			public float maxSpeed;

			public float minPitch;

			public float maxPitch;

			public float randomPitch;

			public float minVolume;

			public float maxVolume;

			public float randomVolume;
		}

		[Serializable]
		public class Drags
		{
			public AudioSource hardDragAudioSource;

			public AudioSource softDragAudioSource;

			public float minSpeed;

			public float maxSpeed;

			public float minPitch;

			public float maxPitch;

			public float minVolume;

			public float maxVolume;

			public AudioClip scratchAudioClip;

			public float scratchRandomThreshold;

			public float scratchMinSpeed;

			public float scratchMinInterval;

			public float scratchMinPitch;

			public float scratchMaxPitch;

			public float scratchMinVolume;

			public float scratchMaxVolume;
		}

		[Serializable]
		public class Wind
		{
			public AudioSource windAudioSource;

			public float minSpeed;

			public float maxSpeed;

			public float minPitch;

			public float maxPitch;

			public float maxVolume;
		}

		public AudioSource audioClipTemplate;

		public Engine engine;

		public EngineExtras engineExtras;

		public Wheels wheels;

		public Impacts impacts;

		public Drags drags;

		public Wind wind;

		[NonSerialized]
		public float skidRatioChangeRate;

		[NonSerialized]
		public float offroadSpeedChangeRate;

		[NonSerialized]
		public float offroadCutoutSpeed;

		[NonSerialized]
		public float dragCutoutSpeed;

		[NonSerialized]
		public float turboRatioChangeRate;

		[NonSerialized]
		public float wheelsRpmChangeRateLimit;

		private VehicleController m_vehicle;

		private float m_engineRpm;

		private float m_engineThrottleRpm;

		private float m_engineRpmDamp;

		private float m_wheelsRpm;

		private int m_gear;

		private int m_lastGear;

		private float m_skidRatio;

		private float m_offroadSpeed;

		private float m_lastScratchTime;

		private float m_turboRatio;

		private float m_lastTurboDumpTime;

		private float m_lastThrottleInput;

		private float m_lastThrottlePressedTime;

		private WheelAudioData[] m_audioData;

		public int simulatedGear => 0;

		public float simulatedEngineRpm => 0f;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void InitializeAudioData()
		{
		}

		private void DoEngineAudio()
		{
		}

		private void DoEngineExtraAudio()
		{
		}

		private void DoTireAudio()
		{
		}

		private void DoImpactAudio()
		{
		}

		private void DoBodyDragAudio()
		{
		}

		private void DoWheelBumpAudio()
		{
		}

		private void DoWindAudio()
		{
		}

		private void StopAllAudioSources()
		{
		}

		private void StopAudio(AudioSource audio)
		{
		}

		private void ProcessContinuousAudio(AudioSource audio, float ratio, float minPitch, float maxPitch, float minVolume, float maxVolume)
		{
		}

		private void ProcessContinuousAudioPitch(AudioSource audio, float ratio, float minPitch, float maxPitch)
		{
		}

		private void ProcessVolume(AudioSource audio, float volume, float changeRateUp, float changeRateDown)
		{
		}

		private void ProcessSpeedBasedAudio(AudioSource audio, float speed, float cutoutSpeed, float minSpeed, float maxSpeed, float cutoutPitch, float minPitch, float maxPitch, float minVolume, float maxVolume)
		{
		}

		private void ProcessWheelBumpAudio(float suspensionForceDelta, Vector3 position)
		{
		}

		private void PlayOneTime(AudioClip clip, Vector3 position, float volume)
		{
		}

		private void PlayOneTime(AudioClip clip, Vector3 position, float volume, float pitch)
		{
		}

		private void VerifyAudioSources()
		{
		}

		private void VerifyAudioSource(ref AudioSource audioSource)
		{
		}
	}
}
