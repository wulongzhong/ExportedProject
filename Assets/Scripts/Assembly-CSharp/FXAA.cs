using UnityEngine;

[ExecuteInEditMode]
public class FXAA : MonoBehaviour
{
	public Material material;

	public float Sharpness;

	public float Threshold;

	private static readonly int sharpnessString;

	private static readonly int thresholdString;

	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
