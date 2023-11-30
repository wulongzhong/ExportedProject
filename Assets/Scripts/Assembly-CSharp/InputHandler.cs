using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputHandler : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	public delegate void OnClickDelegate(Vector2 screenPosition);

	public class PointerData
	{
		public int pointerId;

		public Vector2 position;

		public bool isDown;

		public int downFrame;

		public Vector2 startPosition;

		public float downTime;
	}

	[SerializeField]
	private int minDistance;

	[SerializeField]
	private float minTime;

	[SerializeField]
	private int minFrames;

	private List<PointerData> downPointers_;

	private List<PointerData> inputPointers;

	public bool IsAnyDown => false;

	public int NumberOfPointersDown => 0;

	public List<PointerData> DownPointers => null;

	public event OnClickDelegate onClick
	{
		add
		{
		}
		remove
		{
		}
	}

	public void Clear()
	{
	}

	public bool IsUp(int pointerId)
	{
		return false;
	}

	public bool IsDown(int pointerId)
	{
		return false;
	}

	public Vector2 Position(int pointerId)
	{
		return default(Vector2);
	}

	public PointerData FirstDownPointer()
	{
		return null;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	private void UpdateMousePosition(PointerEventData eventData)
	{
	}

	private PointerData GetOrCreatePointerData(int pointerId)
	{
		return null;
	}

	public PointerData GetPointerData(int pointerId)
	{
		return null;
	}

	private PointerData AddPointerData(int pointerId)
	{
		return null;
	}
}
