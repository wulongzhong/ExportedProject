using System;
using ProtoModels;

public class EnergyManager : BehaviourSingleton<EnergyManager>
{
	private string freeEnergyString_;

	private string limitedFreeEnergyString_;

	public bool isFullLives => false;

	public int ownedPlayCoins
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float secPerCoin => 0f;

	public float secToNextCoin => 0f;

	private string freeEnergyString => null;

	private string limitedFreeEnergyString => null;

	public bool isUnlimitedInfiniteEnergy => false;

	public bool isFreeEnergy => false;

	public bool isLimitedFreeEnergyActive => false;

	public TimeSpan limitedEnergyTimespanLeft => default(TimeSpan);

	public float MaxEnergy => 0f;

	public float GetCurrentEnergyPercent()
	{
		return 0f;
	}

	public void SpendLifeIfNotFreeEnergy()
	{
	}

	public void AddLifeIfNotFreeEnergy()
	{
	}

	public bool HasEnergyForOneLife()
	{
		return false;
	}

	public void ConsumeCoin(int coinAmount)
	{
	}

	public void AddCoins(int coinAmount)
	{
	}

	public void DebugChangeEnergy(float modifyEnergtPoints)
	{
	}

	public void FillEnergy()
	{
	}

	public void UpdateLimitedEnergy(float passedTimeSec)
	{
	}

	public bool IsActive(OwnedItemDAO owned)
	{
		return false;
	}

	public TimeSpan ActiveTimespanLeft(OwnedItemDAO owned)
	{
		return default(TimeSpan);
	}

	public TimeSpan TimeSpanTillEnergyFull()
	{
		return default(TimeSpan);
	}

	public float GetCurrentEnergyValue()
	{
		return 0f;
	}

	public bool HasEnoughEnergy(float energyNeededToHave)
	{
		return false;
	}

	public void SpendEnergy(float energyToSpend)
	{
	}

	public void SetEnergy(float energy)
	{
	}

	public void GainEnergy(float energyToGain)
	{
	}

	public EnergyManager()
	{
		//((BehaviourSingleton<>)(object)this)._002Ector();
	}
}
