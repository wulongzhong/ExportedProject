using System;
using UnityEngine;

public class CopyMaterialChangeVariation : MonoBehaviour
{
	[Serializable]
	public class Config
	{
		public int variantIndex;

		public string replace;

		public string replaceWith;

		public string groupName;
	}

	[SerializeField]
	public Config config;

	public string groupName => null;
}
