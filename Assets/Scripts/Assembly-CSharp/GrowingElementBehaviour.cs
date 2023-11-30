using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class GrowingElementBehaviour : SlotComponentBehavoiour
{
	[SerializeField]
	private List<GrowingElementPot> growingElements;

	public void Init()
	{
	}

	public void StopAllAnimations()
	{
	}

	private GrowingElementPot GetElementPot(int elementIndex)
	{
		return null;
	}

	public void StartAnimationFor(int elementIndex)
	{
	}

	public void SetLevel(int level)
	{
	}

	public Vector3 WorldPositionForElement(int elementIndex)
	{
		return default(Vector3);
	}
}
