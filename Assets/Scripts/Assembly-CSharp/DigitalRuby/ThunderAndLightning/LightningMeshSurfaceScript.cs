using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningMeshSurfaceScript : LightningBoltPrefabScriptBase
	{
		public MeshFilter MeshFilter;

		public Collider MeshCollider;

		public RangeOfFloats MeshOffsetRange;

		public RangeOfIntegers PathLengthCount;

		public RangeOfFloats MinimumPathDistanceRange;

		public float MaximumPathDistance;

		private float maximumPathDistanceSquared;

		public bool Spline;

		public float DistancePerSegmentHint;

		private readonly List<Vector3> sourcePoints;

		private Mesh previousMesh;

		private MeshHelper meshHelper;

		private void CheckMesh()
		{
		}

		protected override LightningBoltParameters OnCreateParameters()
		{
			return null;
		}

		protected virtual void PopulateSourcePoints(List<Vector3> points)
		{
		}

		public void CreateRandomLightningPath(List<Vector3> points)
		{
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
	}
}
