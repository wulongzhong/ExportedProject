using System;
using UnityEngine;

namespace EVP
{
	[Serializable]
	public class CameraMouseOrbit : CameraMode
	{
		public float distance;

		public bool resetOnEnable;

		public float minVerticalAngle;

		public float maxVerticalAngle;

		public float horizontalSpeed;

		public float verticalSpeed;

		public float orbitDamping;

		public float minDistance;

		public float maxDistance;

		public float distanceSpeed;

		public float distanceDamping;

		public string horizontalAxis;

		public string verticalAxis;

		public string distanceAxis;

		private VehicleController m_vehicle;

		private Camera m_camera;

		private float m_orbitX;

		private float m_orbitY;

		private float m_orbitDistance;

		public override void SetViewConfig(VehicleViewConfig viewConfig)
		{
		}

		public override void Initialize(Transform self)
		{
		}

		public override void OnEnable(Transform self, Transform target, Vector3 targetOffset)
		{
		}

		public override void Reset(Transform self, Transform target, Vector3 targetOffset)
		{
		}

		public override void Update(Transform self, Transform target, Vector3 targetOffset, float deltaTime)
		{
		}
	}
}
