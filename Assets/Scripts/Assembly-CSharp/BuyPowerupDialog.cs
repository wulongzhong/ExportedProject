using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuyPowerupDialog : MonoBehaviour
{
	[Serializable]
	private class PowerupDefinition
	{
		public PowerupType powerupType;

		public RectTransform container;

		public void Show()
		{
		}
	}

	public struct InitArguments
	{
		public PowerupsDB.PowerupDefinition powerup;

		public Action<bool> onSuccess;

		public PowerupType powerupType => default(PowerupType);
	}

	[SerializeField]
	private TextMeshProUGUI titleLabel;

	[SerializeField]
	private TextMeshProUGUI descriptionLabel;

	[SerializeField]
	private TextMeshProUGUI priceLabel;

	[SerializeField]
	private TextMeshProUGUI quantityLabel;

	[SerializeField]
	private List<RectTransform> widgetsToHide;

	[SerializeField]
	private List<PowerupDefinition> powerups;

	private InitArguments initArguments;

	public static BuyPowerupDialog instance => null;

	public static void Show(InitArguments initArguments)
	{
	}

	public void Hide()
	{
	}

	public void Init(InitArguments initArguments)
	{
	}

	private PowerupDefinition GetDefinition(PowerupType powerupType)
	{
		return null;
	}

	private void OnComplete(bool success)
	{
	}

	public void ButtonCallback_OnPressed()
	{
	}

	public void ButtonCallback_OnHide()
	{
	}
}
