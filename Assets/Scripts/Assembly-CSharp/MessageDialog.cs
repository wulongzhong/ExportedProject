using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MessageDialog : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI headerLabel;

	[SerializeField]
	private TextMeshProUGUI textLabel;

	[SerializeField]
	private TextMeshProUGUI okLabel;

	[SerializeField]
	private TextMeshProUGUI yesLabel;

	[SerializeField]
	private TextMeshProUGUI noLabel;

	[SerializeField]
	private List<RectTransform> widgetsToHide;

	[SerializeField]
	private VisualStyleSet okStyle;

	[SerializeField]
	private VisualStyleSet yesNoStyle;

	private Action<bool> onComplete;

	public static MessageDialog instance => null;

	private static void SetLabel(TextMeshProUGUI label, string text)
	{
	}

	public void ShowOk(string header, string text, string ok, Action<bool> onComplete)
	{
	}

	public void ShowYesNo(string header, string text, string yes, string no, Action<bool> onComplete)
	{
	}

	private void ShowOnNav()
	{
	}

	private void OnComplete(bool isYes)
	{
	}

	public void Callback_OnOk()
	{
	}

	public void Callback_OnYes()
	{
	}

	public void Callback_OnNo()
	{
	}
}
