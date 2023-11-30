using System;
using System.Collections.Generic;
using ProtoModels;

public class GGPlayerSettings
{
	private PlayerModel model;

	public float overPocketNominationScale;

	private static GGPlayerSettings instance_;

	private WalletManager _003CwalletManager_003Ek__BackingField;

	private bool isSavingSuspended;

	public PlayerModel Model => null;

	public PlayerModel.GivenGiftsData givenGifts => null;

	public bool isMusicOff
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isSoundFXOff
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static GGPlayerSettings instance => null;

	public bool canCloudSync
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public WalletManager walletManager
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public List<PlayerModel.UsageData> usageDataList => null;

	public bool shouldGiveExperience => false;

	public void ResetEverything()
	{
	}

	public void IncreaseSessionCoins(int coinsAmount)
	{
	}

	private GGPlayerSettings()
	{
	}

	private GGPlayerSettings(PlayerModel model)
	{
	}

	public GGPlayerSettings CreateFromData(CloudSyncData fileSystemData)
	{
		return null;
	}

	public int MultiplayerGamesPlayed()
	{
		return 0;
	}

	private void Init()
	{
	}

	public void ReloadModel()
	{
	}

	public void AddPurchase(InAppPurchaseDAO inAppPurchase)
	{
	}

	public bool IsPurchaseConsumed(string token)
	{
		return false;
	}

	public List<InAppPurchaseDAO> GetPurchases()
	{
		return null;
	}

	public string GetName()
	{
		return null;
	}

	public static long GetExperienceToGive(int multiplayerWins, int multiplayerLoses)
	{
		return 0L;
	}

	public void CheckShouldGiveExperience(bool save)
	{
	}

	public void SetName(string name)
	{
	}

	public void Save()
	{
	}

	public void SetEnergy(float energy, DateTime lastTimeTookEnergy)
	{
	}
}
