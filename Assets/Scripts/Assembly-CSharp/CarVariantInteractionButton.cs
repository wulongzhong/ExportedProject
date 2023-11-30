using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CarVariantInteractionButton : MonoBehaviour
{
	public struct InitParams
	{
		public AssembleCarScreen screen;

		public Transform transformPositionToAttachTo;

		public Vector3 positionToAttachTo;

		public Transform forwardTransform;

		public Vector3 forwardDirection;

		public float toleranceAngle;

		public bool alwaysShow;

		public bool stopSound;

		public CarModelInfo.VariantGroup variantGroup;

		public Sprite onSprite;

		public Sprite offSprite;

		public CarModelSubpart subpart;

		public InfoBoxDescription infoBox;

		public CarModelPart carModelPart;

		public PartHinge hinge;

		public CarModelCustomization customization;

		public bool changeButtonScale;

		public float minScale;

		public float minDistance;

		public Action<CarVariantInteractionButton> onClick;

		public bool playSound => false;

		public bool isOn => false;

		public bool isVisible => false;

		public void CallOnClick(CarVariantInteractionButton button)
		{
		}
	}

	private sealed class _003CDoShowMessage_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarVariantInteractionButton _003C_003E4__this;

		public string message;

		public float duration;

		private IEnumerator _003CinAnimation_003E5__2;

		private float _003Ctime_003E5__3;

		private IEnumerator _003CoutAnimation_003E5__4;

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
		public _003CDoShowMessage_003Ed__36(int _003C_003E1__state)
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

	private sealed class _003CScaleFromTo_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public EasingEquation easing;

		public float from;

		public float to;

		public Transform transform;

		private float _003Ctime_003E5__2;

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
		public _003CScaleFromTo_003Ed__37(int _003C_003E1__state)
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

	private sealed class _003CDoClickAnimation_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarVariantInteractionButton _003C_003E4__this;

		private float _003Cduration_003E5__2;

		private float _003CfromScale_003E5__3;

		private float _003CtoScale_003E5__4;

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
		public _003CDoClickAnimation_003Ed__40(int _003C_003E1__state)
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
	private Transform messageTransform;

	[SerializeField]
	private TextMeshProUGUI messageLabel;

	[SerializeField]
	private Transform buyButtonContanier;

	[SerializeField]
	private Image spriteImage;

	[SerializeField]
	private CanvasGroup buttonCanvas;

	[SerializeField]
	private Transform defaultImage;

	[NonSerialized]
	private IEnumerator clickAnimation;

	private bool _003CisMessageShown_003Ek__BackingField;

	[NonSerialized]
	private IEnumerator messageAction;

	[NonSerialized]
	private InitParams initParams;

	private bool shouldBeActive;

	public bool isMessageShown
	{
		get
		{
			return false;
		}
		protected set
		{
		}
	}

	private AssembleCarScreen screen => null;

	public Vector3 positionToAttachTo => default(Vector3);

	public float distanceFromCamera => 0f;

	public CarModelCustomization customization => null;

	public InfoBoxDescription infoBox => null;

	public CarModelPart carModelPart => null;

	public CarModelSubpart subpart => null;

	public PartHinge hinge => null;

	public CarModelInfo.VariantGroup variantGroup => null;

	public void Init(InitParams initParams)
	{
	}

	private void SetPositionOfBuyButton()
	{
	}

	public void ShowMessage(string message, float duration)
	{
	}

	private IEnumerator DoShowMessage(string message, float duration)
	{
		return null;
	}

	private IEnumerator ScaleFromTo(Transform transform, float from, float to, float duration, EasingEquation easing)
	{
		return null;
	}

	public void HideMessageInstant()
	{
	}

	private void Update()
	{
	}

	private IEnumerator DoClickAnimation()
	{
		return null;
	}

	public void HideButton()
	{
	}

	public void ButtonCallback_OnClick()
	{
	}
}
