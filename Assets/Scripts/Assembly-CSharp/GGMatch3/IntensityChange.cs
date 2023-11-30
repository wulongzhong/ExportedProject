using System;

namespace GGMatch3
{
	[Serializable]
	public struct IntensityChange
	{
		public float delay;

		public FloatRange intensityRange;

		public GGMath.CssCubicBezier easeCurve;

		public float duration;

		public IntensityChange IntensityRange(float min, float max)
		{
			return default(IntensityChange);
		}

		public float Intensity(float t)
		{
			return 0f;
		}

		public IntensityChange Duration(float duration)
		{
			return default(IntensityChange);
		}

		public IntensityChange Delay(float delay)
		{
			return default(IntensityChange);
		}

		public IntensityChange EaseCurve(GGMath.CssCubicBezier easeCurve)
		{
			return default(IntensityChange);
		}
	}
}
