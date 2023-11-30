using System;
using System.Collections.Generic;
using GGMatch3;
using TMPro;
using UnityEngine;

public class PowerupPlacementHandler : MonoBehaviour
{
	[Serializable]
	private class PowerupDefinition
	{
		public PowerupType powerupType;

		public RectTransform container;

		public void Show()
		{
		}
	}

	public struct PlacementCompleteArguments
	{
		public InitArguments initArguments;

		public bool isSuccess;

		public Slot targetSlot;

		public bool isCancel => false;
	}

	public struct InitArguments
	{
		public PowerupsDB.PowerupDefinition powerup;

		public Match3Game game;

		public Action<PlacementCompleteArguments> onComplete;
	}

	private struct State
	{
		public bool isActive;
	}

	[SerializeField]
	private InputHandler inputHandler;

	[SerializeField]
	private List<RectTransform> widgetsToHide;

	[SerializeField]
	private List<PowerupDefinition> powerups;

	[SerializeField]
	private TextMeshProUGUI descriptionLabel;

	private InitArguments initArguments;

	private State state;

	public void Show(InitArguments initArguments)
	{
	}

	private PowerupDefinition GetDefinition(PowerupType powerupType)
	{
		return null;
	}

	private void Hide()
	{
	}

	private void Update()
	{
	}

	private void OnComplete(PlacementCompleteArguments completeArguments)
	{
	}

	private void OnPress(InputHandler.PointerData pointer)
	{
	}
}
