using System;
using UnityEngine;

public class SubpartVariant : MonoBehaviour
{
	[SerializeField]
	public CarSubPartVariantInfo info;

	[SerializeField]
	private CarModelSubpart subpart;

	[NonSerialized]
	private CarModelInfo.VariantGroup variantGroup_;

	[SerializeField]
	private CarModelCustomization partOfCustomization;

	public CarModelInfo.VariantGroup variantGroup => null;

	public bool IsPartOfCustomization(CarModelCustomization customization)
	{
		return false;
	}

	public void ShowIfInActiveVariant()
	{
	}

	public void Init(CarModelSubpart subpart)
	{
	}
}
