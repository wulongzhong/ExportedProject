using System;
using System.Collections.Generic;
using GGCloth;
using UnityEngine;

public class SquareClothRenderer : MonoBehaviour
{
	[Serializable]
	public class ClothTexture
	{
		public ItemColor itemColor;

		public Texture2D texture;
	}

	[Serializable]
	public class ShadowSprite
	{
		public ItemColor itemColor;

		public Sprite texture;
	}

	[SerializeField]
	private List<SpriteRenderer> boxSprites;

	[SerializeField]
	private List<ClothTexture> clothTextures;

	[SerializeField]
	private List<ShadowSprite> shadowTextures;

	[SerializeField]
	private SpriteRenderer shadowSprite;

	[SerializeField]
	public int sortingLayerID;

	[SerializeField]
	public int sortingLayerOrder;

	private MeshFilter meshFilter;

	private Mesh mesh;

	[SerializeField]
	private bool invertNormals;

	private List<Vector3> vertexBuffer;

	private List<int> trisBuffer;

	private List<Vector2> uvBuffer;

	[NonSerialized]
	private SquareCloth cloth;

	[NonSerialized]
	public ItemColor itemColor;

	private bool isLocalScaleSaved;

	private Vector3 localScale;

	public void SetCloth(SquareCloth cloth)
	{
	}

	public ClothTexture GetClothTexture(ItemColor itemColor)
	{
		return null;
	}

	public ShadowSprite GetShadowClothTexture(ItemColor itemColor)
	{
		return null;
	}

	public void UpdateMaterialSettings()
	{
	}

	public void SetBrightness(float brightness)
	{
	}

	public Material GetMaterial()
	{
		return null;
	}

	public void SetColor(Color color)
	{
	}

	public void SetAlpha(float alpha)
	{
	}

	public void SetShadowTexture(ItemColor itemColor)
	{
	}

	public void SetClothTexture(ItemColor itemColor)
	{
	}

	public void SetSortingLayers(int sortingLayerId, int sortingLayerOrder)
	{
	}

	public void ReinitSortingLayers()
	{
	}

	private void Init()
	{
	}

	private Vector3 Min(Vector3 a, Vector3 b)
	{
		return default(Vector3);
	}

	private Vector3 Max(Vector3 a, Vector3 b)
	{
		return default(Vector3);
	}

	public void DoUpdateMesh()
	{
	}
}
