using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SaveListDialog : MonoBehaviour
{
	public class InitParams
	{
		public List<OpenListDialog.ListItem> items;

		public Action<DialogResult> onDone;

		public string okLabel;

		public string inputText;
	}

	public struct DialogResult
	{
		public bool success;

		public SaveListDialog dialog;
	}

	[SerializeField]
	private ComponentPool itemsPool;

	[SerializeField]
	private RectTransform container;

	[SerializeField]
	private ScrollRect scrollrect;

	[SerializeField]
	private TextMeshProUGUI okButtonLabel;

	[SerializeField]
	private TMP_InputField inputField;

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

	public static SaveListDialog instance => null;

	public string text => null;

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
