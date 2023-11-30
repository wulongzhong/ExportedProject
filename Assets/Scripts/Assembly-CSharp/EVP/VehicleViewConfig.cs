using UnityEngine;

namespace EVP
{
	public class VehicleViewConfig : MonoBehaviour
	{
		public Transform lookAtPoint;

		public Transform driverView;

		public float viewDistance;

		public float viewHeight;

		public float viewDamping;

		public float viewMinDistance;

		public float viewMinHeight;

		private float _003CtargetDiameter_003Ek__BackingField;

		public float targetDiameter
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		private void Awake()
		{
		}
	}
}
