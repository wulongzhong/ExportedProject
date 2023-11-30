using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class HiddenElementBorderRenderer : MonoBehaviour
{
	public class HiddenElementProvider : TilesSlotsProvider
	{
		public int lastColoredSlates;

		public virtual int CountColoredSlates()
		{
			return 0;
		}
	}

	public class LevelSlotsProvider : HiddenElementProvider
	{
		public Match3Game game;

		public int minLevel;

		private List<Slot> allSlots;

		public override int MaxSlots => 0;

		public void Init(Match3Game game, int minLevel)
		{
		}

		public override int CountColoredSlates()
		{
			return 0;
		}

		public override Vector2 StartPosition(float size)
		{
			return default(Vector2);
		}

		public override Slot GetSlot(IntVector2 position)
		{
			return default(Slot);
		}

		private bool IsOccupied(GGMatch3.Slot levelSlot)
		{
			return false;
		}

		public override List<Slot> GetAllSlots()
		{
			return null;
		}
	}

	public class HoleProvider : HiddenElementProvider
	{
		private Match3Game game;

		private List<Slot> allSlots;

		public override int MaxSlots => 0;

		public override int CountColoredSlates()
		{
			return 0;
		}

		public void Init(Match3Game game)
		{
		}

		public override Vector2 StartPosition(float size)
		{
			return default(Vector2);
		}

		public override Slot GetSlot(IntVector2 position)
		{
			return default(Slot);
		}

		public override List<Slot> GetAllSlots()
		{
			return null;
		}
	}

	private class LevelRendererPair
	{
		public HiddenElementProvider levelProvider;

		public BorderTilemapRenderer renderer;

		public bool isHidden;
	}

	[SerializeField]
	private BorderTilemapRenderer holeRenderer;

	[SerializeField]
	private BorderTilemapRenderer level1Renderer;

	[SerializeField]
	private BorderTilemapRenderer level2Renderer;

	[SerializeField]
	private bool useHole;

	private HoleProvider holeProvider;

	private List<LevelRendererPair> levelRendererPairs;

	public void Render(Match3Game game)
	{
	}
}
