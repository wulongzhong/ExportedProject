using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace GGMatch3
{
	public class CreatePowerupAction : BoardAction
	{
		public struct CreateParams
		{
			public Match3Game game;

			public IntVector2 positionWherePowerupWillBeCreated;

			public ChipType powerupToCreate;

			public int addCoins;
		}

		[Serializable]
		public class Settings
		{
			public bool useParticles;

			public float chipStartScale;

			public float chipEndScale;

			public float chipStartAlpha;

			public float chipEndAlpha;

			public float durationForChip;

			public float durationForGoalMin;

			public float durationForGoalMax;

			public AnimationCurve positionCurve;

			public float lightIntensity;

			public float lightDuration;

			public float goalDelay;

			public bool skipScale;

			public float delayForPowerup;

			public float durationForPowerup;

			public AnimationCurve powerupCurve;

			public float startScale;

			public float startAlpha;

			public int lightRadius;

			public float powerupLigtIntensity;

			public float additionalKeepLock;

			public float holdGravityDuration;
		}

		public class ChipToMoveDescriptor
		{
			public Chip chip;

			public LightingBolt bolt;
		}

		private sealed class _003CPowerupCreation_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CreatePowerupAction _003C_003E4__this;

			private float _003Ctime_003E5__2;

			private Match3Game _003Cgame_003E5__3;

			private Slot _003CpowerupSlot_003E5__4;

			private TransformBehaviour _003CchipTransform_003E5__5;

			private float _003Cduration_003E5__6;

			private AnimationCurve _003Ccurve_003E5__7;

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
			public _003CPowerupCreation_003Ed__14(int _003C_003E1__state)
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

		private sealed class _003CCreatePowerupAnimation_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CreatePowerupAction _003C_003E4__this;

			private EnumeratorsList _003CenumList_003E5__2;

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
			public _003CCreatePowerupAnimation_003Ed__15(int _003C_003E1__state)
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

		private sealed class _003CMoveSingleChip_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChipToMoveDescriptor chipDescriptor;

			public CreatePowerupAction _003C_003E4__this;

			public int index;

			private Chip _003Cchip_003E5__2;

			private LightingBolt _003Cbolt_003E5__3;

			private Match3Game _003Cgame_003E5__4;

			private TransformBehaviour _003CchipTransform_003E5__5;

			private Vector3 _003CstartPosition_003E5__6;

			private Vector3 _003CendPosition_003E5__7;

			private float _003Ctime_003E5__8;

			private float _003Cduration_003E5__9;

			private AnimationCurve _003CpositionCurve_003E5__10;

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
			public _003CMoveSingleChip_003Ed__18(int _003C_003E1__state)
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

		private CreateParams createParams;

		private List<ChipToMoveDescriptor> chipsToMove;

		private List<Slot> slots;

		private float deltaTime;

		private IEnumerator animation;

		private Lock slotLock;

		private Lock powerupCreateLock;

		public Settings settings => null;

		public void AddChip(Chip chip, LightingBolt bolt)
		{
		}

		public void Init(CreateParams createParams)
		{
		}

		private IEnumerator PowerupCreation()
		{
			return null;
		}

		private IEnumerator CreatePowerupAnimation()
		{
			return null;
		}

		private float GetDistance(Chip chip)
		{
			return 0f;
		}

		private IEnumerator MoveSingleChip(ChipToMoveDescriptor chipDescriptor, int index)
		{
			return null;
		}

		public override void OnUpdate(float deltaTime)
		{
		}
	}
}
