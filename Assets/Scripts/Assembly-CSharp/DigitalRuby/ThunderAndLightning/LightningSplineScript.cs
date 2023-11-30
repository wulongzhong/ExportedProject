using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningSplineScript : LightningBoltPathScriptBase
	{
		public const int MaxSplineGenerations = 5;

		public float DistancePerSegmentHint;

		private readonly List<Vector3> prevSourcePoints;

		private readonly List<Vector3> sourcePoints;

		private List<Vector3> savedSplinePoints;

		private int previousGenerations;

		private float previousDistancePerSegment;

		private bool SourceChanged()
		{
			return false;
		}

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}

		protected override LightningBoltParameters OnCreateParameters()
		{
			return null;
		}

		public void Trigger(List<Vector3> points, bool spline)
		{
		}

		public static void PopulateSpline(List<Vector3> splinePoints, List<Vector3> sourcePoints, int generations, float distancePerSegmentHit, Camera camera)
		{
		}
	}
}
