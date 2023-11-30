using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VariationButton : MonoBehaviour
{
	[SerializeField]
	public Image image;

	[SerializeField]
	public Image background;

	[SerializeField]
	public int topMargin;

	[SerializeField]
	public int bottomMargin;

	[SerializeField]
	public int leftMargin;

	[SerializeField]
	public int rightMargin;

	[SerializeField]
	public List<Sprite> sprites;

	private float _imageHeight;

	private float _ratio;

	[NonSerialized]
	private int variationIndex;

	[NonSerialized]
	private VisualObjectBehaviour visualObjectBehaviour;

	private VariationPanel variationPanel;

	public float ratio => 0f;

	public float imageWidth
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float imageHeight
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public void Init(VariationPanel variationPanel, VisualObjectBehaviour visualObjectBehaviour, int variationIndex)
	{
	}

	public void Fit()
	{
	}

	public void Resize()
	{
	}

	public void OnClick()
	{
	}
}
