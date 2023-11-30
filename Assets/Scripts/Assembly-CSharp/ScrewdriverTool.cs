using System;
using UnityEngine;

public class ScrewdriverTool : MonoBehaviour
{
	public struct PressArguments
	{
		public bool isPressed;
	}

	public struct InitArguments
	{
		public Action<PressArguments> onPress;

		public InputHandler inputHandler;

		public CarScene carScene;

		public GGSoundSystem.LoopSFXType soundType;
	}

	[SerializeField]
	private Transform buttonTransform;

	[NonSerialized]
	private InitArguments initArguments;

	[SerializeField]
	private GameObject drillModelPrefab;

	[SerializeField]
	private GameObject welderModelPrefab;

	[NonSerialized]
	private DrillModel drillModel_;

	[NonSerialized]
	private DrillModel welderModel_;

	private GGSoundSystem.LoopSoundFxClip sound;

	public bool isPressed => false;

	public DrillModel GetDrillModel(CarScene carScene)
	{
		return null;
	}

	public DrillModel GetWelderModel(CarScene carScene)
	{
		return null;
	}

	public void Init(InitArguments initArguments)
	{
	}

	public void Hide()
	{
	}

	public void Callback_OnDown()
	{
	}

	public void Callback_OnUp()
	{
	}

	public void StartPlaySound()
	{
	}

	public void StopPlaySound()
	{
	}

	private void Update()
	{
	}
}
