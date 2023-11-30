using System;
using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class GiftsDefinitionDB : ScriptableObjectSingleton<GiftsDefinitionDB>
{
	[Serializable]
	public class BuildupBooster
	{
		[Serializable]
		public class BoosterGift
		{
			public int totalGamesWonInARow;

			[NonSerialized]
			public int level;

			public List<BoosterConfig> boosterConfig;
		}

		[SerializeField]
		private bool isEnabled;

		[SerializeField]
		private int minStageBeforeEnabled;

		[SerializeField]
		private List<BoosterGift> boosters;

		public int CurrentBoosterLevel(MainConfig config)
		{
			return 0;
		}

		public BoosterGift GetBoosterGiftForLevel(int level)
		{
			return null;
		}

		public BoosterGift GetBoosterGift(MainConfig config)
		{
			return null;
		}
	}

	[Serializable]
	public class GiftDefinition
	{
		[SerializeField]
		private int stagesPassedToGive;

		public GiftBoxScreen.GiftsDefinition gifts;

		[NonSerialized]
		private int previousStagePassedToGive;

		[NonSerialized]
		public int totalStagesPassedToGive;

		[NonSerialized]
		private GiftsDefinitionDB db;

		public void ClaimGifts()
		{
		}

		public float Progress(MainConfig config)
		{
			return 0f;
		}

		public bool IsAvailableToCollect(MainConfig config)
		{
			return false;
		}

		public void Init(GiftsDefinitionDB db, GiftDefinition previousGift)
		{
		}
	}

	public struct CombinedGifts
	{
		public int bombCount;

		public int discoCount;

		public int rocketCount;

		public int hammerCount;

		public int powerHammerCount;

		public int coinsCount;
	}

	[Serializable]
	public class DailyGifts
	{
		[Serializable]
		public class DailyGift
		{
			[NonSerialized]
			public int index;

			[SerializeField]
			public GiftBoxScreen.GiftsDefinition gifts;
		}

		[SerializeField]
		private int hoursTillDailyCoinsAvailable;

		[SerializeField]
		private List<DailyGift> gifts;

		private int currentGiftIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public DailyGift currentDailyGift => null;

		public bool IsSelected(int index)
		{
			return false;
		}

		public void Init()
		{
		}

		public void OnClaimedDailyCoins()
		{
		}
	}

	[SerializeField]
	private List<GiftDefinition> gifts;

	[SerializeField]
	public DailyGifts dailyGifts;

	private List<GiftDefinition> giftsToStage;

	[SerializeField]
	public BuildupBooster buildupBooster;

	public int lastStageWhenGivenGift
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public GiftDefinition currentGift => null;

	public CombinedGifts GetCombinedGiftsTillStage(int stageIndex)
	{
		return default(CombinedGifts);
	}

	public List<GiftDefinition> GiftsTillStage(int stageIndex)
	{
		return null;
	}

	public CombinedGifts GetCombinedGifts(List<GiftDefinition> gifts)
	{
		return default(CombinedGifts);
	}

	protected void ClaimGift(int stagePassedToGive)
	{
	}

	protected override void UpdateData()
	{
	}

	public GiftsDefinitionDB()
	{
        //((ScriptableObjectSingleton<>)(object)this)._002Ector();
    }
}
