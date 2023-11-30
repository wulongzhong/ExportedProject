using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace GGMatch3
{
	public class AnimateGrowingElementOnChip : BoardAction
	{
		public struct InitArguments
		{
			public Match3Game game;

			public ItemColor itemColor;

			public Vector3 worldPositionStart;

			public Chip chipToConnectTo;

			public Slot destinationSlot;

			public bool forceConvertChip;

			public GrowingElementChip growingElement;
		}

		[Serializable]
		public class Settings
		{
			public SpriteSortingSettings sortingLayer;

			public SpriteSortingSettings sortingLayerFly;

			public float travelDuration;

			public AnimationCurve travelCurve;

			public float startScale;

			public float scaleUpScale;

			public float scaleUpDuration;

			public AnimationCurve scaleUpCurve;

			public AnimationCurve rotationCurve;
		}

		private sealed class _003CScalePart_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimateGrowingElementOnChip _003C_003E4__this;

			public TransformBehaviour transformBehaviour;

			private Settings _003Csettings_003E5__2;

			private Vector3 _003CstartScale_003E5__3;

			private Vector3 _003CendScale_003E5__4;

			private float _003Ctime_003E5__5;

			private float _003Cduration_003E5__6;

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
			public _003CScalePart_003Ed__9(int _003C_003E1__state)
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

		private sealed class _003CTravelPart_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimateGrowingElementOnChip _003C_003E4__this;

			public TransformBehaviour transformBehaviour;

			public Vector3 endLocalPos;

			private Settings _003Csettings_003E5__2;

			private Vector3 _003CstartLocalPos_003E5__3;

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
			public _003CTravelPart_003Ed__10(int _003C_003E1__state)
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

		private sealed class _003CDoAnimation_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimateGrowingElementOnChip _003C_003E4__this;

			private Match3Game _003Cgame_003E5__2;

			private TransformBehaviour _003CtransformBehaviour_003E5__3;

			private IEnumerator _003Canimation_003E5__4;

			private EnumeratorsList _003CenumList_003E5__5;

			private Slot _003CdestinationSlot_003E5__6;

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
			public _003CDoAnimation_003Ed__12(int _003C_003E1__state)
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

		private float deltaTime;

		private IEnumerator animationEnum;

		private Lock slotLock;

		private Settings settings => null;

		public void Init(InitArguments initArguments)
		{
		}

		private IEnumerator ScalePart(TransformBehaviour transformBehaviour)
		{
			return null;
		}

		private IEnumerator TravelPart(TransformBehaviour transformBehaviour, Vector3 endLocalPos)
		{
			return null;
		}

		public static TransformBehaviour CreateGrowingElementPieceBehaviour(Match3Game game)
		{
			return null;
		}

		private IEnumerator DoAnimation()
		{
			return null;
		}

		public override void OnUpdate(float deltaTime)
		{
		}
	}
}
