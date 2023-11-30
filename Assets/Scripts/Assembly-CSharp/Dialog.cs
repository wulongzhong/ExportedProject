using System;
using TMPro;
using UnityEngine;

public class Dialog : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI yesLabel;

	[SerializeField]
	private TextMeshProUGUI noLabel;

	[SerializeField]
	private TextMeshProUGUI okLabel;

	[SerializeField]
	private TextMeshProUGUI textLabel;

	[SerializeField]
	private Transform[] widgetsToHide;

	[SerializeField]
	private VisualStyleSet yesNoStyle;

	[SerializeField]
	private VisualStyleSet okStyle;

	private Action<bool> onComplete;

	public static Dialog instance => null;

	public void Show(string text, string yes, string no, Action<bool> onComplete)
	{
	}

	public void Show(string text, string ok, Action<bool> onComplete)
	{
	}

	private void InitYesNo(string text, string yes, string no, Action<bool> onComplete)
	{
	}

	private void InitOk(string text, string ok, Action<bool> onComplete)
	{
	}

	private void Finish(bool success)
	{
	}

	public void ButtonCallback_OnYes()
	{
	}

	public void ButtonCallback_OnNo()
	{
	}
}
