using System;
using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class GGPaintableTexture : MonoBehaviour
{
	[SerializeField]
	private IntVector2 imageSize;

	[SerializeField]
	private IntVector2 countImageSize;

	[SerializeField]
	private RenderTextureFormat format;

	[SerializeField]
	public List<GGPaintableMesh> meshes;

	[NonSerialized]
	private RenderTexture renderTexture_;

	[NonSerialized]
	private RenderTexture islandMapTexture_;

	private Texture2D readeableCopy;

	[NonSerialized]
	private BufferTexture bufferTexture;

	private RenderTexture renderTexture => null;

	private RenderTexture islandMapTexture => null;

	public void ReleaseRenderTexture()
	{
	}

	public void RemoveRenderTextureFromMaterials()
	{
	}

	public void ApplyRenderTextureToMaterials()
	{
	}

	private void OnDestroy()
	{
	}

	public void ClearToColor(Color color)
	{
	}

	public void CreateIslandMap()
	{
	}

	public float PaintInPercentage()
	{
		return 0f;
	}

	public void RenderSphere(GGPSphereCommand.Params sphereParams)
	{
	}
}
