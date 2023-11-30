using System;
using System.Collections.Generic;
using JSONData;
using UnityEngine;

[Serializable]
public class GraphicsSceneConfig
{
	[Serializable]
	public class VisualSprite
	{
		public string spriteName;

		public string spritePath;

		[NonSerialized]
		public Sprite sprite;

		public bool isShadow;

		public int totalWidth;

		public int totalHeight;

		public int left;

		public int right;

		public int top;

		public int bottom;

		public Vector3 pivotPosition;

		public int depth;

		public int initialDepth;

		public Vector3 spritePosition => default(Vector3);

		public int width => 0;

		public int height => 0;
	}

	[Serializable]
	public class Variation
	{
		public string name;

		public List<VisualSprite> sprites;

		public string thumbnailName;

		public Sprite thumbnailSprite;

		public List<Triangle> hitboxTriangles;
	}

	[Serializable]
	public class DrawnShape
	{
		public int depth;

		public ShapeGraphShape shape;
	}

	[Serializable]
	public class Triangle
	{
		[Serializable]
		public struct PlaneZSetup
		{
			public float dc;

			public float ac;

			public float bc;

			public float GetZ(Vector2 pos)
			{
				return 0f;
			}
		}

		public int depth;

		public PlaneZSetup planeZSetup;

		public Vector2 p1;

		public Vector2 p2;

		public Vector2 p3;

		private static Vector2[] pointsCache;

		public float GetZ(Vector2 pos)
		{
			return 0f;
		}

		public bool IsInside(Vector2 pos)
		{
			return false;
		}
	}

	[Serializable]
	public class VisualObject
	{
		public struct HitResult
		{
			public bool isHit;

			public int hitDepth;
		}

		public string name;

		public List<Variation> variations;

		private List<Variation> allVariations_;

		public int index;

		public SceneObjectsDB.SceneObjectInfo sceneObjectInfo;

		public List<ShapeGraphShape> hitboxes;

		public List<Triangle> hitboxTriangles;

		public List<DrawnShape> hitboxesList;

		public List<ShapeGraphShape> dashLines;

		public Vector3 iconHandlePosition;

		public bool hasDefaultVariation;

		public Variation defaultVariation;

		private RoomsBackend.RoomAccessor roomAccessor_;

		private RoomsBackend.VisualObjectAccessor visualObjectModel_;

		public string animationSettingsName => null;

		public string displayName => null;

		private RoomsBackend.RoomAccessor roomAccessor => null;

		private RoomsBackend.VisualObjectAccessor visualObjectModel => null;

		public Variation ownedVariation => null;

		public bool isOwned
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool isUnlocked => false;

		public int ownedVariationIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int depthForMarkerLines => 0;

		public int maxDepth => 0;

		public int startingDepth => 0;

		public void Init(RoomsBackend.RoomAccessor roomAccessor)
		{
		}

		public HitResult GetHitResult(Vector2 psdPosition)
		{
			return default(HitResult);
		}

		private bool IsHit(Vector2 psdPostion)
		{
			return false;
		}

		public bool IsUnlocked(DecoratingScene scene)
		{
			return false;
		}
	}

	public class ValidName
	{
		public List<string> validNames;
	}

	public int width;

	public int height;

	public List<VisualObject> objects;

	public List<ValidName> validVisualObjectNames;

	public override string ToString()
	{
		return null;
	}
}
