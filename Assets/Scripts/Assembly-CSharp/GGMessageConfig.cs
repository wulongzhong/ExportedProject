using System;
using System.Collections.Generic;
using UnityEngine;

public class GGMessageConfig : ScriptableObject
{
	[Serializable]
	public enum FbObjectType
	{
		EnergyGift = 0,
		CoinGift = 1,
		DollarGift = 2,
		CinemaTrip = 3,
		None = 4
	}

	[Serializable]
	public class FacebookGiftObject
	{
		public FbObjectType objectType;

		public string objectId;

		public string message;

		public float popularityBoost;

		public float moodBoost;

		public int coinCost;
	}

	private static GGMessageConfig instance_;

	public List<FacebookGiftObject> giftDefinitions;

	public static GGMessageConfig instance => null;

	public FacebookGiftObject GetGiftForType(FbObjectType type)
	{
		return null;
	}
}
