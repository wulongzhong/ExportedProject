using System;
using System.Collections.Generic;
using UnityEngine;

public class PowerupsDB : ScriptableObjectSingleton<PowerupsDB>
{
	[Serializable]
	public class PowerupDefinition
	{
		public PowerupType type;

		public string name;

		public string description;

		public int buyQuanitty;

		public SingleCurrencyPrice buyPrice;

		public long ownedCount
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long usedCount
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}
	}

	[SerializeField]
	public List<PowerupDefinition> powerups;

	public PowerupDefinition Powerup(PowerupType powerupType)
	{
		return null;
	}

	protected override void UpdateData()
	{
	}

	public PowerupsDB()
	{
        //((ScriptableObjectSingleton<>)(object)this)._002Ector();
    }
}
