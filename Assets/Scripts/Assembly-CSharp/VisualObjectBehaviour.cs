using System;
using System.Collections.Generic;
using UnityEngine;

public class VisualObjectBehaviour : MonoBehaviour
{
	public VisualObjectVariation defaultVariation;

	public List<VisualObjectVariation> variations;

	public List<VisualObjectVariation> allVariations;

	public GraphicsSceneConfig.VisualObject visualObject;

	[SerializeField]
	public CharacterVisualObjectBehaviour characterBehaviour;

	private DecoratingSceneConfig.VisualObjectOverride visualObjectOverride;

	private bool isMarkersCreated;

	[NonSerialized]
	private Transform markersTransform;

	public bool isPlayerControlledObject => false;

	public bool hasDefaultVariation => false;

	public Vector3 iconHandlePosition => default(Vector3);

	public Vector3 iconHandleScale => default(Vector3);

	public Quaternion iconHandleRotation => default(Quaternion);

	public VisualObjectVariation activeVariation => null;

	public void SetMarkersActive(bool active)
	{
	}

	public void InitMarkers(GameObject markerPrefab)
	{
	}

	private VisualObjectVariation CreateVariation(GraphicsSceneConfig.Variation variation)
	{
		return null;
	}

	public void InitRuntimeData(DecoratingSceneConfig.RoomConfig roomConfig)
	{
	}

	public void Init(RoomsBackend.RoomAccessor roomAccessor)
	{
	}

	public void Init(GraphicsSceneConfig.VisualObject visualObject)
	{
	}

	public void DestroySelf()
	{
	}

	public void SetVisualState()
	{
	}

	public void ShowVariationBehaviour(int variationIndex)
	{
	}

	private void ShowVariation(VisualObjectVariation variation)
	{
	}

	public void Hide()
	{
	}

	public static void Destroy(GameObject obj)
	{
	}
}
