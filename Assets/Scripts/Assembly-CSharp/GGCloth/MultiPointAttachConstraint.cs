using System.Collections.Generic;
using UnityEngine;

namespace GGCloth
{
	public class MultiPointAttachConstraint : Constraint
	{
		public class PointPosition
		{
			public PointMass point;

			public Vector3 localPosition;
		}

		public Vector3 centralPosition;

		public List<PointPosition> points;

		public void Init(Vector3 centralPosition)
		{
		}

		public void FixPoint(PointMass point)
		{
		}

		public override void Solve(PointWorld fieldWorld)
		{
		}
	}
}
