using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[Serializable]
	public class Settings
	{
		public float bobDuration;

		public float bobDisplace;

		public AnimationCurve animationCurve;

		public float pressScale;
	}

	private sealed class _003CDoAnimate_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DragButton _003C_003E4__this;

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
		public _003CDoAnimate_003Ed__16(int _003C_003E1__state)
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

	private Camera uiCamera_;

	[SerializeField]
	private TrailRenderer trailRenderer;

	[SerializeField]
	private RectTransform offsetTransform;

	[SerializeField]
	private RectTransform arrowOffsetTransform;

	private ConfirmPurchasePanel panel;

	private bool dragging;

	private IEnumerator animationEnum;

	private bool isDrag;

	private Camera uiCamera => null;

	public Settings settings => null;

	public void Init(ConfirmPurchasePanel panel, Sprite sprite)
	{
	}

	private void ResetOffsetTransform()
	{
	}

	public void StopAnimation()
	{
	}

	private IEnumerator DoAnimate()
	{
		return null;
	}

	public void OnDragStart(BaseEventData data)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnDrag(BaseEventData data)
	{
	}

	public void OnDragEnd(BaseEventData data)
	{
	}

	private void Update()
	{
	}
}
