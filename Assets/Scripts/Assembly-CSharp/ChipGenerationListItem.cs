using System;
using GGMatch3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChipGenerationListItem : MonoBehaviour
{
	[SerializeField]
	private Image image;

	[SerializeField]
	private TextMeshProUGUI countLabel;

	[NonSerialized]
	private LevelDefinition.ChipGenerationSettings.ChipSetting chipSetting;

	public void Init(LevelDefinition.ChipGenerationSettings.ChipSetting chipSetting)
	{
	}

	private void UpdateLook()
	{
	}

	public void ButtonCallback_OnAdd()
	{
	}

	public void ButtonCallback_OnSubtract()
	{
	}
}
