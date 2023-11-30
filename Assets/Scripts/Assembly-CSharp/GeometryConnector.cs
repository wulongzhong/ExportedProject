using System;
using System.Collections.Generic;
using UnityEngine;

public class GeometryConnector : MonoBehaviour
{
	[Serializable]
	public class Connection
	{
		public string path;

		public bool changeScale;

		public Vector3 scale;

		public bool scalePosition;

		public bool setLocalPositionAndRotationToZero;

		public bool setLocalPositionToZero;

		public Vector3 offsetPosition;
	}

	[Serializable]
	public class LoadedTransform
	{
		public string path;

		public Transform transform;
	}

	[SerializeField]
	public List<Connection> connections;

	[SerializeField]
	public bool replaceWithMeshColliders;

	public string text;

	[SerializeField]
	public List<LoadedTransform> loaded;

	public void SetFirstPath(string path)
	{
	}

	public GeometryConnectorSettings FindSettings()
	{
		return null;
	}

	public void AddLoaded(string path, Transform loadedTransform)
	{
	}

	public void ClearLoaded()
	{
	}
}
