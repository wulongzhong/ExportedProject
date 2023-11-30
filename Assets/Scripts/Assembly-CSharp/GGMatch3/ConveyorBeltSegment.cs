using UnityEngine;

namespace GGMatch3
{
	public class ConveyorBeltSegment : MonoBehaviour
	{
		[SerializeField]
		private TiledSpriteRenderer tiledSegment;

		[SerializeField]
		private SpriteRenderer start;

		[SerializeField]
		private SpriteRenderer end;

		public void SetTile(float tile)
		{
		}

		public void SetColor(Color color)
		{
		}

		public Color GetColor()
		{
			return default(Color);
		}

		public void Init(int numSlots, Vector2 slotSize)
		{
		}

		private void SetScaleToMatch(SpriteRenderer sprite)
		{
		}
	}
}
