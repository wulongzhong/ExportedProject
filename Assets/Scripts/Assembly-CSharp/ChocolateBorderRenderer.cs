using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class ChocolateBorderRenderer : MonoBehaviour
{
	public class ChocolateTilesSlotsProvider : TilesSlotsProvider
	{
		public Match3Game game;

		public ChocolateBorderRenderer borderRenderer;

		private List<Slot> allSlots;

		public override int MaxSlots => 0;

		public void Init(Match3Game game, ChocolateBorderRenderer borderRenderer)
		{
		}

		public override Vector2 StartPosition(float slotSize)
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

	private ChocolateTilesSlotsProvider tilesSlotsProvider;

	[SerializeField]
	private TilesBorderRenderer borderRenderer;

	[SerializeField]
	private TilesBorderRenderer slotsRenderer;

	private bool ShouldBeRenderedForChocolate(Slot slot)
	{
		return false;
	}

	public void DisplayChocolate(Match3Game game)
	{
	}
}
