using System;
using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class CurrencyPurchaseDialogPowerupPrefab : MonoBehaviour
{
	[Serializable]
	public class NamedVisualConfigs
	{
		public CurrencyPurchaseDialogPowerupVisualConfig visualConfig;

		public BoosterType type;

		public bool IsMatching(OffersDB.OfferConfig config)
		{
			return false;
		}

		public void SetLabel(string text)
		{
		}

		public void SetActive(bool flag)
		{
		}
	}

	[SerializeField]
	private List<NamedVisualConfigs> visualConfigs;

	public void Init(OffersDB.OfferConfig config)
	{
	}
}
