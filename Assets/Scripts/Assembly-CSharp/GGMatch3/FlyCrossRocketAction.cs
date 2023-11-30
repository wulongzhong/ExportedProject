using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace GGMatch3
{
	public class FlyCrossRocketAction : BoardAction
	{
		public struct FlyParams
		{
			public Match3Game game;

			public IntVector2 originPosition;

			public int rows;

			public int columns;

			public bool prelockAll;

			public bool useDelayBetweenRowsAndColumns;

			public bool isHavingCarpet;

			public List<Chip> bombChips_;

			public Match3Game.InputAffectorExport affectorExport;

			public List<Chip> bombChips => null;
		}

		[Serializable]
		public class Settings
		{
			public float delayBetweenRowsAndColumns;

			public float delayForDistance;
		}

		public class FlyDescriptor
		{
			public IntVector2 position;

			public IntVector2 direction;

			public float delay;

			public bool ignoreOriginSlot;

			public FlyRocketPieceAction action;

			public bool isActivated;
		}

		private sealed class _003CDoFly_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FlyCrossRocketAction _003C_003E4__this;

			private Match3Game _003Cgame_003E5__2;

			private float _003Ctime_003E5__3;

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
			public _003CDoFly_003Ed__15(int _003C_003E1__state)
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

		private FlyParams flyParams;

		private Lock globalLock;

		private List<Slot> lockedSlots;

		private float deltaTime;

		private IEnumerator animation;

		public Match3Game.InputAffectorExport affectorExport;

		public List<FlyDescriptor> flyDescriptors;

		private Settings settings => null;

		public void Init(FlyParams flyParams)
		{
		}

		private void AddFlyDescriptorPair(IntVector2 position, IntVector2 direction, float delay)
		{
		}

		private FlyRocketPieceAction CreateFlyPieceAction(FlyDescriptor flyDescriptor)
		{
			return null;
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
