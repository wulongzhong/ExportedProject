using System;
using System.Collections.Generic;
using UnityEngine;

public class LivesPriceConfig : ScriptableObjectSingleton<LivesPriceConfig>
{
	[Serializable]
	public class PriceConfig
	{
		public SingleCurrencyPrice pricePerLife;

		public int levelIndex;

		public SingleCurrencyPrice GetPriceForLives(int lives)
		{
			return null;
		}
	}

	[SerializeField]
	private List<PriceConfig> priceConfigs;

	[SerializeField]
	private PriceConfig defaultConfig;

	public PriceConfig GetPriceForLevelOrDefault(int levelIndex)
	{
		return null;
	}

	public LivesPriceConfig()
	{
        //((ScriptableObjectSingleton<>)(object)this)._002Ector();
    }
}
