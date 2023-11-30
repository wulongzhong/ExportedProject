using System;
using System.Collections.Generic;
using GGMatch3;
using UnityEngine;
using UnityEngine.UI;

public class PreGameDialogBoosterPrefab : MonoBehaviour
{
	public class BoosterDefinition
	{
		public BoosterConfig config;

		public bool active;
	}

	[Serializable]
	public class NamedSprite
	{
		public PreGameDialogBoosterPrefabVisualConfig visualConfig;

		public BoosterType type;

		public ChipType chipTypeUsedForRepresentation;

		public bool IsMatching(BoosterDefinition booster)
		{
			return false;
		}

		public void SetActive(bool active)
		{
		}

		public void SetLabel(string text)
		{
		}

		public void SetStyle(bool owned)
		{
		}
	}

	[SerializeField]
	private Image activeImage;

	[SerializeField]
	public List<RectTransform> widgetsToHide;

	[SerializeField]
	public List<NamedSprite> namedSprites;

	[SerializeField]
	private Transform arrowAnimation;

	[SerializeField]
	private PowerupsPanelPowerup.ItemStyleSet activeStyle;

	[SerializeField]
	private PowerupsPanelPowerup.ItemStyleSet notActiveStyle;

	private PreGameDialog screen;

	private BoosterDefinition booster;

	public void Init(BoosterConfig boosterConfig, PreGameDialog screen, bool resetSelection = false)
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public BoosterConfig GetBooster()
	{
		return null;
	}

	public void ButtonCallback_OnClick()
	{
	}
}
