using UnityEngine;

namespace EVP
{
	public class CameraMode
	{
		public KeyCode hotKey;

		public VehicleCameraController controller;

		public virtual void SetViewConfig(VehicleViewConfig viewConfig)
		{
		}

		public virtual void Initialize(Transform self)
		{
		}

		public virtual void OnEnable(Transform self, Transform target, Vector3 targetOffset)
		{
		}

		public virtual void Reset(Transform self, Transform target, Vector3 targetOffset)
		{
		}

		public virtual void Update(Transform self, Transform target, Vector3 targetOffset, float deltaTime)
		{
		}

		public virtual void OnDisable(Transform self, Transform target, Vector3 targetOffset)
		{
		}

		public static float GetInputForAxis(string axisName)
		{
			return 0f;
		}
	}
}
