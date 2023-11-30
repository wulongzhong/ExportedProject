using System;
using System.Collections.Generic;
using UnityEngine;

public class SpriteExtractor : MonoBehaviour
{
	[Serializable]
	public class SpriteUsage
	{
		public Sprite sprite;

		public string packingTag;

		public List<Transform> usages;
	}

	public List<SpriteUsage> spriteUsages;

	public void FindAllSprites()
	{
	}

	private void AddSprite(Transform root, Dictionary<Sprite, SpriteUsage> map, Sprite sprite)
	{
	}

	private void FindSprites(Transform root, Dictionary<Sprite, SpriteUsage> map)
	{
	}
}
