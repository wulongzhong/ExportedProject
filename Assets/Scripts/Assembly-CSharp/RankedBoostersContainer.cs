using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankedBoostersContainer : MonoBehaviour
{
	[Serializable]
	public class Booster
	{
		[SerializeField]
		private Transform container;

		[SerializeField]
		private List<Image> images;

		public void SetImages(GiftsDefinitionDB.BuildupBooster.BoosterGift booster)
		{
		}

		public void SetActive(bool active)
		{
		}
	}

	[SerializeField]
	private List<Booster> boosters;

	[SerializeField]
	private Transform mainContainer;

	public void Init(int rankLevel)
	{
	}
}
