using System.Collections.Generic;

namespace GGMatch3
{
	public class DiscoChipCombineWithPowerupAffector : ChipAffectorBase
	{
		public class ExecuteAction : Match3Game.IAffectorExportAction
		{
			public struct InitArguments
			{
				public Match3Game game;

				public Slot originSlot;

				public Slot powerupSlot;

				public List<BoltSlot> boltSlots;
			}

			private InitArguments initArguments;

			public void Init(InitArguments initArguments)
			{
			}

			public void Execute()
			{
			}

			public void OnCancel()
			{
			}
		}

		public class DistanceLight : LightSlotComponent.PermanentLight
		{
			public float intensityMult;

			public DiscoBallAffector.Settings settings => null;

			public override float GetCurrentIntensity(LightSlotComponent component)
			{
				return 0f;
			}
		}

		public class BoltSlot
		{
			public float delay;

			public Slot slot;

			public LightingBolt bolt;

			public BoardAction action;

			public bool shouldReplace;

			public bool isReplaced;

			public bool isNotReplaced => false;
		}

		private Slot originSlot;

		private Slot otherSlot;

		private ChipType bombType;

		private DistanceLight distanceLight;

		private float angle;

		private float timeActive;

		private Match3Game game;

		public List<Slot> affectedSlots;

		public List<LightingBolt> bolts;

		private FlyingSaucerBehaviour saucerBehaviour;

		public List<BoltSlot> boltSlots;

		private float time;

		public DiscoBallAffector.Settings settings => null;

		public override bool canFinish => false;

		public override void Clear()
		{
		}

		public override void AddToInputAffectorExport(Match3Game.InputAffectorExport inputAffector)
		{
		}

		public void Init(Slot originSlot, Slot powerupSlot, ChipType bombType, Match3Game game, List<Slot> slots)
		{
		}

		private void UpdateIntensity()
		{
		}

		public override void Update()
		{
		}

		private void ReplaceChipWithPowerup(BoltSlot boltSlot)
		{
		}

		public void UpdateCombine()
		{
		}
	}
}
