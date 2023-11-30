using System;
using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	public class SolidPieceRenderer : SlotComponentBehavoiour
	{
		[Serializable]
		public class ChipTypeSettings
		{
			public ChipType chipType;

			public GameObject obj;

			public Vector3 rotation;
		}

		[SerializeField]
		private List<ChipTypeSettings> chipTypeSettings;

		[SerializeField]
		private List<SpriteRenderer> boxSprites;

		[SerializeField]
		private Transform rotator;

		[NonSerialized]
		private Chip chip;

		public void Init(Chip chip)
		{
		}

		public void Init(ChipType chipType)
		{
		}

		public void ResetVisually()
		{
		}

		public override void RemoveFromGame()
		{
		}

		private void UpdateLook()
		{
		}

		private void Update()
		{
		}
	}
}
