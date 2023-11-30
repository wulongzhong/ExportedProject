using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OpenListDialog : MonoBehaviour
{
	public delegate List<ListItem> SublistDelegate(ListItem item);

	public struct ListItem
	{
		public Sprite sprite;

		public string text;

		public int index;

		public object payload;

		public SublistDelegate sublistDelegate;
	}

	public class InitParams
	{
		public int selectedIndex;

		public List<ListItem> items;

		public Action<DialogResult> onDone;

		public string okLabel;
	}

	public struct DialogResult
	{
		public bool success;

		public OpenListDialog dialog;
	}

	[SerializeField]
	private ComponentPool itemsPool;

	[SerializeField]
	private RectTransform container;

	[SerializeField]
	private ScrollRect scrollrect;

	[SerializeField]
	private TextMeshProUGUI okButtonLabel;

	private InitParams _003CinitParams_003Ek__BackingField;

	private int _003CselectedIndex_003Ek__BackingField;

	public InitParams initParams
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public int selectedIndex
	{
		get
		{
			return 0;
		}
		protected set
		{
		}
	}

	public static OpenListDialog instance => null;

	public void Show(InitParams initParams)
	{
	}

	private void Init(InitParams initParams)
	{
	}

	private void Callback_OnItemClick(OpenListDialogItem uiItem)
	{
	}

	public void ButtonCallback_OnBack()
	{
	}

	public void ButtonCallback_OnSuccess()
	{
	}
}
