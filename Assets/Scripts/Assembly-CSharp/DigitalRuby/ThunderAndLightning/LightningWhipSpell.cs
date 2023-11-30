using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningWhipSpell : LightningSpellScript
	{
		private sealed class _003CWhipForward_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LightningWhipSpell _003C_003E4__this;

			private Vector3 _003CwhipPositionForwards_003E5__2;

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
			public _003CWhipForward_003Ed__7(int _003C_003E1__state)
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

		public GameObject AttachTo;

		public GameObject RotateWith;

		public GameObject WhipHandle;

		public GameObject WhipStart;

		public GameObject WhipSpring;

		public AudioSource WhipCrackAudioSource;

		public Action<Vector3> CollisionCallback;

		private IEnumerator WhipForward()
		{
			return null;
		}

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		protected override void OnCastSpell()
		{
		}

		protected override void OnStopSpell()
		{
		}

		protected override void OnActivated()
		{
		}

		protected override void OnDeactivated()
		{
		}
	}
}
