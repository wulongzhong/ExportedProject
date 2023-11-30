using UnityEngine;

namespace EVP
{
	public class VehicleManager : MonoBehaviour
	{
		public VehicleController[] vehicles;

		public int defaultVehicle;

		public KeyCode previousVehicleKey;

		public KeyCode nextVehicleKey;

		public KeyCode alternateNextVehicleKey;

		public VehicleCameraController cameraController;

		public bool overrideVehicleComponents;

		private int m_currentVehicleIdx;

		private VehicleController m_currentVehicle;

		private VehicleStandardInput m_commonInput;

		private VehicleTelemetry m_commonTelemetry;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void SelectVehicle(int vehicleIdx)
		{
		}

		public void SelectPreviousVehicle()
		{
		}

		public void SelectNextVehicle()
		{
		}

		private void EnableVehicle(VehicleController vehicle)
		{
		}

		private void DisableVehicle(VehicleController vehicle)
		{
		}

		private void SetupVehicleComponents(VehicleController vehicle, bool enabled)
		{
		}
	}
}
