using System.Collections.Generic;

namespace GGMatch3
{
	public struct Gravity
	{
		public struct SandflowDirection
		{
			public IntVector2 direction;

			public IntVector2 offset;

			public IntVector2 forceDirection;

			//public SandflowDirection(IntVector2 direction, IntVector2 forceDirection)
			//{
			//}
		}

		public bool up;

		public bool down;

		public bool left;

		public bool right;

		private List<IntVector2> orthoDirections_;

		private List<IntVector2> directions_;

		private List<SandflowDirection> sandflowDirections_;

		public List<IntVector2> orthoDirections => null;

		public List<IntVector2> forceDirections => null;

		public List<SandflowDirection> sandflowDirections => null;

		public List<Slot> FindSlotsToWhichCanJumpTo(Slot origin, Match3Game game)
		{
			return null;
		}
	}
}
