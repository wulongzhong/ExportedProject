using System;
using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class PowerupsPanel : MonoBehaviour
{
	[SerializeField]
	private ComponentPool powerupsPool;

	[SerializeField]
	private RectTransform container;

	[NonSerialized]
	public GameScreen gameScreen;

	[NonSerialized]
	private List<PowerupsPanelPowerup> powerups;

	public void Refresh()
	{
	}

	public void ShowArrowsOnAvailablePowerups()
	{
	}

	public void ReinitPowerups()
	{
	}

	public void Init(GameScreen gameScreen)
	{
	}

	private void OnEnable()
	{
	}
}
