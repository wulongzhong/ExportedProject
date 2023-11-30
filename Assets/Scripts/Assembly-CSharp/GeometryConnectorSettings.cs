using System;
using System.Collections.Generic;
using UnityEngine;

public class GeometryConnectorSettings : MonoBehaviour
{
	[Serializable]
	public class Link
	{
		public string name;

		public GameObject gameObject;

		public bool positionRelativeToRoot;

		public string editorPathToGameObject;

		public string pathPrefx;

		public Vector3 offset;

		public string FullSearchPath(string path)
		{
			return null;
		}
	}

	private struct InParams
	{
		public Transform root;

		public string namePrefix;

		public string searchPath;

		public bool stopSearchOnFirst;
	}

	private class Output
	{
		public class FoundItem
		{
			public Transform transform;

			public string name;
		}

		public List<FoundItem> found;

		public bool HasFound => false;
	}

	[SerializeField]
	public List<Link> links;

	private Link GetLink(string name)
	{
		return null;
	}

	public void HideAllLinks()
	{
	}

	public void SetAllLinksActive(bool active)
	{
	}

	public GameObject GetGameObject(string path)
	{
		return null;
	}

	public Vector3 GetWorldPositionUnderLink(Link link, Transform transform)
	{
		return default(Vector3);
	}

	public GameObject InstantiateGameObject(string path, Transform parent)
	{
		return null;
	}

	private void FindPath(InParams inParams, Output output)
	{
	}
}
