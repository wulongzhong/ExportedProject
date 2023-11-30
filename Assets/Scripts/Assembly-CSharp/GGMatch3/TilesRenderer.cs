using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	[DisallowMultipleComponent]
	public class TilesRenderer : MonoBehaviour
	{
		[SerializeField]
		private float slotSize;

		[SerializeField]
		private float borderSize;

		public int sortingLayerId;

		public int sortingOrder;

		private Mesh mesh;

		private MeshFilter _meshFilter;

		private MeshRenderer _meshRenderer;

		private List<Vector3> vertexBuffer;

		private List<int> trisBuffer;

		private List<Vector2> uvBuffer;

		private List<Vector2> uv1Buffer;

		private List<Vector2> uv2Buffer;

		public MeshFilter meshFilter => null;

		public MeshRenderer meshRenderer => null;

		private void InitBuffers(int maxSlots)
		{
		}

		private void Init()
		{
		}

		private Rect SolidRectMask()
		{
			return default(Rect);
		}

		public static bool IsEmptySlot(LevelDefinition level, IntVector2 position)
		{
			return false;
		}

		public static bool IsOccupiedSlot(LevelDefinition level, IntVector2 position)
		{
			return false;
		}

		private void DrawRectangle(Rect pos, Rect uv, Rect uv1, Rect uv2)
		{
		}
	}
}
