using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace GGMatch3
{
	public class ShowSwapNotPossibleAction : BoardAction
	{
		[Serializable]
		public class Settings
		{
			public float duration;

			public float moveDistance;

			public AnimationCurve moveCurve;

			public AnimationCurve moveOutCurve;

			public float brightness;
		}

		public struct SwapChipsParams
		{
			public Match3Game game;

			public Slot slot1;

			public IntVector2 positionToMoveSlot1;

			public bool wobble;
		}

		private sealed class _003CMoveSingleChipAnimation_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShowSwapNotPossibleAction _003C_003E4__this;

			public Slot slotToMove;

			public AnimationCurve moveCurve;

			public Vector3 startPosition;

			public Vector3 endPosition;

			private float _003Ctime_003E5__2;

			private float _003Cduration_003E5__3;

			private TransformBehaviour _003CchipBehaviour_003E5__4;

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
			public _003CMoveSingleChipAnimation_003Ed__9(int _003C_003E1__state)
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

		private sealed class _003CMoveAnimation_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShowSwapNotPossibleAction _003C_003E4__this;

			private Slot _003Cslot1_003E5__2;

			private Vector3 _003CstartPos_003E5__3;

			private Vector3 _003CendPos_003E5__4;

			private TransformBehaviour _003CchipBehaviour_003E5__5;

			private IEnumerator _003Canimation_003E5__6;

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
			public _003CMoveAnimation_003Ed__10(int _003C_003E1__state)
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

		private SwapChipsParams chipParams;

		private float deltaTime;

		private Lock slotLock;

		private IEnumerator moveAnimation;

		private Settings settings => null;

		public void Init(SwapChipsParams chipParams)
		{
		}

		public IEnumerator MoveSingleChipAnimation(Slot slotToMove, Vector3 startPosition, Vector3 endPosition, AnimationCurve moveCurve)
		{
			return null;
		}

		public IEnumerator MoveAnimation()
		{
			return null;
		}

		public override void OnUpdate(float deltaTime)
		{
		}
	}
}
