using System;
using System.Collections.Generic;
using UnityEngine;

public class PanelMenuItem
{
	public string text;

	public bool hasCheck;

	public Sprite sprite;

	public Action<PanelMenuItem> onClick;

	public List<PanelMenuItem> subitems;

	public List<int> selectedIndex;

	public bool isSubmenu => false;
}
