using System;

[Serializable]
public class SingleCurrencyPrice
{
	public CurrencyType currency;

	public int cost;

	public SingleCurrencyPrice(int cost, CurrencyType currency)
	{
	}

	public SingleCurrencyPrice()
	{
	}
}
