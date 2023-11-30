using System;
using UnityEngine;

public class MaterialChangeVariation : MonoBehaviour
{
	[Serializable]
	public class Config
	{
		public int variantIndex;

		public Material materialToApply;

		public string groupName;
	}

	public Config config;

	public string groupName => null;

	public void Apply()
	{
	}
}
