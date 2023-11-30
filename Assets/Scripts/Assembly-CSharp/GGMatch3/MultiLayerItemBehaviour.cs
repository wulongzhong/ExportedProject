using System;
using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	public class MultiLayerItemBehaviour : SlotComponentBehavoiour
	{
		[Serializable]
		public class LayerSet
		{
			public ChipType chipType;

			public GameObject container;

			public List<LayerDesc> layers;

			public void HideAllLayers()
			{
			}

			public void ShowLayer(int index)
			{
			}
		}

		[Serializable]
		public class LayerDesc
		{
			public GameObject objectToShow;
		}

		[SerializeField]
		private List<LayerSet> layerSetList;

		[SerializeField]
		private Transform emptyChipTransform;

		[SerializeField]
		private Transform slotPatterTransform;

		private ChipType chipType;

		public void SetHasEmptyChip(bool hasEmptyChip)
		{
		}

		private LayerSet GetLayerSet(ChipType chipType)
		{
			return null;
		}

		public void HideAllLayers()
		{
		}

		public void SetLayerIndex(int layerIndex)
		{
		}

		public void SetPattern(Slot slot)
		{
		}

		public bool HasChipType(ChipType chipType)
		{
			return false;
		}

		public void Init(ChipType chipType, int layerIndex)
		{
		}

		public override void RemoveFromGame()
		{
		}
	}
}
