using System;
using System.Collections.Generic;
using UnityEngine;

public class EnergyControlConfig : ScriptableObject
{
	public enum TimeLimitation
	{
		NotLimited = 0,
		InstallTime = 1,
		ExactTime = 2
	}

	public enum CardPrefabType
	{
		EnergyDrinkPrefab = 0,
		OfferPrefab = 1,
		InAppPurchasePrefab = 2
	}

	[Serializable]
	public class EnergyPackConfig
	{
		public string packID;

		public SingleCurrencyPrice price;

		public int drinkCount;

		public string nameSuffix;

		public string packStyle;

		public string packBckStyle;

		public string labelStyle;

		public int packWidth;

		public CardPrefabType cardPrefabType;

		public string cueName;

		public string cueStyle;

		public TimeLimitation timeLimitation;

		public float durationInDays;

		public string datetimeWhenFirstAvailable;

		public bool canBuyOneTime;

		public bool showDealSticker;

		public string dealStickerText;

		public string inAppName;

		public string centerText;
	}

	[Serializable]
	public class EnergyPackBundle
	{
		public string packName;

		public List<EnergyPackConfig> packs;
	}

	public string energyNotificationsName;

	private static EnergyControlConfig instance_;

	public float maxEnergy;

	public int secondsToRefreshPoint;

	public int totalCoin;

	public SingleCurrencyPrice price;

	public SingleCurrencyPrice freePlay24hPrice;

	public List<EnergyPackBundle> energyPackBundles;

	public static EnergyControlConfig instance => null;

	public int energyPointPerCoin => 0;

	public float CoinsToEnergy(int coins)
	{
		return 0f;
	}

	public float GetEnergyForTimespan(TimeSpan timeSpan)
	{
		return 0f;
	}

	public TimeSpan TimeToGainEnergy(float energyGain)
	{
		return default(TimeSpan);
	}
}
