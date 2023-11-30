using System.Collections.Generic;
using UnityEngine;

public class PaintTransformation : MonoBehaviour
{
	[SerializeField]
	public List<GGPaintableTexture> paintableTextures;

	[SerializeField]
	public bool changeSphereSize;

	[SerializeField]
	public float sphereSize;

	[SerializeField]
	public bool useParticleColor;

	[SerializeField]
	public Color particleColor;

	[SerializeField]
	public float sprayCameraDistance;

	[SerializeField]
	public int toolVariantIndex;

	[SerializeField]
	private List<CarModelPart> partsToHideWhilePainting;

	public void Init()
	{
	}

	public void OnStartPainting()
	{
	}

	public void OnDonePainting()
	{
	}

	public void ClearTexturesToColor(Color color)
	{
	}

	public void RenderSphere(GGPSphereCommand.Params sphereParams)
	{
	}

	public float FillPercent()
	{
		return 0f;
	}

	public void ReleaseAll()
	{
	}
}
