using System;
using GGMatch3;

public class PlayerInventory
{
	public enum Item
	{
		EasyModeItem = 0,
		MediumModeItem = 1,
		HardModeItem = 2,
		NoAds = 3,
		Trainer = 4,
		FreeEnergy = 5,
		FreeEnergyLimited = 6
	}

	private static PlayerInventory instance_;

	private OwnedItems _003Cowned_003Ek__BackingField;

	public static PlayerInventory instance => null;

	public OwnedItems owned
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public void BuyItem(Item item, bool canStockpile)
	{
	}

	private string PowerupId(PowerupType powerupType)
	{
		return null;
	}

	private string BoosterId(BoosterType boosterType)
	{
		return null;
	}

	public long UsedCount(PowerupType powerupType)
	{
		return 0L;
	}

	public long SetUsedCount(PowerupType powerupType, long count)
	{
		return 0L;
	}

	public long OwnedCount(PowerupType powerupType)
	{
		return 0L;
	}

	public void Add(PowerupType powerupType, int amount)
	{
	}

	public void BuyTimedItem(Item item, TimeSpan duration)
	{
	}

	public void SetOwned(PowerupType powerupType, long ownedNumber)
	{
	}

	public long OwnedCount(BoosterType boosterType)
	{
		return 0L;
	}

	public long UsedCount(BoosterType boosterType)
	{
		return 0L;
	}

	public void SetUsedCount(BoosterType boosterType, long count)
	{
	}

	public void Add(BoosterType boosterType, int amount)
	{
	}

	public void SetOwned(BoosterType boosterType, long ownedNumber)
	{
	}

	public bool IsOwned(string name)
	{
		return false;
	}
}
