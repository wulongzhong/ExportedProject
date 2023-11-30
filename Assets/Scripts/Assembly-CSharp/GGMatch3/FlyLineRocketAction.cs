using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace GGMatch3
{
	public class FlyLineRocketAction : BoardAction
	{
		public struct Params
		{
			public Chip bombChip;

			public Match3Game game;

			public IntVector2 position;

			public ChipType rocketType;

			public bool prelock;

			public bool canUseScale;

			public bool isHavingCarpet;

			public bool isInstant;

			public SwapParams swapParams;

			public Match3Game.InputAffectorExport affectorExport => null;
		}

		private sealed class _003CDoFly_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FlyLineRocketAction _003C_003E4__this;

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
			public _003CDoFly_003Ed__5(int _003C_003E1__state)
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

		private List<FlyRocketPieceAction> pieceActions;

		private Params flyParams;

		private IEnumerator flyAnimation;

		public void Init(Params flyParams)
		{
		}

		private IEnumerator DoFly()
		{
			return null;
		}

		public override void OnUpdate(float deltaTime)
		{
		}
	}
}
