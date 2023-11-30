using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class ColorSlotsBorderRenderer : MonoBehaviour
{
	public class ColorSlotsTilesSlotsProvider : TilesSlotsProvider
	{
		public Match3Game game;

		public ColorSlotsBorderRenderer borderRenderer;

		private List<Slot> allSlots;

		public override int MaxSlots => 0;

		public void Init(Match3Game game, ColorSlotsBorderRenderer borderRenderer)
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

		private bool IsOccupied(GGMatch3.Slot levelSlot)
		{
			return false;
		}

		public override List<Slot> GetAllSlots()
		{
			return null;
		}
	}

	private ColorSlotsTilesSlotsProvider tilesSlotsProvider;

	[SerializeField]
	private List<TilesBorderRenderer> borderRenderer;

	[SerializeField]
	private List<TilesBorderRenderer> slotsRenderer;

	private int lastColoredSlates;

	private bool ShouldBeRendered(Slot slot)
	{
		return false;
	}

	public void DisplayChocolate(Match3Game game)
	{
	}
}
