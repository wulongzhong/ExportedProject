using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class BubbleSlotsBorderRenderer : MonoBehaviour
{
	protected class BubbleSlotsProvider : TilesSlotsProvider
	{
		public Match3Game game;

		private List<Slot> allSlots;

		public override int MaxSlots => 0;

		public void Init(Match3Game game)
		{
		}

		public int CountSoapSlates()
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

	[SerializeField]
	private BorderTilemapRenderer tilemapRenderer;

	protected BubbleSlotsProvider soapSlotsProvider;

	private int lastBubbleCount;

	public void Render(Match3Game game)
	{
	}
}
