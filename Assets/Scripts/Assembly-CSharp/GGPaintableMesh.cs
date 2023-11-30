using System;
using UnityEngine;

public class GGPaintableMesh : MonoBehaviour
{
	public enum UVIndex
	{
		UV0 = 0,
		UV1 = 1
	}

	[SerializeField]
	private UVIndex uvIndex_;

	[SerializeField]
	public bool ignoreForRendering;

	[NonSerialized]
	private Mesh cachedMesh_;

	[NonSerialized]
	private MeshRenderer meshRenderer_;

	public int uvIndex => 0;

	public Mesh cachedMesh => null;

	public MeshRenderer meshRenderer => null;
}
