using System;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyPurchaseDialogEconomyPrefab : MonoBehaviour
{
	[Serializable]
	public class NamedVisualConfig
	{
		public CurrencyPurchaseDialogEconomyVisualConfig visualConfig;

		public CurrencyType currency;

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
	private List<NamedVisualConfig> visualConfigs;

	public void Init(OffersDB.OfferConfig config)
	{
	}
}
