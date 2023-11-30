namespace GGCloth
{
	public class PointPositionConstraint : Constraint
	{
		public enum Direction
		{
			X = 0,
			Y = 1,
			XY = 2
		}

		public PointMass point;

		public PointMass pointToConstrainBy;

		public float minDistance;

		private int initialXSign;

		private int initialYSign;

		public Direction constrainDirection;

		public void Init(PointMass point, PointMass pointToConstrainBy, Direction constrainDirection)
		{
		}

		public override void Solve(PointWorld fieldWorld)
		{
		}
	}
}
