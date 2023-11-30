using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class CarpetSpreadBehaviour : MonoBehaviour
{
	public class RendererTilesSlotsProvider : TilesSlotsProvider
	{
		public CarpetSpread.SlotData[] slots;

		public Match3Game game;

		private List<Slot> innerSlots;

		public override int MaxSlots => 0;

		public void Init(Match3Game game, CarpetSpread.SlotData[] slots)
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

		public override List<Slot> GetAllSlots()
		{
			return null;
		}
	}

	[SerializeField]
	private List<TilesBorderRenderer> borderRenderers;

	[SerializeField]
	private TilesBorderRenderer slotsRenderer;

	private RendererTilesSlotsProvider slotsProvider;

	public void Init(Match3Game game, CarpetSpread carpetSpread)
	{
	}

	public void RefreshCarpet()
	{
	}
}
