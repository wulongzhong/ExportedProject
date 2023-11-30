using System;
using UnityEngine;

namespace EVP
{
	[Serializable]
	public class CameraAttachTo : CameraMode
	{
		public Transform attachTarget;

		public override void SetViewConfig(VehicleViewConfig viewConfig)
		{
		}

		public override void Update(Transform self, Transform target, Vector3 targetOffset, float deltaTime)
		{
		}
	}
}
