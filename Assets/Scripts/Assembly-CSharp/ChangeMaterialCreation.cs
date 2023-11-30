using System;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialCreation : MonoBehaviour
{
	[Serializable]
	public class MaterialChange
	{
		public Material from;
	}

	public Material fromMaterial;

	public Material toMaterial;

	public Material changeMaterial;

	public List<GeometryConnector.Connection> connections;

	public GeometryConnector templateConnector;

	public Transform transformToConnect;

	public GGPaintableTexture paintableTexture;

	public List<MaterialChange> materialChanges;

	public bool HasConnections => false;

	public MaterialChange GetMaterialChange(Material material)
	{
		return null;
	}
}
