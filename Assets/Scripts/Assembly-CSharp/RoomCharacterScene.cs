using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class RoomCharacterScene : MonoBehaviour
{
	[SerializeField]
	private DecoratingScene scene;

	[SerializeField]
	private Transform rootTransform;

	[SerializeField]
	private Transform offset;

	[SerializeField]
	private Transform spaceRoot;

	[SerializeField]
	public Camera worldCamera;

	[SerializeField]
	private float distanceFromCamera;

	[SerializeField]
	public Material geoMaterial;

	[SerializeField]
	private SpriteSortingSettings geoSortingLayer;

	[SerializeField]
	public Material spriteMaterial;

	[SerializeField]
	private LayerMask layer;

	[SerializeField]
	private List<CharacterVisualObjectBehaviour> visualObjectBehaviours;

	private List<Transform> transformsToRemove;

	private CharacterVisualObjectBehaviour GetVisualObjectBehaviourByName(string name)
	{
		return null;
	}

	private void DestroyAll()
	{
	}

	private CharacterVisualObjectBehaviour CreateVisualObjectBehaviour(VisualObjectBehaviour vo)
	{
		return null;
	}

	public void Init(DecoratingScene3DSetup scene3dSetup, DecoratingScene decoratingScene, RenderTexture renderTexture)
	{
	}

	private void InitGameObjects()
	{
	}

	public Vector3 WorldToScreenPoint(Vector3 worldPoint)
	{
		return default(Vector3);
	}

	public void Init()
	{
	}
}
