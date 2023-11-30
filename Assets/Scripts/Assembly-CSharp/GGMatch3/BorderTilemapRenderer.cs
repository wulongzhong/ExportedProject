using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	[DisallowMultipleComponent]
	public class BorderTilemapRenderer : MonoBehaviour
	{
		[SerializeField]
		public float slotSize;

		[SerializeField]
		private bool setSortingSettings;

		[SerializeField]
		private SpriteSortingSettings sortingSettings;

		[SerializeField]
		private BorderTilemap tilemap;

		private Mesh mesh;

		private MeshFilter _meshFilter;

		private MeshRenderer _meshRenderer;

		private List<Vector3> vertexBuffer;

		private List<int> trisBuffer;

		private List<Vector2> uvBuffer;

		public MeshFilter meshFilter => null;

		public MeshRenderer meshRenderer => null;

		private void InitBuffers(int vertexCount, int trisCount)
		{
		}

		private void Init()
		{
		}

		public static bool IsEmptySlot(TilesSlotsProvider slotsProvider, IntVector2 position)
		{
			return false;
		}

		public static bool IsOccupiedSlot(TilesSlotsProvider slotsProvider, IntVector2 position)
		{
			return false;
		}

		public void ShowBorder(TilesSlotsProvider slotsProvider)
		{
		}

		private void ClearBuffers()
		{
		}

		private void SetBuffersToToMesh()
		{
		}

		private void DrawRectangle(Rect pos, Rect uv)
		{
		}
	}
}
