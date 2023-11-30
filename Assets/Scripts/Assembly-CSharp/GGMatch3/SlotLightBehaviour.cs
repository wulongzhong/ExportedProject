using UnityEngine;

namespace GGMatch3
{
	public class SlotLightBehaviour : SlotComponentBehavoiour
	{
		[SerializeField]
		private SpriteRenderer lightSprite;

		[SerializeField]
		private SpriteRenderer slotBckSprite;

		public void InitWithSlotComponent(LightSlotComponent slotComponent)
		{
		}

		public void Init(Slot slot, bool isBackPatternEnabled)
		{
		}

		public static void SetActive(SpriteRenderer beh, bool active)
		{
		}

		public static void SetActive(MonoBehaviour beh, bool active)
		{
		}

		public void SetLight(float intensity)
		{
		}
	}
}
