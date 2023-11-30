using System;
using UnityEngine;

namespace GGMatch3
{
	[Serializable]
	public class SpriteSortingSettings
	{
		public int sortingLayerId;

		public int sortingOrder;

		public void Set(SpriteRenderer spriteRenderer)
		{
		}

		public void Set(SkinnedMeshRenderer meshRenderer)
		{
		}

		public void Set(MeshRenderer meshRenderer)
		{
		}
	}
}
