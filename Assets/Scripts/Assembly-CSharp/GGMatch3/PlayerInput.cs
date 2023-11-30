using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace GGMatch3
{
	public class PlayerInput : MonoBehaviour
	{
		public struct AffectorUpdateParams
		{
			public Vector3 currentPosition;

			public MouseParams mouseParams;

			public PlayerInput input;
		}

		public class AffectorBase
		{
			public float affectorDuration;

			private readonly bool _003CwantsToEnd_003Ek__BackingField;

			private readonly float _003CminAffectorDuration_003Ek__BackingField;

			public virtual bool canFinish => false;

			public virtual bool wantsToEnd => false;

			public virtual float minAffectorDuration => 0f;

			public virtual void ReleaseLocks()
			{
			}

			public virtual void ApplyLocks()
			{
			}

			public virtual void Clear()
			{
			}

			public virtual void OnUpdate(AffectorUpdateParams updateParams)
			{
			}

			public virtual void OnBeforeDestroy()
			{
			}

			public virtual void AddToSwitchSlotArguments(ref Match3Game.SwitchSlotsArguments switchSlotsArguments)
			{
			}
		}

		public class ExplosionAffector : AffectorBase
		{
			[Serializable]
			public class Settings
			{
				public int radius;

				public float maxDistance;

				public FloatRange displaceRange;

				public AnimationCurve displaceCurve;

				public float displacePull;

				public float angleSpeed;

				public float phaseOffsetMult;

				public float amplitude;

				public float originScale;

				public float lightIntensity;

				public float distanceDelay;

				public FloatRange lightIntensityRange;

				public float maxLightDistance;

				public float timeToFullIntensity;

				public AnimationCurve intensityCurve;

				public bool lockLine;

				public FloatRange scaleRange;

				public float orthoScaleInfluence;
			}
		}

		public class MoveFromLineAffector : AffectorBase
		{
			[Serializable]
			public class Settings
			{
				public float maxDistance;

				public FloatRange displaceRange;

				public AnimationCurve displaceCurve;

				public float affectedOrtho;

				public float displacePull;

				public float angleSpeed;

				public float phaseOffsetMult;

				public float amplitude;

				public float originScale;

				public float lightIntensity;

				public float distanceDelay;

				public FloatRange lightIntensityRange;

				public float maxLightDistance;

				public float timeToFullIntensity;

				public AnimationCurve intensityCurve;

				public bool lockLine;

				public FloatRange scaleRange;

				public float orthoScaleInfluence;
			}
		}

		[Serializable]
		public class Settings
		{
			public bool tapToDestroy;

			public float maxDistance;

			public float maxDisplace;

			public float maxDistanceCurrentPos;

			public float maxDisplaceFwd;

			public float maxDisplaceBck;

			public float noDragFactor;

			public float maxAcceleration;

			public Vector3 displaceScale;

			public AnimationCurve displaceCurve;

			public AnimationCurve velocityDisplaceCurve;

			public AnimationCurve scaleCurve;

			public float maxOffsetVelocity;

			public float stiffness;

			public float dampingFactor;

			public float displacePull;

			public bool enableBouncyMode;

			public bool inputDirectMode;

			public bool switchImmediateIfPossible;

			public bool switchSlotPosition;

			public bool inputLineMode;

			public bool useMouse1ForBouncy;

			public float lightIntensityForMatch;

			public float lightIntensityForMatchOff;

			public bool addPowerupVis;

			public float addedLightIntensityForMatch;

			public float velocityDisplace;

			public float velocityDisplaceFwd;

			public float velocityDisplaceBck;

			public float centreMaxDistance;

			public float centreOffset;

			public float bckMaxDistanceX;

			public float bckMaxDistanceY;

			public FloatRange bckOffsetX;

			public FloatRange bckOffsetY;

			public AnimationCurve bckCurveX;

			public AnimationCurve bckCurveY;

			public float fwdMaxDistanceX;

			public float fwdMaxDistanceY;

			public FloatRange fwdOffsetX;

			public FloatRange fwdOffsetY;

			public float totalOffsetForFirstSlot;

			public float totalOffsetForFirstSlotMatching;

			public float directionInfluence;

			public float directionInfluenceFwd;

			public AnimationCurve pullCurve;

			public float directionInfluenceControl;

			public bool disableLightingInAffectors;

			public bool useSimpleLineBolts;

			public bool disableBombLighting;
		}

		public class MouseParams
		{
			public enum State
			{
				Touch = 0,
				TapActivated = 1,
				SwapActivated = 2,
				SwapToNothingActivated = 3,
				CancelSwap = 4,
				SwapToNoMatchActivated = 5
			}

			public State state;

			public bool isMouseDown;

			public bool isSlotSwitched;

			public Vector3 mouseDownPositon;

			public Vector3 mouseDownUIPosition;

			public int touchId;

			public Slot firstHitSlot;

			public Chip chip;

			public Slot slotToSwitchWith;

			public Slot lastTestedSlotToSwitchWith;

			public Chip chipToSwitchWith;

			public MixClass mixClass;

			public bool isSlotToSwitchWithOffsetPositionSet;

			public Vector3 slotToSwitchWithOffsetPosition;

			public bool isMatching;

			public List<Slot> affectedSlotsForMatch;

			public List<Chip> affectedChipsForMatch;

			public List<Slot> affectedSlotsForMix;

			public IEnumerator mouseUpEnum;

			private AffectorBase activeAffector_;

			public AffectorBase activeAffector
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public void ResetAffectedSlotsForMatch(PlayerInput input)
			{
			}

			public Vector2 MousePosition(InputHandler input)
			{
				return default(Vector2);
			}

			public void SetPointerIdToFirstDownPointer(InputHandler input)
			{
			}

			public bool IsDown(InputHandler input)
			{
				return false;
			}

			public bool IsUp(InputHandler input)
			{
				return false;
			}

			public void Clear()
			{
			}

			public void Reset(Lock mainLock, PlayerInput input)
			{
			}
		}

		public class MixClass
		{
			public List<Chip> chips;

			public void Clear()
			{
			}

			public int CountOfType(ChipType type, ChipType type2)
			{
				return 0;
			}

			public Chip GetChip(ChipType type)
			{
				return null;
			}

			public Chip GetOtherChip(ChipType type)
			{
				return null;
			}

			public int CountOfType(ChipType type)
			{
				return 0;
			}

			public void TryAdd(Chip chip)
			{
			}
		}

		private sealed class _003CDoWaitForActiveAffector_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AffectorBase activeAffector;

			public PlayerInput _003C_003E4__this;

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
			public _003CDoWaitForActiveAffector_003Ed__42(int _003C_003E1__state)
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

		[NonSerialized]
		public FindMatches findMatches;

		private CompositeAffector compositeAffector;

		[SerializeField]
		private Camera mainCamera;

		[SerializeField]
		private PlayerInputFollower follower;

		[SerializeField]
		private Transform match3ParentTransform;

		[SerializeField]
		private float sizeToSwitch;

		[SerializeField]
		private bool useUISizeToSwitch;

		[SerializeField]
		private float uiSizeToSwitch;

		[SerializeField]
		private float chipBrightness;

		[SerializeField]
		private float angleToSwitch;

		private MouseParams mouseParams;

		private MouseParams followerMouseParams;

		private MouseParams mouseParamsDisplace;

		[NonSerialized]
		public Match3Game game;

		private Lock mainLock;

		private LightSlotComponent.PermanentLight matchLight;

		private LightSlotComponent.PermanentLight exchangeLight;

		private LockContainer lockContainer;

		private ItemColor lastColor;

		public Settings settings => null;

		public bool isActive => false;

		private InputHandler input => null;

		private void SetFollowerLocalPosition(Vector3 localPosition)
		{
		}

		public void UpdateDisplaceIntegration()
		{
		}

		public void ResetDisplace()
		{
		}

		public void ApplyDisplace(Slot firstHitSlot, Vector3 startPos, Vector3 currentPosition, Vector3 velocity, Slot ignoreSlot_, bool isNoDrag)
		{
		}

		public void SetCamera(Camera mainCamera)
		{
		}

		public void Init(Match3Game game)
		{
		}

		public Slot GetSlotFromMousePosition(Vector3 mousePosition)
		{
			return null;
		}

		private Vector3 LocalMatch3Pos(Vector3 mousePosScreen)
		{
			return default(Vector3);
		}

		private Vector3 LocalUIPos(Vector3 mousePosScreen)
		{
			return default(Vector3);
		}

		private Slot GetSlot(Vector3 localPosition)
		{
			return null;
		}

		private void UpdateDisplace()
		{
		}

		private void OnMouseUpStart()
		{
		}

		private IEnumerator DoWaitForActiveAffector(AffectorBase activeAffector)
		{
			return null;
		}

		private void OnMouseUp()
		{
		}

		private void TryActivateTap(MouseParams mouseParams)
		{
		}

		private void UpdateFollower()
		{
		}

		private void UpdateSimple()
		{
		}

		private void Cancel()
		{
		}

		private void TrySwitchSlotsSimple(Slot slotToSwitchWith, IntVector2 otherSlotPosition)
		{
		}

		private bool TrySwitchSlotsSimpleInner(Slot slotToSwitchWith)
		{
			return false;
		}

		private void DoTapParticleOnPosition(Vector3 localPosition)
		{
		}

		private void DoSwipeParticlesBetweenSlots(Slot firstHitSlot, Slot slotToSwitchWith)
		{
		}

		private void DoSwipeParticlesBetweenSlots(IntVector2 pos1, IntVector2 pos2)
		{
		}

		private void OnEnable()
		{
		}

		public void DoUpdate(float deltaTime)
		{
		}
	}
}
