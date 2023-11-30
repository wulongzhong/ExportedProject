using System;
using UnityEngine;

namespace EVP
{
	[Serializable]
	public class CameraSmoothFollow : CameraMode
	{
		public float distance;

		public float height;

		public float viewHeightRatio;

		public bool lookBehind;

		public float heightDamping;

		public float rotationDamping;

		public bool followVelocity;

		public float velocityDamping;

		private VehicleController m_vehicle;

		private Camera m_camera;

		private Vector3 m_smoothLastPos;

		private Vector3 m_smoothVelocity;

		private float m_smoothTargetAngle;

		private float m_selfRotationAngle;

		private float m_selfHeight;

		public override void SetViewConfig(VehicleViewConfig viewConfig)
		{
		}

		public override void Initialize(Transform self)
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
