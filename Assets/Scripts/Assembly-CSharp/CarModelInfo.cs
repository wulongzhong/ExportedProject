using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CarModelInfo
{
	[Serializable]
	public class VariantGroup
	{
		[Serializable]
		public class Variation
		{
			[SerializeField]
			public Color uiSpriteColor;

			[SerializeField]
			public Sprite itemSprite;

			[SerializeField]
			public List<ChangeColor> changeColor;

			[SerializeField]
			private List<MaterialChangeByTag> changesByTag;

			private static List<Material> materialsHelper;

			private List<Texture> aoTextures;

			public ChangeColor GetChangeColorForName(string name)
			{
				return null;
			}

			public bool HasCustomizationForTag(string tag)
			{
				return false;
			}

			public void ApplyChangesToTag(MeshMaterialTag tag, VariantGroup variantGroup)
			{
			}

			private void ApplyChangesToTagList(MeshMaterialTag tag, VariantGroup variantGroup, List<MaterialChangeByTag> changesByTag)
			{
			}
		}

		[SerializeField]
		public string name;

		[SerializeField]
		public List<Variation> variations;

		[SerializeField]
		public string cameraName;

		[SerializeField]
		public bool skipAnimationOnChange;

		private RoomsBackend.RoomAccessor backendAccessor_;

		private RoomsBackend.VariantGroupAccessor variantGroupModel_;

		private RoomsBackend.RoomAccessor backendAccessor => null;

		private RoomsBackend.VariantGroupAccessor variantGroupModel => null;

		public Variation selectedVariation => null;

		public int selectedVariationIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Variation GetVariation(int index)
		{
			return null;
		}

		public void Init(RoomsBackend.RoomAccessor backendAccessor)
		{
		}

		public void SaveChangeColor(ChangeColor changeColor, int index)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public string name;

		internal bool _003CRemoveVariantGroup_003Eb__0(VariantGroup group)
		{
			return false;
		}
	}

	[SerializeField]
	private List<VariantGroup> variantGroups;

	public VariantGroup GetVariantGroup(string name)
	{
		return null;
	}

	public void RemoveVariantGroup(string name)
	{
	}

	public void AddGroup(VariantGroup group)
	{
	}

	public void Init(RoomsBackend.RoomAccessor roomAccessor)
	{
	}
}
