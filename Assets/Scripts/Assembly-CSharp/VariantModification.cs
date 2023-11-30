using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class VariantModification
{
	[SerializeField]
	public int variantIndex;

	[SerializeField]
	public string groupName;

	[SerializeField]
	public Material materialToApply;

	[SerializeField]
	public int materialIndex;

	[SerializeField]
	public MeshRenderer rendererToApplyTo;

	private List<Material> materialsHelper;

	public bool IsApplicable(int index)
	{
		return false;
	}

	public void Apply(bool useSharedMaterial)
	{
	}
}
