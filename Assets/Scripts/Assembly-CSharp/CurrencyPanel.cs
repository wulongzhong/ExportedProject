using System.Collections.Generic;
using UnityEngine;

public class CurrencyPanel : MonoBehaviour, InAppBackend.Listener
{
	[SerializeField]
	private List<CurrencyDisplay> currencyDisplays;

	public CurrencyDisplay DisplayForCurrency(CurrencyType currencyType)
	{
		return null;
	}

	public void Show()
	{
	}

	public void OnInitialized(InAppBackend.InitializeArguments initializeArguments)
	{
	}

	public void OnPurchase(InAppBackend.PurchaseEventArguments purchaseParams)
	{
	}

	public void OnEnable()
	{
	}

	public void SetLabels()
	{
	}

	public void Hide()
	{
	}
}
