using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace GGMatch3
{
	public class SwapChipsAction : BoardAction
	{
		[Serializable]
		public class Settings
		{
			public float duration;

			public AnimationCurve moveCurve;

			public AnimationCurve scaleCurve;

			public float brightness;
		}

		public struct SwapChipsParams
		{
			public Match3Game game;

			public Slot slot1;

			public Slot slot2;

			public bool moveToSpecificPos;

			public IntVector2 positionToMoveSlot1;

			public IntVector2 positionToMoveSlot2;

			public Action onComplete;

			public bool switchSlots;

			public bool scaleDownChip2;

			public void CallOnComplete()
			{
			}
		}

		private sealed class _003CMoveSingleChipAnimation_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SwapChipsAction _003C_003E4__this;

			public Slot slotToMove;

			public IntVector2 positionToMoveTo;

			private float _003Ctime_003E5__2;

			private float _003Cduration_003E5__3;

			private TransformBehaviour _003CchipBehaviour_003E5__4;

			private Vector3 _003CstartPosition_003E5__5;

			private Vector3 _003CendPosition_003E5__6;

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

		private sealed class _003CScaleDownChipAnimation_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SwapChipsAction _003C_003E4__this;

			public Slot slotToMove;

			public IntVector2 positionToMoveTo;

			private float _003Ctime_003E5__2;

			private float _003Cduration_003E5__3;

			private TransformBehaviour _003CchipBehaviour_003E5__4;

			private Vector3 _003CstartPosition_003E5__5;

			private Vector3 _003CendPosition_003E5__6;

			private Vector3 _003Cdirection_003E5__7;

			private float _003ChalphDuration_003E5__8;

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
			public _003CScaleDownChipAnimation_003Ed__10(int _003C_003E1__state)
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

		private sealed class _003CMoveAnimation_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SwapChipsAction _003C_003E4__this;

			private EnumeratorsList _003CenumList_003E5__2;

			private Slot _003Cslot1_003E5__3;

			private Slot _003Cslot2_003E5__4;

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
			public _003CMoveAnimation_003Ed__12(int _003C_003E1__state)
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

		public IEnumerator MoveSingleChipAnimation(Slot slotToMove, IntVector2 positionToMoveTo)
		{
			return null;
		}

		public IEnumerator ScaleDownChipAnimation(Slot slotToMove, IntVector2 positionToMoveTo)
		{
			return null;
		}

		private void SetBrightness(Slot slot, float brightness)
		{
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
