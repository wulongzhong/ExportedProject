using System;
using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class OffersDB : ScriptableObjectSingleton<OffersDB>
{
	[Serializable]
	public class OfferConfig
	{
		public bool useBoosterType;

		public BoosterType boosterType;

		public int count;

		public bool usePrice;

		public SingleCurrencyPrice price;
	}

	[Serializable]
	public class OfferDefinition
	{
		public string name;

		public List<OfferConfig> config;

		public bool isNamedOffer => false;
	}

	[Serializable]
	public class ProductDefinition
	{
		public enum ProductType
		{
			Consumable = 0,
			Permanent = 1
		}

		public string editorName;

		public OfferDefinition offer;

		[SerializeField]
		private string productID;

		[SerializeField]
		private string productID_IOS;

		public ProductType productType;

		public string mocupPrice;

		public bool active;

		public string productIdentifier => null;

		public bool isConsumable => false;

		public void ConsumeProduct()
		{
		}
	}

	public string base64EncodedPublicKey;

	public List<ProductDefinition> products;

	public ProductDefinition GetProduct(string productId)
	{
		return null;
	}

	public OffersDB()
	{
        //((ScriptableObjectSingleton<>)(object)this)._002Ector();
    }
}
