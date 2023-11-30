using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DailyGiftsScreenGiftCard : MonoBehaviour
{
	[SerializeField]
	private RectTransform gift;

	[SerializeField]
	private TextMeshProUGUI label;

	[SerializeField]
	private List<Transform> widgetsToHide;

	[SerializeField]
	private VisualStyleSet selectedStyle;

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private float alphaWenNotSelected;

	public void Init(int giftIndex, float giftScale, bool isSelected)
	{
	}
}
