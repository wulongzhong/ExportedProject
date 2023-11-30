using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class SlotsRendererPool : MonoBehaviour
{
	[SerializeField]
	private Transform parent;

	[SerializeField]
	private GameObject prefab;

	[SerializeField]
	private bool resetScale;

	[SerializeField]
	private bool resetPosition;

	private List<TilesBorderRenderer> availableBorderRenderers;

	public void ReturnRenderer(TilesBorderRenderer renderer)
	{
	}

	private TilesBorderRenderer CreateFromPrefab()
	{
		return null;
	}

	public TilesBorderRenderer Next()
	{
		return null;
	}
}
