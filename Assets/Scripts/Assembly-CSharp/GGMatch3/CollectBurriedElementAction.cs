using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace GGMatch3
{
	public class CollectBurriedElementAction : BoardAction
	{
		public struct CollectGoalParams
		{
			public Match3Goals.GoalBase goal;

			public Match3Game game;

			public BurriedElementPiece burriedElement;

			public SlotBurriedElement slotBurriedElement;

			public SlotDestroyParams destroyParams;

			public Slot slotToLock;

			public IntVector2 explosionCentre;

			public LevelDefinition.BurriedElement burriedElementDefinition => null;

			public BurriedElementBehaviour burriedElementBehaviour => null;

			public Quaternion localRotation
			{
				get
				{
					return default(Quaternion);
				}
				set
				{
				}
			}

			public TransformBehaviour transformBehaviour => null;

			public void RemoveFromGame()
			{
			}
		}

		[Serializable]
		public class Settings
		{
			public SpriteSortingSettings sortingLayer;

			public SpriteSortingSettings sortingLayerFly;

			public float travelDuration;

			public float additionalParticlesDuration;

			public float travelSpeed;

			public float maxTime;

			public float minTime;

			public AnimationCurve travelCurve;

			public float scaleUpScale;

			public float scaleUpScalEndRange;

			public float scaleUpDuration;

			public AnimationCurve scaleUpCurve;

			public AnimationCurve rotationCurve;

			public float timeToLockSlot;

			public float rotationAngle;

			public float scaleUpAngle;

			public float scaleUpAngleRangeEnd;

			public AnimationCurve bombCurve;

			public float distance;

			public bool useColor;

			public Color color;

			public float brightness;

			public float ortoDistance;

			public AnimationCurve ortoCurve;

			public bool useTravelScaleCurve;

			public AnimationCurve travelScaleCurve;

			public bool useJump;

			public float jumpDuration;

			public Vector3 jumpOffset;

			public AnimationCurve jumpTravelCurve;

			public float angleSpeed;

			public float jumpScale1;

			public AnimationCurve jumpScale1Curve;

			public float jumpScale2;

			public AnimationCurve jumpScale2Curve;
		}

		private sealed class _003CScalePart_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CollectBurriedElementAction _003C_003E4__this;

			private TransformBehaviour _003CtransformBehaviour_003E5__2;

			private Quaternion _003CstartRotation_003E5__3;

			private Quaternion _003CendRotation_003E5__4;

			private Settings _003Csettings_003E5__5;

			private Vector3 _003CstartScale_003E5__6;

			private Vector3 _003CendScale_003E5__7;

			private Vector3 _003ClocalPosition_003E5__8;

			private Vector3 _003Cdirection_003E5__9;

			private float _003CstartAngle_003E5__10;

			private float _003CendAngle_003E5__11;

			private float _003Ctime_003E5__12;

			private float _003Cduration_003E5__13;

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
			public _003CScalePart_003Ed__13(int _003C_003E1__state)
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

		private sealed class _003CTravelJumpPart_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CollectBurriedElementAction _003C_003E4__this;

			private TransformBehaviour _003CtransformBehaviour_003E5__2;

			private Settings _003Csettings_003E5__3;

			private Vector3 _003CstartScale_003E5__4;

			private float _003Cangle_003E5__5;

			private Vector3 _003CstartLocalPos_003E5__6;

			private Vector3 _003CendLocalPos_003E5__7;

			private Vector3 _003CuiEndLocalPos_003E5__8;

			private float _003Ctime_003E5__9;

			private float _003Cduration_003E5__10;

			private Vector3 _003CendScale_003E5__11;

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
			public _003CTravelJumpPart_003Ed__15(int _003C_003E1__state)
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

		private sealed class _003CTravelPart_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CollectBurriedElementAction _003C_003E4__this;

			private TransformBehaviour _003CtransformBehaviour_003E5__2;

			private Settings _003Csettings_003E5__3;

			private Vector3 _003CstartScale_003E5__4;

			private Vector3 _003CstartLocalPos_003E5__5;

			private Vector3 _003CendLocalPos_003E5__6;

			private float _003Ctime_003E5__7;

			private float _003Cduration_003E5__8;

			private float _003CstartAngle_003E5__9;

			private float _003CendAngle_003E5__10;

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
			public _003CTravelPart_003Ed__16(int _003C_003E1__state)
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

		private sealed class _003CDoAnimation_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CollectBurriedElementAction _003C_003E4__this;

			private Match3Game _003Cgame_003E5__2;

			private TransformBehaviour _003CtransformBehaviour_003E5__3;

			private IEnumerator _003Canimation_003E5__4;

			private EnumeratorsList _003CenumList_003E5__5;

			private float _003Ctime_003E5__6;

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
			public _003CDoAnimation_003Ed__17(int _003C_003E1__state)
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

		private GameObject travelParticles;

		private CollectGoalParams collectParams;

		private float deltaTime;

		private IEnumerator animationEnum;

		private Lock globalLock;

		private float lockedTime;

		private bool isUnlocked;

		private float scaleUpAngle;

		private Settings settings => null;

		public void Init(CollectGoalParams collectParams)
		{
		}

		private IEnumerator ScalePart()
		{
			return null;
		}

		private float TravelDuration(Vector3 startPos, Vector3 endPos)
		{
			return 0f;
		}

		private IEnumerator TravelJumpPart()
		{
			return null;
		}

		private IEnumerator TravelPart()
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
