using System.Collections.Generic;

namespace GGMatch3
{
	public class CombineChipAffectors : ChipAffectorBase
	{
		public class Settings
		{
			public float durationToGetClose;

			public float maxScale;

			public float normalizedClosePosition;
		}

		private CompositeAffector.SwipedSlot swipedSlot;

		private List<LightingBolt> bolts;

		private Match3Game game;

		private float time;

		private Settings settings => null;

		public override void Clear()
		{
		}

		private void Reset(Slot slot)
		{
		}

		public void Init(CompositeAffector.SwipedSlot swipedSlot, Match3Game game)
		{
		}

		public override void Update()
		{
		}
	}
}
