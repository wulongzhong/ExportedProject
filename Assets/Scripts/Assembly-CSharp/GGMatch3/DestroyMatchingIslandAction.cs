using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace GGMatch3
{
	public class DestroyMatchingIslandAction : BoardAction
	{
		public struct InitArguments
		{
			public Match3Game game;

			public List<Slot> allSlots;

			public SlotDestroyParams slotDestroyParams;

			public Slot slotWherePowerupIsCreated;

			public ChipType powerupToCreate;

			public BoltCollection boltCollection;

			public int matchComboIndex;
		}

		private sealed class _003CDoAnimate_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DestroyMatchingIslandAction _003C_003E4__this;

			private MatchChipAffector _003CchipAffector_003E5__2;

			private float _003Ctime_003E5__3;

			private float _003Cduration_003E5__4;

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
			public _003CDoAnimate_003Ed__6(int _003C_003E1__state)
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

		private Lock globalLock;

		private InitArguments initArguments;

		private float deltaTime;

		private IEnumerator enumerator;

		public void Init(InitArguments initArguments)
		{
		}

		private IEnumerator DoAnimate()
		{
			return null;
		}

		public override void OnUpdate(float deltaTime)
		{
		}
	}
}
