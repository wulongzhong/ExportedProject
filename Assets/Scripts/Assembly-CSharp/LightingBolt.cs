using System;
using DigitalRuby.ThunderAndLightning;
using GGMatch3;
using UnityEngine;

public class LightingBolt : MonoBehaviour
{
	[SerializeField]
	private LightningBoltPrefabScript bolt;

	[SerializeField]
	private Transform particleTransform;

	[NonSerialized]
	public Slot startSlot;

	[NonSerialized]
	public bool isSlotPositionsSet;

	[NonSerialized]
	public IntVector2 startSlotPosition;

	[NonSerialized]
	public IntVector2 endSlotPosition;

	[NonSerialized]
	public Slot endSlot;

	public void Init(Slot startSlot, Slot endSlot)
	{
	}

	public void SetSlotPositions(IntVector2 startSlotPosition, IntVector2 endSlotPosition)
	{
	}

	public void Init(Vector3 localStart, Vector3 localEnd)
	{
	}

	public void SetEndPositionFromLerp(float n)
	{
	}

	public void SetEndPosition(Vector3 localPosition)
	{
	}

	public void SetStartPosition(Vector3 localPosition)
	{
	}

	public void SetPositionFromSlots()
	{
	}

	public void SetPositionFromChips()
	{
	}

	public void HideParticle()
	{
	}

	public void RemoveFromGame()
	{
	}
}
