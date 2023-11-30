using UnityEngine;

namespace EVP
{
	public class VehicleStandardInput : MonoBehaviour
	{
		public enum ThrottleAndBrakeInput
		{
			SingleAxis = 0,
			SeparateAxes = 1
		}

		public VehicleController target;

		public bool continuousForwardAndReverse;

		public ThrottleAndBrakeInput throttleAndBrakeInput;

		public bool handbrakeOverridesThrottle;

		public string steerAxis;

		public string throttleAndBrakeAxis;

		public string throttleAxis;

		public string brakeAxis;

		public string handbrakeAxis;

		public KeyCode resetVehicleKey;

		private bool m_doReset;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
