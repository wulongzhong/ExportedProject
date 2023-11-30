using System;
using System.Collections.Generic;
using UnityEngine;

public class MenuDialog : MonoBehaviour
{
	public class InitParams
	{
		public List<PanelMenuItem> items;

		public Action<bool> onDone;

		public Vector3 position;

		public List<int> selectedIndexesList;
	}

	[SerializeField]
	private Transform selectedSlot;

	[SerializeField]
	private ComponentPool menuPanelPool;

	[NonSerialized]
	public List<int> selectedIndexesList;

	[NonSerialized]
	private InitParams initParams;

	public static MenuDialog instance => null;

	public void Show(InitParams initParams)
	{
	}

	private void Init(InitParams initParams)
	{
	}

	public void SelectIndex(int menuIndex, int subitemIndex)
	{
	}

	public void ButtonCallback_OnExit()
	{
	}

	public void Callback_InvokeMenuItem(MenuPanelItem menuItem)
	{
	}

	private void Exit(bool isButtonPressed)
	{
	}
}
