using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace GGMatch3
{
	public class FlyRocketPieceAction : BoardAction
	{
		public struct Params
		{
			public Match3Game game;

			public IntVector2 position;

			public IntVector2 direction;

			public bool prelock;

			public bool isInstant;

			public bool ignoreOriginSlot;

			public bool canUseScale;

			public bool isHavingCarpet;

			public Match3Game.InputAffectorExport affectorExport;
		}

		[Serializable]
		public class Settings
		{
			public FloatRange speedRange;

			public FloatRange accelerationTime;

			public AnimationCurve velocityChangeCurve;

			public float timeScale;

			public float lightIntensity;

			public FloatRange lightIntensityRange;

			public float maxLightDistance;

			public float lightDuration;

			public Vector3 scale;

			public Vector3 scaleMin;

			public Vector3 scaleMax;

			public float initialDisplace;

			public float initialDelay;

			public float additionalTimeToKeepLock;

			public float keepParticlesFor;

			public int slotsOutside;

			public float shockWaveOffset;

			public float timeAheadDestroy;

			public bool putBoltOnLastSlot;

			public float boltDelay;

			public bool keepBaltsDistance;

			public float minBoltDuration;

			public bool useCameraShake;

			public GeneralSettings.CameraShakeSettings cameraShake;
		}

		public struct AffectedSlot
		{
			public Slot slot;

			public LightingBolt bolt;
		}

		public struct LockedSlot
		{
			public Slot slot;

			public float timeLocked;

			public bool isUnlocked;
		}

		private sealed class _003CDoFly_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FlyRocketPieceAction _003C_003E4__this;

			private float _003Ctime_003E5__2;

			private Match3Game _003Cgame_003E5__3;

			private Vector3 _003CcurrentPositon_003E5__4;

			private Vector3 _003Cdirection_003E5__5;

			private List<Slot> _003CvisitedSlots_003E5__6;

			private IntVector2 _003ClastSlotPosition_003E5__7;

			private SlotDestroyParams _003CdestroyParams_003E5__8;

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
			public _003CDoFly_003Ed__22(int _003C_003E1__state)
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

		private Params initParams;

		private Lock prelock;

		private float deltaTime;

		private IEnumerator animation;

		private RocketPieceBehaviour rocketPiece;

		private List<Slot> pathSlots;

		private Lock individualLock;

		private bool createdBolt;

		private List<AffectedSlot> affectedSlots;

		private List<LockedSlot> lockedSlotsList;

		private bool hasCarpet;

		private Settings settings => null;

		public void Init(Params initParams)
		{
		}

		private void ClearAffectedSlots()
		{
		}

		private RocketPieceBehaviour CreateRocketPiece()
		{
			return null;
		}

		public List<Slot> GetPathSlots()
		{
			return null;
		}

		private bool UpdateLockedSlots()
		{
			return false;
		}

		private IEnumerator DoFly()
		{
			return null;
		}

		public override void OnStart(ActionManager manager)
		{
		}

		public override void OnUpdate(float deltaTime)
		{
		}

		private void ApplyDisplaceAfterDestroy(Slot slot)
		{
		}
	}
}
