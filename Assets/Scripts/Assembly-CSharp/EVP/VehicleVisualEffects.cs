using UnityEngine;

namespace EVP
{
	public class VehicleVisualEffects : MonoBehaviour
	{
		public Transform steeringWheel;

		public float degreesOfRotation;

		public Renderer brakesRenderer;

		public int brakesMaterialIndex;

		public Material brakesOnMaterial;

		public Material brakesOffMaterial;

		private VehicleController m_vehicle;

		private bool m_prevBrakes;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}
	}
}
