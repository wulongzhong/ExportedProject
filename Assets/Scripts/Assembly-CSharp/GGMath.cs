using System;
using UnityEngine;

public class GGMath
{
	[Serializable]
	public struct FloatRange
	{
		public float min;

		public float max;

		public float Clamp(float value)
		{
			return 0f;
		}
	}

	[Serializable]
	public struct CssCubicBezier
	{
		public Vector2 p1;

		public Vector2 p2;

		//public CssCubicBezier(float x1, float y1, float x2, float y2)
		//{
		//}

		public float Eval(float t)
		{
			return 0f;
		}
	}

	public static class Ease
	{
		public static CssCubicBezier Linear;

		public static CssCubicBezier EaseInSine;

		public static CssCubicBezier EaseOutSine;

		public static CssCubicBezier EaseInOutSine;

		public static CssCubicBezier EaseInCubic;

		public static CssCubicBezier EaseOutCubic;

		public static CssCubicBezier EaseInOutCubic;
	}

	public static Vector2 CubicBezier(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, float t)
	{
		return default(Vector2);
	}
}
