using System;
using UnityEngine;
using UnityEngine.UI;

public class BubbleImage : Image
{
	[Serializable]
	public class VertexSettings
	{
		public Vector2 controlPoint1;

		public Vector2 controlPoint2;

		public float maxScale;

		public AnimationCurve scaleCurve;

		public static Vector2 ToLocalControlPoint(Vector2 fromVertex, Vector2 toVertex, Vector2 controlPoint)
		{
			return default(Vector2);
		}
	}

	public struct VertexProperties
	{
		public Vector2 vertexInner;

		public Vector2 vertexOuter;

		public Vector2 uvOuter;

		public Vector2 uvInner;

		public float prevT;

		public float nextT;

		public VertexSettings settings;

		public int index;

		public VertexPropertiesList list;
	}

	public class VertexPropertiesList
	{
		public VertexProperties[] vertexProperties;
	}

	[SerializeField]
	private VertexSettings bottomLeft;

	[SerializeField]
	private VertexSettings bottomRight;

	[SerializeField]
	private VertexSettings topRight;

	[SerializeField]
	private VertexSettings topLeft;

	[SerializeField]
	private int iterations;

	[SerializeField]
	private int sideSubdivisions;

	private UIVertex[] quad;

	private VertexPropertiesList vertexPropertiesList;

	private Rect getUVs(Sprite sprite)
	{
		return default(Rect);
	}

	public VertexPropertiesList GetVertexPropertiesList()
	{
		return null;
	}

	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}
}
