using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CarSprayToolTarget : MonoBehaviour
{
	public struct DragState
	{
		public bool isDragging;

		public Vector3 lastScreenPosition;
	}

	[SerializeField]
	private ParticleSystem sprayParticleSystem;

	[SerializeField]
	private List<Transform> widgetsToHide;

	[SerializeField]
	private VisualStyleSet notPressedStyle;

	[SerializeField]
	private VisualStyleSet pressedStyle;

	[SerializeField]
	public RectTransform sizeOffsetTransform;

	private Camera uiCamera_;

	private Action<Vector3> onDrag;

	[NonSerialized]
	public DragState dragState;

	private CarSprayTool tool;

	public Camera uiCamera => null;

	public void Init(Action<Vector3> onDrag, CarSprayTool tool)
	{
	}

	public void OnPress(BaseEventData data)
	{
	}

	public void OnRelease(BaseEventData data)
	{
	}

	public void OnBeginDrag(BaseEventData data)
	{
	}

	public void OnEndDrag(BaseEventData data)
	{
	}

	public void OnDrag(BaseEventData data)
	{
	}

	private void SetPosition(PointerEventData pointerData)
	{
	}
}
