using System;
using UnityEngine;

public class NutDefinition : MonoBehaviour
{
	[Serializable]
	public class Definition
	{
		public string cameraPosition;

		public bool useCustomCameraSettings;

		public float cameraDistance;

		public Vector2 angleOffset;

		public float fov;

		public float toolDistanceFromCamera;
	}

	public Definition definition;
}
