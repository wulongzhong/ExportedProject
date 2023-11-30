using System;
using System.Collections.Generic;
using GGMatch3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GiftBoxScreenGiftItem : MonoBehaviour
{
	[Serializable]
	public class GiftTypeStyle
	{
		[SerializeField]
		private GiftBoxScreen.GiftType giftType;

		[SerializeField]
		private PowerupType powerupType;

		[SerializeField]
		private BoosterType boosterType;

		[SerializeField]
		private ChipType chipTypeUsedForRepresentation;

		[SerializeField]
		private Image imageRepresentation;

		[SerializeField]
		private VisualStyleSet style;

		public TextMeshProUGUI label;

		public bool isApplicable(GiftBoxScreen.Gift gift)
		{
			return false;
		}

		public void Apply()
		{
		}
	}

	[SerializeField]
	private List<Transform> widgetsToHide;

	[SerializeField]
	private List<GiftTypeStyle> giftStyles;

	public void Init(GiftBoxScreen.Gift gift)
	{
	}

	private GiftTypeStyle GetApplicableStyle(GiftBoxScreen.Gift gift)
	{
		return null;
	}
}
