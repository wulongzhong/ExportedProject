using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public abstract class LightningSpellScript : MonoBehaviour
	{
		private sealed class _003CStopAfterSecondsCoRoutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LightningSpellScript _003C_003E4__this;

			public float seconds;

			private int _003Ctoken_003E5__2;

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
			public _003CStopAfterSecondsCoRoutine_003Ed__19(int _003C_003E1__state)
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

		public GameObject SpellStart;

		public GameObject SpellEnd;

		public Vector3 Direction;

		public float MaxDistance;

		public bool CollisionIsExplosion;

		public float CollisionRadius;

		public float CollisionForce;

		public ForceMode CollisionForceMode;

		public ParticleSystem CollisionParticleSystem;

		public LayerMask CollisionMask;

		public AudioSource CollisionAudioSource;

		public AudioClip[] CollisionAudioClips;

		public RangeOfFloats CollisionVolumeRange;

		public float Duration;

		public float Cooldown;

		public AudioSource EmissionSound;

		public ParticleSystem EmissionParticleSystem;

		public Light EmissionLight;

		private int stopToken;

		private float _003CDurationTimer_003Ek__BackingField;

		private float _003CCooldownTimer_003Ek__BackingField;

		private bool _003CCasting_003Ek__BackingField;

		protected float DurationTimer
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		protected float CooldownTimer
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		public bool Casting
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public bool CanCastSpell => false;

		private IEnumerator StopAfterSecondsCoRoutine(float seconds)
		{
			return null;
		}

		protected void ApplyCollisionForce(Vector3 point)
		{
		}

		protected void PlayCollisionSound(Vector3 pos)
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected abstract void OnCastSpell();

		protected abstract void OnStopSpell();

		protected virtual void OnActivated()
		{
		}

		protected virtual void OnDeactivated()
		{
		}

		public bool CastSpell()
		{
			return false;
		}

		public void StopSpell()
		{
		}

		public void ActivateSpell()
		{
		}

		public void DeactivateSpell()
		{
		}

		public void StopAfterSeconds(float seconds)
		{
		}

		public static GameObject FindChildRecursively(Transform t, string name)
		{
			return null;
		}
	}
}
