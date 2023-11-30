using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class CharacterVisualObjectSceneItem : MonoBehaviour
{
	[SerializeField]
	private List<MeshRenderer> meshes;

	[SerializeField]
	public Vector3 lookAtPosition;

	[SerializeField]
	public bool isLookAtPositionDefined;

	[SerializeField]
	public int stencilIndex;

	public void InitForRuntime()
	{
	}

	public void SetActive(bool isActive)
	{
	}

	public void Init(DecoratingScene3DSetup.VisualObject visualObject, Material materialToReplace, SpriteSortingSettings sortingSettings)
	{
	}

	private void InitWithTransform(Transform root, string nameToSearchFor)
	{
	}

	private void FillMeshes(Transform root)
	{
	}
}
