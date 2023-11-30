namespace GGCloth
{
	public class SpringLink : Constraint
	{
		public PointMass p1;

		public PointMass p2;

		public float stiffness;

		public float restingDistance;

		public void InitWithPointsAtRest(PointMass p1, PointMass p2, float stiffness)
		{
		}

		public override void Solve(PointWorld fieldWorld)
		{
		}
	}
}
