using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	[DisallowMultipleComponent]
	public class TiledSpriteRenderer : MonoBehaviour
	{
		[SerializeField]
		private SpriteSortingSettings sortingSettings;

		private Mesh mesh;

		private MeshFilter _meshFilter;

		private MeshRenderer _meshRenderer;

		private List<Vector3> vertexBuffer;

		private List<int> trisBuffer;

		private List<Vector2> uvBuffer;

		public MeshFilter meshFilter => null;

		public MeshRenderer meshRenderer => null;

		private void InitBuffers(int maxRectangles)
		{
		}

		private void Init()
		{
		}

		public void ClearAndInit(int numRectangles)
		{
		}

		public void DrawRectangle(Rect pos, Rect uv)
		{
		}

		public void CopyToMesh()
		{
		}
	}
}
