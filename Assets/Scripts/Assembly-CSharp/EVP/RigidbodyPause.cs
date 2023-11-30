using UnityEngine;

namespace EVP
{
	public class RigidbodyPause : MonoBehaviour
	{
		public bool pause;

		public KeyCode key;

		private Rigidbody m_rigidbody;

		private bool m_pausedState;

		private Vector3 m_velocity;

		private Vector3 m_angularVelocity;

		private VehicleController m_vehicle;

		private void OnEnable()
		{
		}

		private void FixedUpdate()
		{
		}

		private void DisableWheelColliders()
		{
		}

		private void EnableWheelColliders()
		{
		}

		private void Update()
		{
		}
	}
}
