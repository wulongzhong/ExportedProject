using System.Collections.Generic;

namespace GGMatch3
{
	public class DiscoChipAffector : ChipAffectorBase
	{
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

			public List<LightingBolt> neighbourBolts;
		}

		private Slot originSlot;

		private Slot otherSlot;

		private DistanceLight distanceLight;

		private float angle;

		private float timeActive;

		private Match3Game game;

		public List<Slot> affectedSlots;

		public List<LightingBolt> bolts;

		public List<BoltSlot> boltSlots;

		private float time;

		private FlyingSaucerBehaviour saucerBehaviour;

		public DiscoBallAffector.Settings settings => null;

		public override void Clear()
		{
		}

		public void Init(Slot originSlot, Slot otherSlot, Match3Game game)
		{
		}

		public void Init(Slot originSlot, Match3Game game, List<Slot> slots, ItemColor itemColor)
		{
		}

		private void SetActive(List<LightingBolt> bolts, bool active)
		{
		}

		private void UpdateIntensity()
		{
		}

		public override void Update()
		{
		}

		public void UpdateCombine()
		{
		}
	}
}
