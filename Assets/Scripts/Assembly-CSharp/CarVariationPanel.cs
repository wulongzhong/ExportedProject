using System;
using UnityEngine;
using UnityEngine.UI;

public class CarVariationPanel : MonoBehaviour
{
	public struct InitParams
	{
		public bool isPurchased;

		public AssembleCarScreen screen;

		public CarModelInfo.VariantGroup variantGroup;

		public Action<CarVariationPanel> onClosed;

		public Action<CarVariationPanel> onChange;

		public bool showBackground;

		public InputHandler inputHandler;

		public void CallOnClosed(CarVariationPanel panel)
		{
		}

		public void CallOnChange(CarVariationPanel panel)
		{
		}
	}

	[SerializeField]
	private ComponentPool buttonPool;

	[SerializeField]
	private ComponentPool variationButtonPool;

	[SerializeField]
	private Transform variationPanel;

	[SerializeField]
	private float buttonPadding;

	[SerializeField]
	private RectTransform variationContainer;

	[SerializeField]
	private RectTransform maxWidthContanier;

	[SerializeField]
	private Transform backgroundClickArea;

	[SerializeField]
	private ScrollRect scroll;

	[SerializeField]
	private RectTransform variationPanelConnectorToButton;

	[NonSerialized]
	public InitParams initParams;

	private int _003CvariationIndexAtStart_003Ek__BackingField;

	private int _003CselectedVariation_003Ek__BackingField;

	private bool _003CisVariationChanged_003Ek__BackingField;

	public CarModelInfo.VariantGroup variantGroup => null;

	public int variationIndexAtStart
	{
		get
		{
			return 0;
		}
		protected set
		{
		}
	}

	public int selectedVariation
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool isVariationChanged
	{
		get
		{
			return false;
		}
		protected set
		{
		}
	}

	public void Show(InitParams initParams)
	{
	}

	private void SetVariant(CarModelInfo.VariantGroup.Variation variation)
	{
	}

	private void SetVariationPanelPositionOverSelectedButton()
	{
	}

	private void OnInputHandlerClick(Vector2 position)
	{
	}

	public void OnBackgroundClick()
	{
	}

	public void Color_OnChange(CarVariationButton button)
	{
	}

	public void ButtonCallback_OnChange(CarVariationButton button)
	{
	}

	private void OnDisable()
	{
	}
}
