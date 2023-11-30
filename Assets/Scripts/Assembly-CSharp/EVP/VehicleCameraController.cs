using UnityEngine;

namespace EVP
{
	public class VehicleCameraController : MonoBehaviour
	{
		public enum Mode
		{
			AttachTo = 0,
			SmoothFollow = 1,
			MouseOrbit = 2,
			LookAt = 3,
			Free = 4
		}

		public Mode mode;

		public Transform target;

		public bool followCenterOfMass;

		public bool useUnscaledTime;

		public bool cameraCollisions;

		public LayerMask collisionMask;

		public KeyCode changeCameraKey;

		public CameraAttachTo attachTo;

		public CameraSmoothFollow smoothFollow;

		public CameraMouseOrbit mouseOrbit;

		public CameraLookAt lookAt;

		public CameraFree free;

		private Transform m_transform;

		private Mode m_prevMode;

		private CameraMode[] m_cameraModes;

		private Transform m_prevTarget;

		private Rigidbody m_targetRigidbody;

		private Vector3 m_localTargetOffset;

		private Vector3 m_targetOffset;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void LateUpdate()
		{
		}

		public void NextCameraMode()
		{
		}

		public void ResetCamera()
		{
		}

		public void SetViewConfig(VehicleViewConfig viewConfig)
		{
		}

		private void AdquireTarget()
		{
		}

		private void ComputeTargetOffset()
		{
		}
	}
}
