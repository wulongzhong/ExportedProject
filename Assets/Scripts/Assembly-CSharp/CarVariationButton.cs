using System;
using UnityEngine;
using UnityEngine.UI;

public class CarVariationButton : MonoBehaviour
{
	[SerializeField]
	public Image image;

	[SerializeField]
	private Image topImage;

	[NonSerialized]
	public int variationIndex;

	[NonSerialized]
	private CarVariationPanel variationPanel;

	[NonSerialized]
	public ChangeColor changeColor;

	[NonSerialized]
	public int presetColorIndex;

	[NonSerialized]
	public Action<CarVariationButton> onSelected;

	public void Init(Action<CarVariationButton> onSelected, ChangeColor changeColor, int presetColorIndex, ChangeColor.PresetColor presetColor)
	{
	}

	public void Init(CarVariationPanel variationPanel, int variationIndex, CarModelInfo.VariantGroup.Variation variation)
	{
	}

	public void OnClick()
	{
	}
}
