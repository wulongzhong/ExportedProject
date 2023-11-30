using System;
using UnityEngine;

public class VariationPanel : MonoBehaviour
{
	public struct InitParams
	{
		public bool isPurchased;
	}

	[SerializeField]
	private ComponentPool buttonPool;

	[SerializeField]
	private float buttonPadding;

	[NonSerialized]
	private DecorateRoomScreen screen;

	[NonSerialized]
	public InitParams initParams;

	[NonSerialized]
	public DecorateRoomSceneVisualItem uiItem;

	private int _003CvariationIndexAtStart_003Ek__BackingField;

	private bool _003CisVariationChanged_003Ek__BackingField;

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

	public void Show(DecorateRoomScreen screen, DecorateRoomSceneVisualItem uiItem, InitParams initParams)
	{
	}

	public void OnBackgroundClick()
	{
	}

	public void ButtonCallback_OnChange()
	{
	}
}
