using System;
using UnityEngine;

namespace GGMatch3
{
	public class WobbleAnimation
	{
		[Serializable]
		public class Settings
		{
			public float startScale;

			public float endScale;

			public bool directDriveScaleCurve;

			public AnimationCurve scaleCurve;

			public float duration;
		}

		private float time;

		private Settings settings;

		private TransformBehaviour transform;

		public bool isActive => false;

		public Vector3 scale => default(Vector3);

		public void Init(Settings settings, TransformBehaviour transform)
		{
		}

		public void Update(float deltaTime)
		{
		}
	}
}
