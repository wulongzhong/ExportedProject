using System;
using System.Collections.Generic;
using UnityEngine;

public class SlotColorSlateBehaviour : MonoBehaviour
{
	[Serializable]
	public class SpriteDescriptor
	{
		public string spriteName;

		public SpriteRenderer sprite;
	}

	[SerializeField]
	private SpriteRenderer sprite;

	[SerializeField]
	private List<SpriteDescriptor> sprites;

	public void Init(string spriteName)
	{
	}
}
