using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class LineChipAffector : ChipAffectorBase
{
	public List<Slot> affectedSlots;

	public List<LightingBolt> bolts;

	private float affectorDuration;

	private IntVector2 direction;

	private Slot originSlot;

	private float angle;

	private PowerLineAffector.Settings settings => null;

	public override void AddToInputAffectorExport(Match3Game.InputAffectorExport inputAffector)
	{
	}

	public override void Clear()
	{
	}

	public void Init(Slot originSlot, Match3Game game, IntVector2 direction)
	{
	}

	public override void Update()
	{
	}

	private void ApplyShake(Slot slot, Vector3 startLocalPosition)
	{
	}
}
