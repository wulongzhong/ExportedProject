using System;
using UnityEngine;

namespace EVP
{
	[Serializable]
	public class GroundMaterial
	{
		public enum SurfaceType
		{
			Hard = 0,
			Soft = 1
		}

		public PhysicMaterial physicMaterial;

		public float grip;

		public float drag;

		public TireMarksRenderer marksRenderer;

		public TireParticleEmitter particleEmitter;

		public SurfaceType surfaceType;
	}
}
