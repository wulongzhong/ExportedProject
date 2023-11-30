using System;
using GGMatch3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelSettingsDialog : MonoBehaviour
{
	public class InitParams
	{
		public LevelDefinition level;

		public Action<LevelSettingsDialog, bool> onComplete;
	}

	public enum PresetType
	{
		Clear = 0,
		OnlyColors_4 = 1,
		OnlyColors_5 = 2,
		OnlyColors_6 = 3,
		ColorWithBunny_4 = 4,
		ColorWithBunny_5 = 5
	}

	[SerializeField]
	private TextMeshProUGUI chipCountLabel;

	[SerializeField]
	private ComponentPool itemsPool;

	[SerializeField]
	private RectTransform container;

	[SerializeField]
	private RectTransform addButton;

	[SerializeField]
	private ScrollRect scrollrect;

	[NonSerialized]
	private InitParams initParams;

	public LevelDefinition level => null;

	private LevelDefinition.ChipGenerationSettings generationSettings => null;

	public static LevelSettingsDialog instance => null;

	public void Show(InitParams initParams)
	{
	}

	private void Init(InitParams initParams)
	{
	}

	public void UpdateUI()
	{
	}

	public void DeleteChip(LevelSettingsDialogChipPercent chipPercent)
	{
	}

	public void ButtonCallback_Select4Chips()
	{
	}

	public void ButtonCallback_Select5Chips()
	{
	}

	private OpenListDialog.ListItem ChipListItem(PresetType presetType)
	{
		return default(OpenListDialog.ListItem);
	}

	private void OnPresetSeleceted(OpenListDialog.DialogResult result)
	{
	}

	public void ButtonCallback_OnPresets()
	{
	}

	public void ButtonCallback_OnOk()
	{
	}

	public void ButtonCallback_OnAddChip()
	{
	}
}
