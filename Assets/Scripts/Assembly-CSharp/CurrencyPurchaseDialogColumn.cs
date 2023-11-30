using System.Collections.Generic;
using UnityEngine;

public class CurrencyPurchaseDialogColumn : MonoBehaviour
{
	[SerializeField]
	private RectTransform parent;

	[SerializeField]
	private RectTransform containingRectangle;

	public Vector2 GetSize()
	{
		return default(Vector2);
	}

	public void Init(List<RectTransform> items)
	{
	}
}
