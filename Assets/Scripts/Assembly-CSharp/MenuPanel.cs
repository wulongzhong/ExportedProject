using System;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanel : MonoBehaviour
{
	[SerializeField]
	private ComponentPool itemsPool;

	[SerializeField]
	private RectTransform container;

	[NonSerialized]
	private List<PanelMenuItem> list;

	[NonSerialized]
	private int menuIndex;

	[NonSerialized]
	private MenuDialog dialog;

	public float totalHeight => 0f;

	public Vector3 LocalPositionForIndex(int index)
	{
		return default(Vector3);
	}

	public void Init(List<PanelMenuItem> list, int menuIndex, MenuDialog dialog)
	{
	}

	public void Callback_OnItemClicked(MenuPanelItem menuItem)
	{
	}
}
