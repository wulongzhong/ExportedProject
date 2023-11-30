using System;
using System.Collections.Generic;
using UnityEngine;

public class CarModelCustomization : MonoBehaviour
{
	private struct Hingestate
	{
		public PartHinge hinge;

		public bool isOpen;
	}

	[SerializeField]
	private bool alwaysShow;

	[SerializeField]
	public List<CarModelPart> showWhenPartActive;

	[SerializeField]
	public bool onlyShowWhenPartActive;

	[SerializeField]
	public CarModelInfo.VariantGroup variantGroup;

	[SerializeField]
	public List<PartHinge> openHingesWhileChoosing;

	[SerializeField]
	public List<PartHinge> closeHingesWhileChoosing;

	[SerializeField]
	public Sprite sprite;

	[SerializeField]
	public List<Transform> handles;

	[SerializeField]
	public bool alwaysShowHandle;

	[SerializeField]
	private string groupName_;

	[SerializeField]
	public bool changeButtonScale;

	[SerializeField]
	public float minScale;

	[SerializeField]
	public float minDistance;

	[SerializeField]
	private CarModel model;

	[NonSerialized]
	private List<CarModelPart> partsToShowAfterPurchase;

	[NonSerialized]
	private List<CarModelPart> partsThatArePartOfCustomization;

	private List<Hingestate> affectedHinges;

	public string groupName => null;

	public bool CanShow => false;

	public bool HasCustomizationForTag(string tag)
	{
		return false;
	}

	public void InitFromEditor(CarModel model)
	{
	}

	public void Editor_ExplainWhatPartsAreActive()
	{
	}

	public void ImportHandlesFromChildren()
	{
	}

	public void OnVariationPanelOpen()
	{
	}

	public void OnVariationPanelClose()
	{
	}
}
