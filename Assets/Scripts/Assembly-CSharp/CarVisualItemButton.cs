using System;
using System.Collections.Generic;
using UnityEngine;

public class CarVisualItemButton : MonoBehaviour
{
	[SerializeField]
	private List<Transform> widgetsToHide;

	[SerializeField]
	private Transform buyButtonContanier;

	[NonSerialized]
	public CarModelPart part;

	[NonSerialized]
	private AssembleCarScreen screen;

	public void Init(CarModelPart part, AssembleCarScreen screen)
	{
	}

	private void SetPositionOfBuyButton()
	{
	}

	private void Update()
	{
	}

	public void HideButton()
	{
	}

	public void ButtonCallback_OnBuyButton()
	{
	}
}
