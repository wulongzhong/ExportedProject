using System;
using System.Collections.Generic;
using UnityEngine;

namespace JSONData
{
	[Serializable]
	public class ShapeGraphShape
	{
		public enum Orientation
		{
			CCW = 0,
			CW = 1
		}

		public List<Vector2> points;

		public Orientation GetOrientation()
		{
			return default(Orientation);
		}

		public bool IsInside(Vector2 pos)
		{
			return false;
		}
	}
}
