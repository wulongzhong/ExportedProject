using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class BombChipAffector : ChipAffectorBase
{
	public enum PowerupType
	{
		Block = 0,
		Bomb = 1,
		Seeking = 2
	}

	public Slot originSlot;

	public List<Slot> affectedSlots;

	public List<LightingBolt> bolts;

	private Match3Game game;

	private int radius;

	private bool doPlus;

	private float affectorDuration;

	private float angle;

	private SeekingMissleAffector.Settings settings => null;

	public override void Clear()
	{
	}

	public void Init(Slot originSlot, Match3Game game, int radius, bool doPlus, PowerupType powerupType)
	{
	}

	public override void Update()
	{
	}

	private void ApplyShake(Slot slot, Vector3 startLocalPosition)
	{
	}
}
