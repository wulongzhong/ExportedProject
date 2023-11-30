using System;
using UnityEngine;

namespace EVP
{
	[Serializable]
	public class CameraLookAt : CameraMode
	{
		public float damping;

		public float minFov;

		public float maxFov;

		public float fovSpeed;

		public float fovDamping;

		public string fovAxis;

		public bool autoFov;

		public float targetRadius;

		public float targetRadiusSpeed;

		public bool adjustNearPlane;

		public float nearPlaneAtMinFov;

		public bool enableMovement;

		public float movementSpeed;

		public float movementDamping;

		public string forwardAxis;

		public string sidewaysAxis;

		public string verticalAxis;

		private Camera m_camera;

		private Vector3 m_position;

		private float m_fov;

		private float m_savedFov;

		private float m_savedNearPlane;

		public override void SetViewConfig(VehicleViewConfig viewConfig)
		{
		}

		public override void Initialize(Transform self)
		{
		}

		public override void OnEnable(Transform self, Transform target, Vector3 targetOffset)
		{
		}

		public override void Update(Transform self, Transform target, Vector3 targetOffset, float deltaTime)
		{
		}

		public override void OnDisable(Transform self, Transform target, Vector3 targetOffset)
		{
		}
	}
}
