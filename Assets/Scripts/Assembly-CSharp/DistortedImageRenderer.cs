using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class DistortedImageRenderer
{
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
	public Color color;

	[SerializeField]
	public Sprite sprite;

	public Vector3 tl;

	public Vector3 tr;

	public Vector3 bl;

	public Vector3 br;

	[SerializeField]
	private Color innerColor;

	private UIVertex[] quad;

	private VertexProperties[] innerVertex;

	public void PopulateMesh(VertexHelper toFill)
	{
	}

	private Rect GetUVs(Sprite sprite)
	{
		return default(Rect);
	}

	private void FillMeshDistortCorners(VertexHelper toFill)
	{
	}
}
