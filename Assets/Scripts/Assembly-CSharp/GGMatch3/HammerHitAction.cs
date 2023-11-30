using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace GGMatch3
{
	public class HammerHitAction : BoardAction
	{
		public struct InitArguments
		{
			public Match3Game game;

			public PowerupPlacementHandler.PlacementCompleteArguments completeArguments;
		}

		private sealed class _003CDoAnimation_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HammerHitAction _003C_003E4__this;

			private Match3Game _003Cgame_003E5__2;

			private HammerAnimationBehaviour _003ChammerBehaviour_003E5__3;

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
			public _003CDoAnimation_003Ed__4(int _003C_003E1__state)
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

		private InitArguments initArguments;

		private IEnumerator animationAction;

		public void Init(InitArguments initArguments)
		{
		}

		private IEnumerator DoAnimation()
		{
			return null;
		}

		private void ActivatePowerup()
		{
		}

		public override void OnUpdate(float deltaTime)
		{
		}
	}
}
