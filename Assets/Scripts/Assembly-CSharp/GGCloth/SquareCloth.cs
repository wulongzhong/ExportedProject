using UnityEngine;

namespace GGCloth
{
	public class SquareCloth
	{
		public Transform localPositionTransform;

		public bool isWorldPosition;

		public float stiffnessRandom;

		public PointWorld pointWorld;

		public int rowCount;

		public int columnCount;

		public float damping;

		public float stiffness;

		public int GetPointIndex(int column, int row)
		{
			return 0;
		}

		public void Init(int columnCount, int rowCount, Vector3 size, float damping, float stiffness, Vector3 globalOffset)
		{
		}

		private void AddSpring(int column1, int row1, int column2, int row2)
		{
		}

		private void AddPositionConstraint(int column1, int row1, int column2, int row2, PointPositionConstraint.Direction direction)
		{
		}
	}
}
