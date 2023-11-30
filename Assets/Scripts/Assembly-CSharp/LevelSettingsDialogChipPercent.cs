using System;
using GGMatch3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelSettingsDialogChipPercent : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public OpenListDialog.InitParams init;

		public LevelSettingsDialogChipPercent _003C_003E4__this;

		internal void _003CButtonCallback_OnOpenChipType_003Eb__0(OpenListDialog.DialogResult result)
		{
		}
	}

	[SerializeField]
	private Image sprite;

	[SerializeField]
	private TextMeshProUGUI countLabel;

	private LevelDefinition.ChipGenerationSettings.ChipSetting _003CchipSetting_003Ek__BackingField;

	[NonSerialized]
	private LevelSettingsDialog dialog;

	public LevelDefinition.ChipGenerationSettings.ChipSetting chipSetting
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public void Init(LevelDefinition.ChipGenerationSettings.ChipSetting chipSetting, LevelSettingsDialog dialog)
	{
	}

	private void UpdateUI()
	{
	}

	public void ButtonCallback_OnAdd()
	{
	}

	public void ButtonCallback_OnSub()
	{
	}

	public void ButtonCallback_OnDelete()
	{
	}

	public void ButtonCallback_OnOpenChipType()
	{
	}

	private OpenListDialog.ListItem ChipListItem(ChipType chipType, ItemColor itemColor)
	{
		return default(OpenListDialog.ListItem);
	}
}
