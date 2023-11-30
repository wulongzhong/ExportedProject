using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBoltTransformTrackerScript : MonoBehaviour
	{
		public LightningBoltPrefabScript LightningScript;

		public Transform StartTarget;

		public Transform EndTarget;

		public RangeOfFloats ScaleLimit;

		private readonly Dictionary<Transform, LightningCustomTransformStateInfo> transformStartPositions;

		private void Start()
		{
		}

		private static float AngleBetweenVector2(Vector2 vec1, Vector2 vec2)
		{
			return 0f;
		}

		private static void UpdateTransform(LightningCustomTransformStateInfo state, LightningBoltPrefabScript script, RangeOfFloats scaleLimit)
		{
		}

		public void CustomTransformHandler(LightningCustomTransformStateInfo state)
		{
		}
	}
}
