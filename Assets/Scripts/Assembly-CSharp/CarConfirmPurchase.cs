using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class CarConfirmPurchase : MonoBehaviour
{
	public struct InitArguments
	{
		public AssembleCarScreen screen;

		public string displayName;

		public Vector3 buttonHandlePosition;

		public CarModelPart carPart;

		public bool showBackground;

		public Action onCancel;

		public Action onDrag;

		public Action<InitArguments> onSuccess;

		public bool updateDirection;

		public bool useDistanceToFindIfInside;

		public bool exactPosition;

		public bool reverse;

		public bool useMinDistanceToConfirm;

		public float minDistance;

		public InputHandler inputHandler;

		public Vector3 directionHandlePosition;

		public GGSoundSystem.SFXType soundFxType;

		public void CallOnDrag()
		{
		}

		public void CallOnCancel()
		{
		}

		public void CallOnSuccess()
		{
		}
	}

	private sealed class _003CDoInAnimation_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarConfirmPurchase _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private ConfirmPurchasePanel.Settings _003Csettings_003E5__3;

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
		public _003CDoInAnimation_003Ed__22(int _003C_003E1__state)
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
	private float distanceOfSourceFromTarget;

	[SerializeField]
	private Transform backgroundClickArea;

	[SerializeField]
	private CarDragButton dragButton;

	[SerializeField]
	public CarDragTarget dragTarget;

	[SerializeField]
	private TextMeshProUGUI dragSourceItemNameText;

	[SerializeField]
	private TextMeshProUGUI dragSourcePriceText;

	[SerializeField]
	private RectTransform arrowTransform;

	[SerializeField]
	private RectTransform constrainRect;

	[SerializeField]
	private RectTransform dragSourceRectTransform;

	[SerializeField]
	private RectTransform scaleParent;

	[SerializeField]
	private RectTransform backgroundSelected;

	[SerializeField]
	private TrailRenderer trailRenderer;

	[SerializeField]
	private RectTransform selectorTransform;

	[NonSerialized]
	private AssembleCarScreen screen;

	private IEnumerator inAnimation;

	private IEnumerator selectorAnimation;

	private InitArguments initArguments;

	private bool isDraging;

	public GGSoundSystem.SFXType currentSfxType => default(GGSoundSystem.SFXType);

	public void Show(InitArguments initArguments)
	{
	}

	private IEnumerator DoInAnimation()
	{
		return null;
	}

	public void OnPurchaseConfirmed()
	{
	}

	private void OnInputHandlerClick(Vector2 position)
	{
	}

	public void OnBackgroundClicked()
	{
	}

	public void OnDragStart()
	{
	}

	public void OnDragEnd()
	{
	}

	public bool IsTargetIn()
	{
		return false;
	}

	public float DistancePercent()
	{
		return 0f;
	}

	public float DistancePercent(Vector3 dragButtonWorldPosition)
	{
		return 0f;
	}

	public bool IsTargetIn(Vector3 dragButtonWorldPosition)
	{
		return false;
	}

	public void OnButtonClick()
	{
	}

	public void OnDrag()
	{
	}

	private void UpdatePositionAndDirection()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}
}
