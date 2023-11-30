using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class MatchChipAffector : ChipAffectorBase
{
	public class InitArguments
	{
		public bool cameFromPositionSet;

		public IntVector2 cameFromPosition;

		public Chip otherChipToMove;

		public Match3Game game;

		public Slot originSlot;

		public bool isCreatingPowerup;

		public List<Slot> matchingSlots;

		public List<Slot> ignoreSlots;

		public bool ShouldIgnore(Slot slot)
		{
			return false;
		}
	}

	private float angle;

	private InitArguments arguments;

	public List<LightingBolt> bolts;

	private static IntVector2[] directionsDiagonal;

	private static IntVector2[] directions;

	private float duration;

	private TransformBehaviour moveBehaviour;

	private TransformBehaviour otherChipMoveBehaviour;

	private static List<Slot> slotsAffectedByExplosion;

	public override void AddToInputAffectorExport(Match3Game.InputAffectorExport inputAffector)
	{
	}

	public override void GiveLightingBoltsTo(List<LightingBolt> destinationBolts)
	{
	}

	public void Init(InitArguments initArguments)
	{
	}

	private void ShowBolts(bool show)
	{
	}

	private void SetBrightness(float brightness)
	{
	}

	private void UpdateMoveBehaviour(float n)
	{
	}

	public override void Clear()
	{
	}

	public override void OnAfterDestroy()
	{
	}

	public override void Update()
	{
	}

	private void ApplyShake(Slot slot, Vector3 startLocalPosition)
	{
	}
}
