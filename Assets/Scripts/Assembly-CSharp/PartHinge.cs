using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PartHinge : MonoBehaviour
{
	[Serializable]
	public class VisibleCondition
	{
		[SerializeField]
		public PartHinge hinge;

		[SerializeField]
		public bool isOnWhenVisible;

		public bool shouldBeVisible => false;
	}

	[Serializable]
	public class CustomizationDependantObjects
	{
		[SerializeField]
		public CarModelCustomization customization;

		[SerializeField]
		public int variantIndex;

		[SerializeField]
		public List<Transform> transforms;
	}

	private enum MovementType
	{
		Rotate = 0,
		Shake = 1,
		None = 2
	}

	[Serializable]
	protected class ConditionallyOn
	{
		[SerializeField]
		private List<CarModelPart> turnOnWhenOwned;

		[SerializeField]
		private List<Transform> transforms;

		private bool shouldTurnOn => false;

		public void TurnOnIfShould()
		{
		}
	}

	[Serializable]
	public class ShakeSettings
	{
		[SerializeField]
		public float startFrequency;

		[SerializeField]
		public float startAngleAmplitude;

		[SerializeField]
		public float durationToStart;

		[SerializeField]
		public float frequency;

		[SerializeField]
		public float angleAmplitude;

		[SerializeField]
		public Vector3 axis;
	}

	private sealed class _003CShakeRotation_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PartHinge _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private ShakeSettings _003Csettings_003E5__3;

		private float _003CsinAngle_003E5__4;

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
		public _003CShakeRotation_003Ed__55(int _003C_003E1__state)
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

	private sealed class _003CDoChangeRotation_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PartHinge _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private float _003Cduration_003E5__3;

		private Quaternion _003CstartRotation_003E5__4;

		private Quaternion _003CendRotation_003E5__5;

		private AnimationCurve _003CtimeCurve_003E5__6;

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
		public _003CDoChangeRotation_003Ed__56(int _003C_003E1__state)
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

	[SerializeField]
	public Sprite onSprite;

	[SerializeField]
	public Sprite offSprite;

	[SerializeField]
	private MovementType movementType;

	[SerializeField]
	public Vector3 forwardDirection_;

	[SerializeField]
	private Transform transformToMove_;

	[SerializeField]
	private AudioClip onClip;

	[SerializeField]
	private AudioClip offClip;

	[SerializeField]
	private AudioClip onAnimationFinishClip;

	[SerializeField]
	private AudioClip offAnimationFinishClip;

	[SerializeField]
	public bool stopDefaultButtonSound;

	[SerializeField]
	private List<VisibleCondition> visibleConditions;

	[SerializeField]
	private List<PartHinge> partsToCloseWhenClosing;

	[SerializeField]
	private Transform handleTransform_;

	[SerializeField]
	private List<Transform> showWenOn;

	[SerializeField]
	private List<CustomizationDependantObjects> customizationShowWhenOn;

	[SerializeField]
	private List<ConditionallyOn> conditionalOnList;

	[SerializeField]
	private CarSubPartInfo.RotateSettings rotateSettings;

	[SerializeField]
	private ShakeSettings shakeSettings;

	[NonSerialized]
	public List<CarModelSubpart> parentedSubparts;

	[SerializeField]
	public List<CarModelPart> onlyShowWhenActive;

	[SerializeField]
	public List<CarModelPart> showWhenAllActive;

	[SerializeField]
	public bool changeButtonScale;

	[SerializeField]
	public float minScale;

	[SerializeField]
	public float minDistance;

	private IEnumerator openAnimation;

	private bool isOpen;

	private Transform transformToMove => null;

	public Vector3 positionToAttach => default(Vector3);

	public Transform handleTransform => null;

	public Vector3 forwardDirection => default(Vector3);

	private CarModelSubpart.Settings settings => null;

	public bool isOn => false;

	public bool isVisible => false;

	public bool isAnyPartShowing => false;

	public void CallbackWhenBuildingCarModelFromEditor()
	{
	}

	public void InstantReturnToClosedPosition()
	{
	}

	public void InstantReturnToOpenPosition()
	{
	}

	public void MakeMovableUnderHinge(CarModelSubpart subpart)
	{
	}

	public void AnimateOpen()
	{
	}

	public void AnimateClose()
	{
	}

	public void ChangeRotation()
	{
	}

	private void AimateRotation()
	{
	}

	private IEnumerator ShakeRotation()
	{
		return null;
	}

	private IEnumerator DoChangeRotation()
	{
		return null;
	}

	private void Update()
	{
	}
}
