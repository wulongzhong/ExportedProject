using System;
using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class BuyMovesPricesConfig : ScriptableObjectSingleton<BuyMovesPricesConfig>
{
	[Serializable]
	public class OfferConfig
	{
		[Serializable]
		public class PowerupDefinition
		{
			public ChipType powerupType;

			public int count;
		}

		public int movesCount;

		public SingleCurrencyPrice price;

		public List<PowerupDefinition> powerups;
	}

	[SerializeField]
	private List<OfferConfig> offers;

	public OfferConfig GetOffer(int index)
	{
		return null;
	}

	public OfferConfig GetOffer(GameScreen.StageState state)
	{
		return null;
	}

	public BuyMovesPricesConfig()
	{
		//((ScriptableObjectSingleton<>)(object)this)._002Ector();
	}
}
