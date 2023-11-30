using System;
using System.Collections.Generic;
using UnityEngine;

public class ChipFeatherBehaviour : MonoBehaviour
{
	[Serializable]
	public class ColorSetup
	{
		public ItemColor itemColor;

		public SpriteRenderer spriteRenderer;

		public Color color;

		public void Apply()
		{
		}
	}

	[SerializeField]
	private List<ColorSetup> colors;

	public void Init(ItemColor itemColor)
	{
	}
}
