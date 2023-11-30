using System.Collections.Generic;
using UnityEngine;

namespace GGCloth
{
	public class PointWorld
	{
		private List<PointMass> points;

		private List<Constraint> constraints;

		public float fixedTimeStepMilliseconds;

		private float leftOverTimeMS;

		public int constraintRelaxationSteps;

		public Vector3 gravityMS;

		public List<PointMass> Points => null;

		public void SetGravity(Vector3 gravity)
		{
		}

		public void Clear()
		{
		}

		public PointMass GetPoint(int index)
		{
			return null;
		}

		public void AddPoint(PointMass point)
		{
		}

		public void Prepend(Constraint constraint)
		{
		}

		public void AddConstraint(Constraint constraint)
		{
		}

		public void Step(float deltaTime)
		{
		}

		private void VerletIntegrate()
		{
		}

		private void SatisfyConstraints()
		{
		}
	}
}
