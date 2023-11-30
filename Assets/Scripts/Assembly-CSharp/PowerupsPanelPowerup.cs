using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PowerupsPanelPowerup : MonoBehaviour
{
	[Serializable]
	public class PowerupDefinition
	{
		public PowerupType powerupType;

		public RectTransform container;

		public void Show()
		{
		}
	}

	[Serializable]
	public class ItemStyleSet
	{
		[SerializeField]
		private List<ItemStyle> styleChanges;

		public void Apply()
		{
		}
	}

	[Serializable]
	public class ItemStyle
	{
		[SerializeField]
		private Image image;

		[SerializeField]
		private Color color;

		public void Apply()
		{
		}
	}

	[SerializeField]
	private List<RectTransform> objectsToHide;

	[SerializeField]
	private List<PowerupDefinition> powerups;

	[SerializeField]
	private Transform arrowAnimator;

	[SerializeField]
	private TextMeshProUGUI countLabel;

	[SerializeField]
	private ItemStyleSet activeStyle;

	[SerializeField]
	private ItemStyleSet notActiveStyle;

	[NonSerialized]
	private PowerupsPanel panel;

	[NonSerialized]
	public PowerupsDB.PowerupDefinition powerup;

	public void ShowArrow()
	{
	}

	public void Init(PowerupsDB.PowerupDefinition powerup, PowerupsPanel panel)
	{
	}

	private PowerupDefinition GetDefinition(PowerupsDB.PowerupDefinition powerup)
	{
		return null;
	}

	public void ButtonCallback_OnPressed()
	{
	}
}
