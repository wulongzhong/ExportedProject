using GGMatch3;
using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class DistortedSprite : MonoBehaviour
{
	[SerializeField]
	private DistortedImageRenderer distortedImageRenderer;

	[SerializeField]
	public SpriteSortingSettings sortingSettings;

	private MeshFilter _meshFilter;

	private MeshRenderer _meshRenderer;

	private Mesh mesh;

	private VertexHelper vertexHelper;

	public Vector3 bl
	{
		set
		{
		}
	}

	public Vector3 tl
	{
		set
		{
		}
	}

	public Vector3 br
	{
		set
		{
		}
	}

	public Vector3 tr
	{
		set
		{
		}
	}

	public MeshFilter meshFilter => null;

	public MeshRenderer meshRenderer => null;

	public void CreateGeometry()
	{
	}
}
