using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CarDragTarget : MonoBehaviour
{
	private Camera uiCamera_;

	[SerializeField]
	private Image image;

	private CarConfirmPurchase panel;

	private Camera uiCamera => null;

	public void Init(CarConfirmPurchase panel)
	{
	}

	public void OnDrop(BaseEventData data)
	{
	}
}
