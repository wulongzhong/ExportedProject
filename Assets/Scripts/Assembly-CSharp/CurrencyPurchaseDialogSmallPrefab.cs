using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrencyPurchaseDialogSmallPrefab : MonoBehaviour, InAppBackend.Listener
{
	[SerializeField]
	private bool onlyForShow;

	[SerializeField]
	private List<CurrencyPurchaseDialogEconomyPrefab.NamedVisualConfig> visualConfigs;

	[SerializeField]
	private CurrencyPurchaseDialog screen;

	public OffersDB.ProductDefinition product;

	[SerializeField]
	public TextMeshProUGUI label;

	[SerializeField]
	private CurrencyPrefabAnimation animationIn;

	[SerializeField]
	private CurrencyPrefabAnimation animationOut;

	[SerializeField]
	private CurrencyPrefabAnimation animationClick;

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

	public void ButtonCallback_OnBuyButtonPressed()
	{
	}

	public void NotifyScreenButtonPress()
	{
	}

	public void AnimateIn(float delay)
	{
	}

	public void AnimateOut(float delay)
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
