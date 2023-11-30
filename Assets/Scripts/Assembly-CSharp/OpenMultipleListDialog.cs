using System;
using System.Collections.Generic;
using UnityEngine;

public class OpenMultipleListDialog : MonoBehaviour
{
	public class InitArguments
	{
		public List<OpenListDialog.ListItem> items;

		public Action<OpenMultipleListDialog, bool> onComplete;
	}

	[SerializeField]
	private ComponentPool itemsPool;

	[SerializeField]
	private RectTransform container;

	[NonSerialized]
	private InitArguments initArguments;

	[NonSerialized]
	private List<int> selectedIndexesList;

	public static OpenMultipleListDialog instance => null;

	public OpenListDialog.ListItem lastListSelectedItem => default(OpenListDialog.ListItem);

	public void Show(InitArguments initArguments)
	{
	}

	private void Init()
	{
	}

	private void OnSelectionChange(DialogList list)
	{
	}

	public void ButtonCallback_OnOk()
	{
	}

	public void ButtonCallback_OnCancel()
	{
	}
}
