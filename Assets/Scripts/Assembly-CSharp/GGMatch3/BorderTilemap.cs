using System;
using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	public class BorderTilemap : ScriptableObject
	{
		[Serializable]
		public class BorderDefinition
		{
			public int leftOffset;

			public int leftWidth;

			public int rightOffset;

			public int rightWidth;

			public int topOffset;

			public int topWidth;

			public int bottomOffset;

			public int bottomWidth;
		}

		[Serializable]
		public class TilePiece
		{
			public enum ConditionEnum
			{
				Full = 0,
				Empty = 1
			}

			[Serializable]
			public class Condition
			{
				public IntVector2 offset;

				public ConditionEnum conditionEnum;
			}

			[Serializable]
			public class DrawableRect
			{
				public Rect localImageRect;

				public Rect uvRect;
			}

			[Serializable]
			public class PositionDefinition
			{
				public TilePosition position;

				public List<Condition> conditions;

				public List<DrawableRect> drawableRects;
			}

			public IntVector2 positionInOriginal;

			public List<PositionDefinition> positions;

			public IntVector2 rowColumnInTileMap;

			public Rect UvRect(BorderTilemap tilemap)
			{
				return default(Rect);
			}
		}

		public struct SortedTilePiece
		{
			public TilePiece tilePiece;

			public TilePiece.PositionDefinition positionDefinition;
		}

		public int maxTextureWidth;

		public BorderDefinition border;

		public int spritePadding;

		public List<TilePiece> tiles;

		public Vector2 uvSize;

		public Texture2D texture;

		public Material material;

		private List<SortedTilePiece> sortedTiles;

		public List<SortedTilePiece> SortedTilesForTilePosition(TilePosition tilePosition)
		{
			return null;
		}

		public TilePosition TilePositionFromOffset(IntVector2 direction)
		{
			return default(TilePosition);
		}
	}
}
