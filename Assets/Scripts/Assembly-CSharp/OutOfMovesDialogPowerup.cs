using System;
using System.Collections.Generic;
using GGMatch3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OutOfMovesDialogPowerup : MonoBehaviour
{
	[Serializable]
	public class PowerupContainer
	{
		public ChipType powerupType;

		public RectTransform container;

		public Image image;
	}

	[SerializeField]
	private List<RectTransform> widgetsToHide;

	[SerializeField]
	private List<PowerupContainer> powerups;

	[SerializeField]
	private TextMeshProUGUI countLabel;

	public void Init(ChipType powerupType, int powerupCount)
	{
	}
}
