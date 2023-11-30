using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace GGMatch3
{
	public class ComboSeekingMissileAction : BoardAction
	{
		[Serializable]
		public class Settings
		{
			public float delay;
		}

		public class Parameters
		{
			public int rocketsCount;

			public Match3Game game;

			public Slot startSlot;

			public bool isHavingCarpet;
		}

		private sealed class _003CDoShootRockets_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ComboSeekingMissileAction _003C_003E4__this;

			private int _003Ci_003E5__2;

			private SeekingMissileAction.Parameters _003CseekingMissileParameters_003E5__3;

			private float _003Cdelay_003E5__4;

			private float _003Ctime_003E5__5;

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
			public _003CDoShootRockets_003Ed__7(int _003C_003E1__state)
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

		private Parameters parameters;

		private Lock sourceLock;

		private IEnumerator shootRocketsCoroutine;

		public void Init(Parameters parameters)
		{
		}

		public override void OnUpdate(float deltaTime)
		{
		}

		public IEnumerator DoShootRockets()
		{
			return null;
		}
	}
}
