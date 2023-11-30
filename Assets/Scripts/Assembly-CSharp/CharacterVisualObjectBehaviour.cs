using System.Collections.Generic;
using UnityEngine;

public class CharacterVisualObjectBehaviour : MonoBehaviour
{
	public RoomCharacterScene scene;

	[SerializeField]
	public VisualObjectBehaviour visualObjectBeh;

	[SerializeField]
	public CharacterVisualObjectVariation defaultVariation;

	[SerializeField]
	public List<CharacterVisualObjectVariation> variations;

	[SerializeField]
	public List<CharacterVisualObjectVariation> allVariations;

	[SerializeField]
	public CharacterVisualObjectSceneItem sceneItem;

	private bool isInitializedForRuntime;

	public Vector3 lookAtPosition => default(Vector3);

	public bool isLookAtPositionDefined => false;

	public void InitForRuntime()
	{
	}

	public void Init(VisualObjectBehaviour visualObjectBeh, RoomCharacterScene scene)
	{
	}

	private CharacterVisualObjectVariation CreateVariation(VisualObjectVariation variation)
	{
		return null;
	}

	public void ShowGlobalVariation(int variationIndex)
	{
	}

	public void Hide()
	{
	}
}
