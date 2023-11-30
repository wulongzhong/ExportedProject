using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogList : MonoBehaviour
{
	[SerializeField]
	private ComponentPool itemsPool;

	[SerializeField]
	private RectTransform container;

	[SerializeField]
	private ScrollRect scrollrect;

	private int _003CselectedIndex_003Ek__BackingField;

	private List<OpenListDialog.ListItem> _003Clist_003Ek__BackingField;

	private int _003CdialogIndex_003Ek__BackingField;

	public Action<DialogList> onSelectionChange;

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

	public List<OpenListDialog.ListItem> list
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public int dialogIndex
	{
		get
		{
			return 0;
		}
		protected set
		{
		}
	}

	public void Init(List<OpenListDialog.ListItem> list, int dialogIndex, int selectedIndex, Action<DialogList> onSelectionChange)
	{
	}

	private void Callback_OnItemClick(OpenListDialogItem uiItem)
	{
	}
}
