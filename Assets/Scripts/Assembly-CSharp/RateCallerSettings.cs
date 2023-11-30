using System;
using System.Collections.Generic;
using ProtoModels;
using UnityEngine;

public class RateCallerSettings : ScriptableObjectSingleton<RateCallerSettings>
{
	[Serializable]
	public class RateIntervalConfig
	{
		[SerializeField]
		private int _levelsPassedThreshold;

		public int levelsPassedThreshold => 0;

		public bool ShouldShow(int levelsPassed)
		{
			return false;
		}
	}

	private AppRateDAO model;

	private static string RateFilename;

	[SerializeField]
	private int minStagesBetweenRates;

	[SerializeField]
	private List<RateIntervalConfig> checkIntervals;

	private RateIntervalConfig checkInterval => null;

	public long lastShownTime => 0L;

	public int timesShown => 0;

	public void OnDialogShow()
	{
	}

	public void OnUserRated()
	{
	}

	public void OnUserNotLike()
	{
	}

	public bool ShouldShow(int levelsPassed)
	{
		return false;
	}

	protected override void UpdateData()
	{
	}

	public void ReloadModel()
	{
	}

	public void Save()
	{
	}

	public void Reset()
	{
	}

	public RateCallerSettings()
	{
        //((ScriptableObjectSingleton<>)(object)this)._002Ector();
    }
}
