using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace GGMatch3
{
	public class CollectGoalAction : BoardAction
	{
		public struct CollectGoalParams
		{
			public Match3Goals.GoalBase goal;

			public MonsterElements.MonsterElementPieces monsterToFeed;

			public Chip chip;

			public TransformBehaviour moveTransform;

			public Match3Game game;

			public Slot chipSlot;

			public List<Slot> otherAffectedSlots;

			public bool isExplosion;

			public bool isMagicHat;

			public IntVector2 explosionCentre;

			public SlotDestroyParams destroyParams;

			public float delay;

			public bool skipScale;

			public bool smallScale;

			public int collectMoreMovesCount;

			public bool isFromRocket => false;

			public TransformBehaviour transformToMove => null;

			public bool isCollectMoreMovesChip => false;
		}

		[Serializable]
		public class Settings
		{
			public bool useParticlesForChip;

			public SpriteSortingSettings sortingLayer;

			public SpriteSortingSettings sortingLayerFly;

			public float timeToLockSlot;

			public float travelDuration;

			public float travelSpeed;

			public AnimationCurve travelCurve;

			public float scaleUpScale;

			public bool useSmallEndScale;

			public float smallEndScale;

			public float smallScale;

			public float scaleUpDuration;

			public AnimationCurve scaleUpCurve;

			public float distanceWithSwap;

			public float distanceWithBomb;

			public float distanceWithMagicHat;

			public AnimationCurve bombCurve;

			public float bombDuration;

			public float orthoDistance;

			public AnimationCurve orthoCurve;

			public bool useScaleCurve;

			public AnimationCurve scaleCurve;
		}

		private sealed class _003CScalePart_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CollectGoalAction _003C_003E4__this;

			private TransformBehaviour _003CtransformBehaviour_003E5__2;

			private Settings _003Csettings_003E5__3;

			private Vector3 _003CstartScale_003E5__4;

			private Vector3 _003CendScale_003E5__5;

			private float _003Ctime_003E5__6;

			private float _003Cduration_003E5__7;

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
			public _003CScalePart_003Ed__12(int _003C_003E1__state)
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

		private sealed class _003CBombAffectPart_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CollectGoalAction _003C_003E4__this;

			public float distance;

			private TransformBehaviour _003CtransformBehaviour_003E5__2;

			private Settings _003Csettings_003E5__3;

			private Vector3 _003Cdirection_003E5__4;

			private Vector3 _003CstartPosition_003E5__5;

			private float _003Ctime_003E5__6;

			private float _003Cduration_003E5__7;

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
			public _003CBombAffectPart_003Ed__13(int _003C_003E1__state)
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

		private sealed class _003CTravelPart_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CollectGoalAction _003C_003E4__this;

			private TransformBehaviour _003CtransformBehaviour_003E5__2;

			private Settings _003Csettings_003E5__3;

			private Vector3 _003CstartScale_003E5__4;

			private Vector3 _003CstartLocalPos_003E5__5;

			private Vector3 _003CendLocalPos_003E5__6;

			private float _003Ctime_003E5__7;

			private float _003Cduration_003E5__8;

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
			public _003CTravelPart_003Ed__15(int _003C_003E1__state)
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

		private sealed class _003CDoAnimation_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CollectGoalAction _003C_003E4__this;

			private Chip _003Cchip_003E5__2;

			private Match3Game _003Cgame_003E5__3;

			private TransformBehaviour _003CtransformBehaviour_003E5__4;

			private IEnumerator _003Canimation_003E5__5;

			private EnumeratorsList _003CenumList_003E5__6;

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
			public _003CDoAnimation_003Ed__16(int _003C_003E1__state)
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

		private CollectGoalParams collectParams;

		private float deltaTime;

		private IEnumerator animationEnum;

		private Lock globalLock;

		private SlotComponentLock chipLock;

		private float lockedTime;

		public bool isUnlocked;

		private Settings settings => null;

		public void Init(CollectGoalParams collectParams)
		{
		}

		private IEnumerator ScalePart()
		{
			return null;
		}

		private IEnumerator BombAffectPart(float distance)
		{
			return null;
		}

		private float TravelDuration(Vector3 startPos, Vector3 endPos)
		{
			return 0f;
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
