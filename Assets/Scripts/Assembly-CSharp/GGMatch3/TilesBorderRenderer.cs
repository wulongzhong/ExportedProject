using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	[DisallowMultipleComponent]
	public class TilesBorderRenderer : MonoBehaviour
	{
		[SerializeField]
		private bool dontConnectDiagonalSlots;

		[SerializeField]
		public float slotSize;

		[SerializeField]
		private float borderSize;

		[SerializeField]
		private float borderOffset;

		public int sortingLayerId;

		public int sortingOrder;

		[SerializeField]
		private bool setSortingSettings;

		[SerializeField]
		private SpriteSortingSettings sortingSettings;

		private Mesh mesh;

		private MeshFilter _meshFilter;

		private MeshRenderer _meshRenderer;

		private List<Vector3> vertexBuffer;

		private List<int> trisBuffer;

		private List<Vector2> uvBuffer;

		public TilesSlotsProvider cachedProviderDebug;

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

		public void ShowBorderOnLevel(LevelDefinition level)
		{
		}

		public void ShowBorderOnLevelDontConnectDiagonalSlots(TilesSlotsProvider slotsProvider)
		{
		}

		public void ShowBorderOnLevel(TilesSlotsProvider slotsProvider)
		{
		}

		public void ShowBorderOnLevelConnectDiagonalSlots(TilesSlotsProvider slotsProvider)
		{
		}

		public void ShowSlotsOnLevel(LevelDefinition level)
		{
		}

		public void ShowSlotsOnLevel(TilesSlotsProvider slotsProvider)
		{
		}

		private void ShowSlotsOnLevelDontConnectDiagonalSlots(TilesSlotsProvider slotsProvider)
		{
		}

		private void ShowSlotsOnLevelConnectDiagonalSlots(TilesSlotsProvider slotsProvider)
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
