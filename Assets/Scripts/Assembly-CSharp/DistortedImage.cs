using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistortedImage : Image
{
	public enum Implementation
	{
		FillMesh = 0,
		CreateMesh2 = 1
	}

	public struct VertexProperties
	{
		public Vector3 vertexInner;

		public Vector3 nextVertexInner;

		public Vector3 directionToNext;

		public Vector3 orthoDirection;

		public float borderWidth;

		public float borderLength;

		public Vector2 uv00;

		public Vector2 uv10;

		public Vector2 uv11;

		public Vector2 uv01;

		public Vector2 borderUv00;

		public Vector2 borderUv10;

		public Vector2 borderUv11;

		public Vector2 borderUv01;

		public Vector3 GetVertexBorder(float x, float y)
		{
			return default(Vector3);
		}

		public Vector2 GetVertexBorderUV(float x, float y)
		{
			return default(Vector2);
		}

		public void Init(Vector3 currentPos, Vector3 nextPos, float borderWidth, float borderLength)
		{
		}

		public void InitOuterUV(Vector2 uv00, Vector2 uv10, Vector2 uv01, Vector2 uv11)
		{
		}

		public void InitBorderUV(Vector2 borderUv00, Vector2 borderUv10, Vector2 borderUv01, Vector2 borderUv11)
		{
		}
	}

	[SerializeField]
	private Implementation implementation;

	[SerializeField]
	public Vector3 tl;

	[SerializeField]
	public Vector3 tr;

	[SerializeField]
	public Vector3 bl;

	[SerializeField]
	public Vector3 br;

	[SerializeField]
	public float outlineWidth;

	[SerializeField]
	private Color innerColor;

	[SerializeField]
	private bool fixControlPointsToRectCorners;

	private Vector3[] localCorners;

	private UIVertex[] quad;

	private VertexProperties[] innerVertex;

	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	public void PopulateMesh5(VertexHelper toFill)
	{
	}

	private void PopulateMesh5Side(VertexHelper toFill, Vector3 start, Vector3 end, List<Vector2> uvs, float size, bool isVertical)
	{
	}

	public void PopulateMesh4(VertexHelper toFill)
	{
	}

	public void CreateMeshCorner4(VertexHelper toFill, Vector3 referencePosition, List<Vector2> uvs, Vector3 horizontalDirection, Vector3 verticalDirection)
	{
	}

	public void CreateMeshSide4(VertexHelper toFill, List<Vector3> corners, List<Vector2> uvs, Vector3 tangentStart, Vector3 tangentEnd, float size, bool isVertical)
	{
	}

	private Rect getUVs(Sprite sprite)
	{
		return default(Rect);
	}

	public void FillMeshDistortCorners(VertexHelper toFill)
	{
	}

	public void CreateMesh2(VertexHelper toFill)
	{
	}

	public void CreateMeshCorner2(VertexHelper toFill, Vector3 referencePoint, Vector3 direction1, Vector3 direction2, List<Vector2> uvs)
	{
	}

	private void CreateMeshSide2(VertexHelper toFill, Vector3 start, Vector3 end, List<Vector2> uvs, float size, bool isVertical)
	{
	}
}
