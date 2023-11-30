using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace GGMatch3
{
	public class SeekingMissileAction : BoardAction
	{
		public class Parameters
		{
			public bool hasOtherChip;

			public ChipType otherChipType;

			public Match3Game game;

			public Slot startSlot;

			public bool isHavingCarpet;

			public bool doCrossExplosion;

			public IntVector2 startPosition => default(IntVector2);
		}

		[Serializable]
		public class Settings
		{
			[Serializable]
			public class CurveParameters
			{
				public AnimationCurve curve;

				public FloatRange range;

				public float duration;

				public float Evaluate(float time)
				{
					return 0f;
				}
			}

			public float bigRadiusNormalized;

			public float radiusRatio;

			public FloatRange altutudeScale;

			public float maxAltitude;

			public float timeToMaxAltitude;

			public float keepParticlesFor;

			public FloatRange bigExitDistanceRange;

			public FloatRange smallExitDistanceRange;

			public CurveParameters bigCircleAccelerationCurve;

			public CurveParameters smallCircleAccelerationCurve;

			public CurveParameters lineAccelerationCurve;

			public bool overrideStartPosition;

			public Vector3 startPosition;

			public bool overrideEndPosition;

			public Vector3 endPosition;

			public bool overrideBigAngle;

			public int bigAngle;

			public bool overrideT;

			public float t;

			public IntensityChange lightIntensityChange;

			public float hitLightIntensity;

			public float shockWaveOffset;

			public float shockWaveOffsetR1;

			public bool useCameraShakeOnLand;

			public GeneralSettings.CameraShakeSettings cameraShake;

			public bool useCameraShakeOnTakeOff;

			public GeneralSettings.CameraShakeSettings takeOffCameraShake;

			public float bigExitDistance => 0f;

			public float smallExitDistance => 0f;
		}

		public enum State
		{
			BigCircle = 0,
			SmallCircle = 1,
			Line = 2
		}

		public class Trajectory
		{
			public Vector3 bigCenter;

			public float bigRadius;

			public float bigAngle;

			public Vector3 bigDirection;

			public float bigExitAngle;

			public Vector3 smallCenter;

			public float smallRadius;

			public float smallAngle;

			public Vector3 smallDirection;

			public float smallExitAngle;

			public Vector3 lineStart;

			public Vector3 lineEnd;

			public float exitDistance;
		}

		public struct Tangents
		{
			public float gamaRad;

			public float betaRad;

			public float alphaRad;

			public float tan1AngleRad;

			public float tan2AngleRad;

			public Circle c1;

			public Circle c2;

			public Vector3 c1Tan1;

			public Vector3 c2Tan1;

			public Vector3 c1Tan2;

			public Vector3 c2Tan2;
		}

		public class Circle
		{
			public Vector3 position;

			public float radius;

			public Circle(Vector3 position, float radius)
			{
			}
		}

		private sealed class _003CDoFly_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SeekingMissileAction _003C_003E4__this;

			private Settings _003Csettings_003E5__2;

			private SeekingMissileBehaviour _003Cbehaviour_003E5__3;

			private Vector3 _003CbigCenter_003E5__4;

			private float _003CbigRadius_003E5__5;

			private float _003CbigExitAngle_003E5__6;

			private Vector3 _003CsmallDirection_003E5__7;

			private Vector3 _003CsmallCenter_003E5__8;

			private float _003CsmallRadius_003E5__9;

			private float _003CsmallExitAngle_003E5__10;

			private Vector3 _003ClineStart_003E5__11;

			private Vector3 _003ClineEnd_003E5__12;

			private float _003CexitDistance_003E5__13;

			private float _003Cangle_003E5__14;

			private float _003Cdistance_003E5__15;

			private Vector3 _003Cdirection_003E5__16;

			private float _003CaccelerationTimer_003E5__17;

			private float _003ClinearSpeed_003E5__18;

			private State _003Cstate_003E5__19;

			private float _003Cheight_003E5__20;

			private float _003CheightWhenStartDescent_003E5__21;

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
			public _003CDoFly_003Ed__18(int _003C_003E1__state)
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

		public Parameters parameters;

		public List<Slot> crossExplosionSlots;

		private Lock targetLock;

		private Lock sourceLock;

		private Slot endSlot;

		private bool hasCarpet;

		private IEnumerator flyCoroutine;

		private float deltaTime;

		public Settings animationParameters => null;

		public IntVector2 endPosition => default(IntVector2);

		public override void OnStart(ActionManager manager)
		{
		}

		public void Init(Parameters parameters)
		{
		}

		public override void OnUpdate(float deltaTime)
		{
		}

		public IEnumerator DoFly()
		{
			return null;
		}

		private void AffectOuterCircleWithExplosion(IntVector2 center, int radius, float shockWaveOffset)
		{
		}

		public Trajectory TrajectoryFromAngle(int bigAngle)
		{
			return null;
		}

		public static Tangents FindOuterTangents(Circle c1, Circle c2)
		{
			return default(Tangents);
		}
	}
}
