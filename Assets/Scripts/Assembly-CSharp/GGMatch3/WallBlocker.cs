namespace GGMatch3
{
	public class WallBlocker : SlotComponent
	{
		private IntVector2 blockDirection;

		public override bool isMovingWithConveyor => false;

		public void Init(IntVector2 direction)
		{
		}

		public override bool isBlockingDirection(IntVector2 direction)
		{
			return false;
		}
	}
}
