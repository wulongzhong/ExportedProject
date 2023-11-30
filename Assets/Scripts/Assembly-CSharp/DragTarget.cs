using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragTarget : MonoBehaviour
{
	private Camera uiCamera_;

	[SerializeField]
	private Image image;

	private ConfirmPurchasePanel panel;

	private Camera uiCamera => null;

	public void Init(ConfirmPurchasePanel panel, Sprite sprite)
	{
	}

	public void OnDrop(BaseEventData data)
	{
	}
}
