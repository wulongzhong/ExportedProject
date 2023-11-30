using UnityEngine;

namespace GGCloth
{
	public class PointMass
	{
		public Vector3 currentPosition;

		public Vector3 previosPosition;

		public float mass;

		public float dampingFactor;

		public Vector3 acceleration;

		public void SetRestingPostion(Vector3 position)
		{
		}

		public void VerletIntegrate(float deltaTimeMilliseconds, PointWorld world)
		{
		}
	}
}
