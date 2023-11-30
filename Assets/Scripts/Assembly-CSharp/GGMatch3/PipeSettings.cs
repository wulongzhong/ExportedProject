using System;
using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	[Serializable]
	public class PipeSettings
	{
		[Serializable]
		public class ColorSettings
		{
			public Color color;
		}

		public float gravity;

		public float maxVelocity;

		public float minVelocity;

		public float maxContinueVelocity;

		public float scale;

		public float orthoScale;

		public float pipeScale;

		public Vector3 offsetPosition;

		public AnimationCurve offsetCurve;

		public List<ColorSettings> colorSettings;

		public Color GetColor(int index)
		{
			return default(Color);
		}
	}
}
