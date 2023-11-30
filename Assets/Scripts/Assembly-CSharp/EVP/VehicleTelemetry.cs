using UnityEngine;

namespace EVP
{
	public class VehicleTelemetry : MonoBehaviour
	{
		public enum DataMode
		{
			TireSlipAndForce = 0,
			GroundMaterial = 1
		}

		public VehicleController target;

		public DataMode dataMode;

		public Font font;

		public KeyCode toggleKey;

		public bool show;

		public bool gizmos;

		public bool gizmosAtPhysicsPos;

		private string m_telemetryText;

		private GUIStyle m_style;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void OnGUI()
		{
		}

		private string DoTelemetry()
		{
			return null;
		}

		private string GetWheelTelemetry(WheelData wd, ref float suspensionForce)
		{
			return null;
		}

		private void DrawGizmos()
		{
		}

		private void DrawWheelGizmos(WheelData wd)
		{
		}
	}
}
