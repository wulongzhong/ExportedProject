using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace GGMatch3
{
	public class DiscoBallDestroyInstantAction : BoardAction
	{
		private sealed class _003CDestroyAnimation_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DiscoBallDestroyInstantAction _003C_003E4__this;

			private List<Slot> _003CaffectedSlots_003E5__2;

			private DiscoChipAffector _003CchipAffector_003E5__3;

			private float _003Ctime_003E5__4;

			private float _003Cduration_003E5__5;

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
			public _003CDestroyAnimation_003Ed__8(int _003C_003E1__state)
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

		private DiscoBallDestroyAction.DiscoParams discoParams;

		private Lock slotLock;

		private Lock stopGeneratorsLock;

		private IEnumerator destroyAnimation;

		private Chip originChip;

		private Slot otherBombSlot;

		private float deltaTime;

		public void Init(DiscoBallDestroyAction.DiscoParams discoParams)
		{
		}

		private IEnumerator DestroyAnimation()
		{
			return null;
		}

		private void AffectOuterCircleWithExplosion(IntVector2 center, int radius, float shockWaveOffset)
		{
		}

		public override void OnUpdate(float deltaTime)
		{
		}
	}
}
