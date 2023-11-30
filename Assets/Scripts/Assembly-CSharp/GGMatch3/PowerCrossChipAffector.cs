using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	public class PowerCrossChipAffector : ChipAffectorBase
	{
		public Slot originSlot;

		public List<Slot> affectedSlots;

		public List<LightingBolt> bolts;

		private Match3Game game;

		private int radius;

		private float angle;

		private float affectorDuration;

		private PowerCrossAffector.Settings settings => null;

		public override void Clear()
		{
		}

		public override void AddToInputAffectorExport(Match3Game.InputAffectorExport inputAffector)
		{
		}

		public void Init(Slot originSlot, Match3Game game, int radius)
		{
		}

		public override void Update()
		{
		}

		private void ApplyShake(Slot slot, Vector3 startLocalPosition)
		{
		}
	}
}
