using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace GGMatch3
{
	public class ExplosionAction : BoardAction
	{
		public struct ExplosionSettings
		{
			public Chip bombChip;

			public IntVector2 position;

			public int radius;

			public bool isHavingCarpet;

			public bool isUsingBombAreaOfEffect;
		}

		[Serializable]
		public class Settings
		{
			public float delay;

			public float lightIntensity;

			public FloatRange lightIntensityRange;

			public float lightDuration;

			public float maxLightDistance;

			public float shockWaveOffset;

			public float shockWaveOffsetR1;

			public bool useSecondaryDelay;

			public float secondaryDelay;

			public bool useCameraShake;
		}

		public class CircleList
		{
			public int radius;

			public List<Slot> slotList;

			public void AddLock(Lock slotLock)
			{
			}
		}

		private sealed class _003CDoExplosion_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ExplosionAction _003C_003E4__this;

			private Settings _003CexplosionSettings_003E5__2;

			private float _003Cdelay_003E5__3;

			private Lock _003CslotLock_003E5__4;

			private SlotDestroyParams _003CbombParams_003E5__5;

			private int _003Ci_003E5__6;

			private float _003Ctime_003E5__7;

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
			public _003CDoExplosion_003Ed__12(int _003C_003E1__state)
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

		protected ExplosionSettings settings;

		protected Match3Game game;

		private IEnumerator explosionEnumerator;

		private Lock globalSlotLock;

		private List<CircleList> circles;

		private List<Slot> allAffectedSlots;

		private bool isHavingCarpet;

		public void Init(Match3Game game, ExplosionSettings settings)
		{
		}

		public override void OnStart(ActionManager manager)
		{
		}

		private IEnumerator DoExplosion()
		{
			return null;
		}

		public override void OnUpdate(float deltaTime)
		{
		}

		private void AffectOuterCircleWithExplosion(IntVector2 center, int radius, float shockWaveOffset)
		{
		}
	}
}
