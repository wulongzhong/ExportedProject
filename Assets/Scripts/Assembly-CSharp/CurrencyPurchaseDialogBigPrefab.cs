using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyPurchaseDialogBigPrefab : MonoBehaviour, InAppBackend.Listener
{
	[Serializable]
	public class NamedVisualConfig
	{
		public Image image;

		public string name;

		public bool IsMatching(OffersDB.ProductDefinition product)
		{
			return false;
		}

		public void SetActive(bool flag)
		{
		}
	}

	[SerializeField]
	private bool onlyForShow;

	[SerializeField]
	private List<NamedVisualConfig> visualConfigs;

	[SerializeField]
	private NamedVisualConfig defaulVisualConfig;

	[SerializeField]
	private List<TextMeshProUGUI> ribbonLabels;

	[SerializeField]
	private RectTransform infoContainer;

	[SerializeField]
	private RectTransform economyPrefabContainer;

	[SerializeField]
	private RectTransform powerupGroupPrefabContainer;

	[SerializeField]
	private ComponentPool economyPrefabsPool;

	[SerializeField]
	private ComponentPool powerupPrefabsPool;

	[SerializeField]
	private ComponentPool powerupGroupPrefabPool;

	[SerializeField]
	private RectTransform powerupContainer;

	[SerializeField]
	private RectTransform economyContainer;

	[SerializeField]
	private Vector2 offset;

	[SerializeField]
	private int powerupsPerRow;

	public OffersDB.ProductDefinition product;

	[SerializeField]
	private CurrencyPurchaseDialog screen;

	[SerializeField]
	public TextMeshProUGUI priceLabel;

	[SerializeField]
	private CurrencyPrefabAnimation animationIn;

	[SerializeField]
	private CurrencyPrefabAnimation animationOut;

	[SerializeField]
	private CurrencyPrefabAnimation clickAnimation;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnInitialized(InAppBackend.InitializeArguments initializeArguments)
	{
	}

	public void OnPurchase(InAppBackend.PurchaseEventArguments purchaseParams)
	{
	}

	private void UpdatePrice()
	{
	}

	public void Init(OffersDB.ProductDefinition product)
	{
	}

	public List<RectTransform> CreatePowerupPrefabs(List<OffersDB.OfferConfig> configs, int startIndex, int length)
	{
		return null;
	}

	public void ButtonCallback_OnBuyButtonClicked()
	{
	}

	private void NotifyScreenForClick()
	{
	}

	public void AnimateIn(float delay)
	{
	}

	public IEnumerator DoAnimateIn(float delay)
	{
		return null;
	}

	public IEnumerator DoAnimateOut(float delay)
	{
		return null;
	}
}
