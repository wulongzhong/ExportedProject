using UnityEngine;

public class IBLDescription : ScriptableObject
{
	[SerializeField]
	public bool multiplyMaxLight;

	[SerializeField]
	public float maxLightMultiply;

	[SerializeField]
	public bool useMaxLightValue;

	[SerializeField]
	public float maxLightValue;

	[SerializeField]
	public bool desatColorsAboveOne;

	[SerializeField]
	public float targetDiffuse;

	[SerializeField]
	public float targetSpecular;

	[SerializeField]
	public float diffuseLightAmmount;

	[SerializeField]
	public float specularLightAmmount;

	[SerializeField]
	public float minLuminosityInCubemap;

	[SerializeField]
	public float luminosityPower;

	[SerializeField]
	public float irradianceLuminosity;

	[SerializeField]
	public Cubemap cubemap;
}
