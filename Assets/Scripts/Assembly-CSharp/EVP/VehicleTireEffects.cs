using UnityEngine;

namespace EVP
{
	public class VehicleTireEffects : MonoBehaviour
	{
		public float tireWidth;

		public float minSlip;

		public float maxSlip;

		public float intensity;

		public float updateInterval;

		public float minIntensityTime;

		public float maxIntensityTime;

		public float limitIntensityTime;

		private VehicleController m_vehicle;

		private TireFxData[] m_fxData;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void InitializeTireFxData()
		{
		}

		private void UpdateTireMarks(WheelData wheelData, TireFxData fxData)
		{
		}

		private void UpdateTireParticles(WheelData wheelData, TireFxData fxData)
		{
		}
	}
}
