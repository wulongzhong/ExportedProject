using System.Collections.Generic;
using UnityEngine;

public class ExchangeShaders : MonoBehaviour
{
	[SerializeField]
	public Shader fromShader;

	[SerializeField]
	public Shader toShader;

	[SerializeField]
	public List<Material> allMaterials;
}
