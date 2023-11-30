using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuPanelItem : MonoBehaviour
{
	[SerializeField]
	private Image spriteImage;

	[SerializeField]
	private TextMeshProUGUI label;

	[SerializeField]
	private Transform submenuArrow;

	[SerializeField]
	private Transform check;

	private PanelMenuItem _003Citem_003Ek__BackingField;

	private int _003Cindex_003Ek__BackingField;

	[NonSerialized]
	private MenuPanel panel;

	public PanelMenuItem item
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public int index
	{
		get
		{
			return 0;
		}
		protected set
		{
		}
	}

	public void Init(PanelMenuItem item, int index, MenuPanel panel)
	{
	}

	public void ButtonCallback_OnClick()
	{
	}
}
