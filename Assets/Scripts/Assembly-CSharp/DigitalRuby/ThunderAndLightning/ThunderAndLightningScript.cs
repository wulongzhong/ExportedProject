using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class ThunderAndLightningScript : MonoBehaviour
	{
		private class LightningBoltHandler
		{
			private sealed class _003CProcessLightning_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public LightningBoltHandler _003C_003E4__this;

				public bool intense;

				public Vector3? _start;

				public Vector3? _end;

				public bool visible;

				private AudioClip[] _003Csounds_003E5__2;

				private float _003Cintensity_003E5__3;

				private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
				{
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

                object IEnumerator<object>.Current => throw new NotImplementedException();

                object IEnumerator.Current => throw new NotImplementedException();

                [DebuggerHidden]
				public _003CProcessLightning_003Ed__9(int _003C_003E1__state)
				{
				}

				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				private bool MoveNext()
				{
					return false;
				}

				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

                bool IEnumerator.MoveNext()
                {
                    throw new NotImplementedException();
                }

                void IEnumerator.Reset()
                {
                    throw new NotImplementedException();
                }

                void IDisposable.Dispose()
                {
                    throw new NotImplementedException();
                }
            }

			private float _003CVolumeMultiplier_003Ek__BackingField;

			private ThunderAndLightningScript script;

			private readonly System.Random random;

			public float VolumeMultiplier
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public LightningBoltHandler(ThunderAndLightningScript script)
			{
			}

			private void UpdateLighting()
			{
			}

			private void CalculateNextLightningTime()
			{
			}

			public IEnumerator ProcessLightning(Vector3? _start, Vector3? _end, bool intense, bool visible)
			{
				return null;
			}

			private void Strike(Vector3? _start, Vector3? _end, bool intense, float intensity, Camera camera, Camera visibleInCamera)
			{
			}

			private void CheckForLightning()
			{
			}

			public void Update()
			{
			}
		}

		public LightningBoltPrefabScript LightningBoltScript;

		public Camera Camera;

		public RangeOfFloats LightningIntervalTimeRange;

		public float LightningIntenseProbability;

		public AudioClip[] ThunderSoundsNormal;

		public AudioClip[] ThunderSoundsIntense;

		public bool LightningAlwaysVisible;

		public float CloudLightningChance;

		public bool ModifySkyboxExposure;

		public float BaseLightRange;

		public float LightningYStart;

		public float VolumeMultiplier;

		private float skyboxExposureOriginal;

		private float skyboxExposureStorm;

		private float nextLightningTime;

		private bool lightningInProgress;

		private AudioSource audioSourceThunder;

		private LightningBoltHandler lightningBoltHandler;

		private Material skyboxMaterial;

		private AudioClip lastThunderSound;

		private bool _003CEnableLightning_003Ek__BackingField;

		public float SkyboxExposureOriginal => 0f;

		public bool EnableLightning
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void CallNormalLightning()
		{
		}

		public void CallNormalLightning(Vector3? start, Vector3? end)
		{
		}

		public void CallIntenseLightning()
		{
		}

		public void CallIntenseLightning(Vector3? start, Vector3? end)
		{
		}
	}
}
