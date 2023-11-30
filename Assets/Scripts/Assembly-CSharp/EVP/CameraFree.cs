using System;
using UnityEngine;

namespace EVP
{
	[Serializable]
	public class CameraFree : CameraMode
	{
		public float minVerticalAngle;

		public float maxVerticalAngle;

		public float horizontalSpeed;

		public float verticalSpeed;

		public float damping;

		public bool adjustFov;

		public float minFov;

		public float maxFov;

		public float fovSpeed;

		public float fovDamping;

		public bool adjustNearPlane;

		public float nearPlaneAtMinFov;

		public string horizontalAxis;

		public string verticalAxis;

		public string fovAxis;

		public bool enableMovement;

		public float movementSpeed;

		public float movementDamping;

		public string forwardAxis;

		public string sidewaysAxis;

		public string upwardsAxis;

		private Camera m_camera;

		private Vector3 m_position;

		private float m_fov;

		private float m_savedFov;

		private float m_savedNearPlane;

		private float m_horizontal;

		private float m_vertical;

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
