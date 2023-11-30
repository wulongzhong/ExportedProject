using System;
using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class BurriedElementBehaviour : SlotComponentBehavoiour
{
	[Serializable]
	public class ElementDescriptor
	{
		public IntVector2 size;

		public Transform image;
	}

	[SerializeField]
	private List<ElementDescriptor> elements;

	[SerializeField]
	public Transform rotationTransform;

	public void Init(LevelDefinition.BurriedElement element)
	{
	}

	public override void RemoveFromGame()
	{
	}
}
