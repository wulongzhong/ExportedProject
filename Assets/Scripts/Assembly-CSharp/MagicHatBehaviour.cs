using System;
using System.Collections.Generic;
using GGMatch3;
using TMPro;
using UnityEngine;

public class MagicHatBehaviour : SlotComponentBehavoiour
{
	[Serializable]
	public class ChipTypeLook
	{
		public ChipType chipType;

		public List<Transform> widgetsToShow;
	}

	[SerializeField]
	private Transform bunnyTransform;

	[SerializeField]
	private TextMeshPro text;

	[SerializeField]
	private Transform nonCountObject;

	[SerializeField]
	private List<ChipTypeLook> chipLooks;

	public Vector3 bunnyScale
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 bunnyOffset
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public void Init(ChipType chipType)
	{
	}

	public void SetCountActive(bool active)
	{
	}

	public void SetCount(int count)
	{
	}
}
