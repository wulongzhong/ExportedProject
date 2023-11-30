using System.Collections.Generic;
using UnityEngine;

namespace EVP
{
	public static class CommonTools
	{
		public class BiasLerpContext
		{
			public float lastBias;

			public float lastExponent;
		}

		private static Dictionary<string, Color> m_colors;

		static CommonTools()
		{
		}

		public static void DrawCrossMark(Vector3 pos, Transform trans, Color col, float length = 0.1f)
		{
		}

		public static float Lin2Log(float val)
		{
			return 0f;
		}

		public static Vector3 Lin2Log(Vector3 val)
		{
			return default(Vector3);
		}

		private static float BiasWithContext(float x, float bias, BiasLerpContext context)
		{
			return 0f;
		}

		public static float BiasedLerp(float x, float bias, BiasLerpContext context)
		{
			return 0f;
		}
	}
}
