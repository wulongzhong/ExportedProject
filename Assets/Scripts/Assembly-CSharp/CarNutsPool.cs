using System;
using UnityEngine;

[Serializable]
public class CarNutsPool
{
	[SerializeField]
	private ComponentPool nutComponents;

	public float nutSize => 0f;

	public void Clear()
	{
	}

	public CarNut NextNut()
	{
		return null;
	}
}
