using UnityEngine;

namespace EVP
{
	public class VehicleRandomInput : MonoBehaviour
	{
		public float steerInterval;

		public float steerIntervalTolerance;

		public float steerChangeRate;

		public float steerStraightRandom;

		public float throttleInterval;

		public float throttleIntervalTolerance;

		public float throttleChangeRate;

		public float throttleForwardRandom;

		private float m_targetSteer;

		private float m_nextSteerTime;

		private float m_targetThrottle;

		private float m_targetBrake;

		private float m_nextThrottleTime;

		private VehicleController m_vehicle;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}
	}
}
