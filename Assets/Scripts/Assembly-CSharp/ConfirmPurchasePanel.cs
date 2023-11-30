using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class ConfirmPurchasePanel : MonoBehaviour
{
	[Serializable]
	public class Settings
	{
		public AnimationCurve curve;

		public float zoomInDuration;

		public float zoomInFactor;

		public float moveTowardsFactor;

		public float zoomOutDuration;

		public AnimationCurve outCurve;

		public float inAnimationDuration;

		public Vector3 inAnimationZoomFrom;

		public Vector3 inAnimationZoomTo;

		public AnimationCurve inAnimationzoomAnimationCurve;

		public float selectorAnimationDuration;

		public Vector3 selectorAnimationZoomFrom;

		public float selectorAnimationAlphaFrom;

		public AnimationCurve selectorAnimationCurve;
	}

	[Serializable]
	public class NamedSprites
	{
		public string name;

		public Sprite iconSprite;

		public Sprite backgroundSprite;
	}

	private sealed class _003CDoInAnimation_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool showTutorial;

		public ConfirmPurchasePanel _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private Settings _003Csettings_003E5__3;

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
		public _003CDoInAnimation_003Ed__24(int _003C_003E1__state)
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

	private sealed class _003CDoSelectorAnimation_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ConfirmPurchasePanel _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private Settings _003Csettings_003E5__3;

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
		public _003CDoSelectorAnimation_003Ed__26(int _003C_003E1__state)
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
	private Vector3 centerPositionForTarget;

	[SerializeField]
	private Vector3 falloffDistanceForTarget;

	private DecorateRoomSceneVisualItem visualItem;

	private DecorateRoomScreen screen;

	[SerializeField]
	private DragButton dragButton;

	[SerializeField]
	public DragTarget dragTarget;

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
	private List<NamedSprites> iconSprites;

	[SerializeField]
	private RectTransform backgroundSelected;

	[SerializeField]
	private TrailRenderer trailRenderer;

	[SerializeField]
	private RectTransform selectorTransform;

	private IEnumerator inAnimation;

	private IEnumerator selectorAnimation;

	private bool showTutorialHand;

	public Settings settings => null;

	public void Show(DecorateRoomSceneVisualItem visualItem, DecorateRoomScreen screen)
	{
	}

	private IEnumerator DoInAnimation(bool showTutorial)
	{
		return null;
	}

	private void ShowTutorialHandIfNeeded()
	{
	}

	private IEnumerator DoSelectorAnimation()
	{
		return null;
	}

	private void Update()
	{
	}

	public void OnPurchaseConfirmed()
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
}
