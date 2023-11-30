using System;
using UnityEngine;

namespace GGMatch3
{
	[Serializable]
	public struct IntVector2
	{
		public int x;

		public int y;

		public static IntVector2[] upDownLeftRight;

		public static IntVector2[] upDown;

		public static IntVector2[] leftRight;

		public IntVector2 orthogonal => default(IntVector2);

		public static IntVector2 up => default(IntVector2);

		public static IntVector2 down => default(IntVector2);

		public static IntVector2 zero => default(IntVector2);

		public static IntVector2 left => default(IntVector2);

		public static IntVector2 right => default(IntVector2);

		//public IntVector2(int x, int y)
		//{
		//}

		public Vector3 ToVector3()
		{
			return default(Vector3);
		}

		public static IntVector2 operator +(IntVector2 a, IntVector2 b)
		{
			return default(IntVector2);
		}

		public static IntVector2 operator -(IntVector2 a, IntVector2 b)
		{
			return default(IntVector2);
		}

		public static bool operator ==(IntVector2 a, IntVector2 b)
		{
			return false;
		}

		public static IntVector2 operator *(IntVector2 a, int b)
		{
			return default(IntVector2);
		}

		public static IntVector2 operator *(int b, IntVector2 a)
		{
			return default(IntVector2);
		}

		public static bool operator !=(IntVector2 a, IntVector2 b)
		{
			return false;
		}

		public static IntVector2 operator -(IntVector2 a)
		{
			return default(IntVector2);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
