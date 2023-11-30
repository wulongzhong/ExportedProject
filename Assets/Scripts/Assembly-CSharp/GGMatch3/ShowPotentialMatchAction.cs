using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace GGMatch3
{
	public class ShowPotentialMatchAction : BoardAction
	{
		public struct InitParams
		{
			public Match3Game game;

			public bool stayInfiniteTime;

			public LevelDefinition.TutorialMatch tutorialMatch;

			public PowerupCombines.PowerupCombine powerupCombine;

			public PowerupActivations.PowerupActivation powerupActivation;

			public PotentialMatches.CompoundSlotsSet potentialMatch;

			public int userMoveWhenShow;

			public int movesCountWhenConveyorTookAction;

			public bool dontStopWhenInvalid;
		}

		[Serializable]
		public class Settings
		{
			public struct ShowPotentialMatchTimes
			{
				public float idleTimeBeforeShowMatch;

				public float boardIdleTimeBeforeShowMatch;
			}

			[Serializable]
			public class ShowSettingsModifier
			{
				[SerializeField]
				public ShowPotentialMatchSetting setting;

				[SerializeField]
				private float idleTimeBeforeShowMatch;

				[SerializeField]
				private float boardIdleTimeBeforeShowMatch;

				[SerializeField]
				private float idleTimeBeforePowerupCombine;

				[SerializeField]
				private float boardIdleTimeBeforePowerupCombine;

				[SerializeField]
				private bool useMaxTime;

				[SerializeField]
				private int userMovesBeforeMaxTime;

				[SerializeField]
				private float idleTimeBeforeShowMatchMax;

				[SerializeField]
				private float boardIdleTimeBeforeShowMatchMax;

				public ShowPotentialMatchTimes GetPotentialTimesAction(bool hasPowerupCombines, Match3Game game)
				{
					return default(ShowPotentialMatchTimes);
				}
			}

			public float duration;

			public float scaleDownDuration;

			public AnimationCurve scaleDownAnimation;

			public float waitBetweenFlashes;

			public AnimationCurve scaleAnimation;

			public bool useBrightness;

			public float brightnessMax;

			public AnimationCurve brightnessCurve;

			public float maxScale;

			public int maxFlashes;

			public float stayBigDuration;

			public float idleTimeBeforeShowMatch;

			public float boardIdleTimeBeforeShowMatch;

			public float idleTimeBeforePowerupCombine;

			public float boardIdleTimeBeforePowerupCombine;

			public float moveDuration;

			public float moveDistance;

			public AnimationCurve moveCurve;

			public float moveDelay;

			[SerializeField]
			private List<ShowSettingsModifier> showSettingsModifiers;

			public ShowPotentialMatchTimes GetPotentialTimesAction(ShowPotentialMatchSetting setting, bool hasPowerupCombines, Match3Game game)
			{
				return default(ShowPotentialMatchTimes);
			}

			private ShowSettingsModifier GetSettingsModifier(ShowPotentialMatchSetting setting)
			{
				return null;
			}
		}

		private struct SlotChipPair
		{
			public Slot slot;

			public Chip chip;

			public Vector3 moveDirection;

			public TransformBehaviour transform => null;

			public Vector3 showMatchOffset
			{
				set
				{
				}
			}

			public float brightness
			{
				set
				{
				}
			}

			public Vector3 showMatchActionLocalScale
			{
				set
				{
				}
			}

			public bool isChipChangedSlot => false;

			//public SlotChipPair(Slot slot, Chip chip)
			//{
			//}
		}

		private sealed class _003CDoMoveAnimation_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShowPotentialMatchAction _003C_003E4__this;

			private Settings _003Csettings_003E5__2;

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
			public _003CDoMoveAnimation_003Ed__22(int _003C_003E1__state)
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

		private sealed class _003CDoSingleAnimation_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShowPotentialMatchAction _003C_003E4__this;

			private float _003Ctime_003E5__2;

			private Settings _003Csettings_003E5__3;

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
			public _003CDoSingleAnimation_003Ed__23(int _003C_003E1__state)
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

		private sealed class _003CDoAnimation_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShowPotentialMatchAction _003C_003E4__this;

			private IEnumerator _003CsingleAnimation_003E5__2;

			private IEnumerator _003CmoveAnimation_003E5__3;

			private int _003Cflashes_003E5__4;

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
			public _003CDoAnimation_003Ed__24(int _003C_003E1__state)
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

		private InitParams initParams;

		private List<SlotChipPair> matchingSlots;

		private List<SlotChipPair> swipeSlots;

		private IEnumerator animation;

		private float deltaTime;

		private TilesBorderRenderer borderRenderer;

		private TilesBorderRenderer maskRenderer;

		private ListSlotsProvider listSlotsProvider;

		private List<Slot> helperList;

		private Settings settings => null;

		private bool isMatchNoLongerValid => false;

		private bool isMatchStillValid => false;

		private void Clear()
		{
		}

		public void Init(InitParams initParams)
		{
		}

		private IEnumerator DoMoveAnimation()
		{
			return null;
		}

		private IEnumerator DoSingleAnimation()
		{
			return null;
		}

		private IEnumerator DoAnimation()
		{
			return null;
		}

		private void StopAction()
		{
		}

		private void ReturnChipsToPositions()
		{
		}

		public override void OnUpdate(float deltaTime)
		{
		}

		public override void Stop()
		{
		}
	}
}
