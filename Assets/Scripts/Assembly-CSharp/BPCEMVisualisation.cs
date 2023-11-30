using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class BPCEMVisualisation : MonoBehaviour
{
	[Serializable]
	public class Params
	{
		public Vector3 center;

		public Vector3 size;

		public Vector3 position;
	}

	public Vector3 center;

	public Vector3 size;

	public Vector3 position;

	[SerializeField]
	private bool enableGizmos;

	[SerializeField]
	private Light mainLight;

	public List<Transform> includeOtherTransforms;

	public bool useLayerMask;

	public bool useAmbientMultiplier;

	public float ambientMultiplier;

	public Color ambientSky;

	public Color ambientEquador;

	public Color ambientGround;

	public float skyIntensity;

	public float equadorIntensity;

	public float groundIntensity;

	public LayerMask includeLayers;

	public Params params1;

	public bool useLocalValues;

	public ReflectionProbe reflectionProbe;

	public ReflectionProbe reflectionProbe1;

	public bool setParamsFromReflectionProbe;

	public bool createGameObjectsListFromChildren;

	public bool usePosition;

	public List<GameObject> gameObjects;

	public List<Material> materialsList;

	[SerializeField]
	private float mainLightFactor;

	[SerializeField]
	private IBLDescription imageBasedLighting;

	[SerializeField]
	private Texture integrateBRDFTexture;

	[SerializeField]
	private float diffuseLightAmmount;

	[SerializeField]
	private float specularLightAmmount;

	[SerializeField]
	private float minLuminosityInCubemap;

	[SerializeField]
	private float luminosityPower;

	[SerializeField]
	private float irradianceLuminosity;

	[SerializeField]
	private bool clearCube;

	private const string _BBoxMin = "_BBoxMin";

	private const string _BBoxMax = "_BBoxMax";

	private const string _EnviCubeMapPos = "_EnviCubeMapPos";

	private const string _BBoxMin1 = "_BBoxMin1";

	private const string _BBoxMax1 = "_BBoxMax1";

	private const string _EnviCubeMapPos1 = "_EnviCubeMapPos1";

	private void OnDrawGizmos()
	{
	}

	private Vector3 WorldToLocal(Vector3 pos)
	{
		return default(Vector3);
	}

	private Vector3 GetPositionToSet(Vector3 pos)
	{
		return default(Vector3);
	}

	private Vector3 GetPosition(Vector3 pos)
	{
		return default(Vector3);
	}

	private void SetParamsFromReflectionProbe()
	{
	}

	private void CreateGameObjectsListFromChildren()
	{
	}

	public void CreateGameObjectsListFromChildren(Transform transform, List<Material> materialsList)
	{
	}

	public void UpdateMaterials(List<Material> materialsList)
	{
	}

	public void UpdateMaterials()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}
}
