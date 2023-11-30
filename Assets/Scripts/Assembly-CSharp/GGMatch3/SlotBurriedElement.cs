namespace GGMatch3
{
	public class SlotBurriedElement : SlotComponent
	{
		public LevelDefinition.BurriedElement elementDefinition;

		public override bool isBlockingChip => false;

		public override bool isDestroyedByMatchingNextTo => false;

		public override int blockerLevel => 0;

		public override int sortingOrder => 0;

		public BurriedElementBehaviour burriedElementBehaviour => null;

		public override bool isMovingWithConveyor => false;

		public void Init(LevelDefinition.BurriedElement elementDefinition)
		{
		}

		public override void AddToGoalsAtStart(Match3Goals goals)
		{
		}

		public override bool IsCompatibleWithPickupGoal(Match3Goals.ChipTypeDef chipTypeDef)
		{
			return false;
		}

		public override SlotDestroyResolution OnDestroySlotComponent(SlotDestroyParams destroyParams)
		{
			return default(SlotDestroyResolution);
		}
	}
}
