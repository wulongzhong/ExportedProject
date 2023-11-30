using System.Collections.Generic;
using UnityEngine;

public class MeshRendererDemo : MonoBehaviour
{
	[SerializeField]
	private float distance;

	[SerializeField]
	private int rows;

	[SerializeField]
	private int columns;

	private MeshFilter meshFilter;

	private Mesh mesh;

	private List<Vector3> vertexBuffer;

	private List<int> trisBuffer;

	private List<Vector2> uvBuffer;

	private bool isInitialized;

	private void Init()
	{
	}

	private void Start()
	{
	}

	private int GetIndex(int column, int row, int columns)
	{
		return 0;
	}

	public void DoUpdateMesh()
	{
	}
}
