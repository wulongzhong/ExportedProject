using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace GGMatch3
{
	public class CrossExplosionAction : BoardAction
	{
		[Serializable]
		public class Settings
		{
			public float delay;

			public float lightIntensity;

			public FloatRange lightIntensityRange;

			public float maxLightDistance;

			public float lockReleaseDelay;

			public float shockWaveOffset;
		}

		public class Circle
		{
			public float radius;

			public List<Slot> slots;

			public void Add(Slot slot)
			{
			}

			public void AddLock(Lock slotLock)
			{
			}
		}

		public class Parameters
		{
			public int radius;

			public IntVector2 startPosition;

			public Match3Game game;

			public Chip bombChip;

			public bool isHavingCarpet;

			public bool explode;
		}

		private sealed class _003CDoExplosion_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CrossExplosionAction _003C_003E4__this;

			private Lock _003CslotLock_003E5__2;

			private SlotDestroyParams _003CbombParams_003E5__3;

			private Settings _003CexplosionSettings_003E5__4;

			private float _003Ctime_003E5__5;

			private int _003Ci_003E5__6;

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
			public _003CDoExplosion_003Ed__8(int _003C_003E1__state)
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

		private Lock globalSlotLock;

		private List<Slot> allAffectedSlots;

		private Parameters parameters;

		public List<Circle> circles;

		private bool isHavingCarpet;

		private IEnumerator explosionCoroutine;

		public void Init(Parameters parameters)
		{
		}

		public IEnumerator DoExplosion()
		{
			return null;
		}

		private void AffectOuterCircleWithExplosion(IntVector2 center, int radius, float shockWaveOffset)
		{
		}

		public override void OnUpdate(float deltaTime)
		{
		}

		public List<Slot> GetAffectedSlots()
		{
			return null;
		}
	}
}
