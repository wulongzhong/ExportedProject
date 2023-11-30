using ProtoModels;

public class WalletManager
{
	public delegate void OnSave();

	private OnSave onSave;

	private PlayerModel model;

	public WalletManager(PlayerModel model, OnSave onSave)
	{
	}

	public void ReloadModel(PlayerModel model)
	{
	}

	private void DoOnSave()
	{
	}

	public void BuyItem(SingleCurrencyPrice price)
	{
	}

	public void BuyItem(int price, CurrencyType currencyType)
	{
	}

	public void BuyItemRuby(int price)
	{
	}

	public void BuyItemDiamonds(int price)
	{
	}

	public void BuyItemCoins(int price)
	{
	}

	public void BuyItemDollars(int price)
	{
	}

	public bool CurrencyHasMax(CurrencyType type)
	{
		return false;
	}

	public int MaxCurrencyCount(CurrencyType type)
	{
		return 0;
	}

	public void AddCurrency(CurrencyType type, int ammount)
	{
	}

	public void SetCurrency(CurrencyType type, int ammount)
	{
	}

	public long CurrencyCount(CurrencyType type)
	{
		return 0L;
	}

	public SingleCurrencyPrice GetMissingAmmount(SingleCurrencyPrice price)
	{
		return null;
	}

	public bool CanBuyItemWithPrice(SingleCurrencyPrice price)
	{
		return false;
	}

	public bool CanBuyItemWithPrice(int price, CurrencyType currencyType)
	{
		return false;
	}

	public bool TooExpensive(SingleCurrencyPrice price)
	{
		return false;
	}
}
