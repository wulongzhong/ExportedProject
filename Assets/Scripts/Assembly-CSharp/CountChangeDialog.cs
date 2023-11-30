using System;
using TMPro;
using UnityEngine;

public class CountChangeDialog : MonoBehaviour
{
	public class InitArgs
	{
		public int count;

		public string title;

		public Action<int> onComplete;

		public int min;

		public int max;

		public Vector3 worldPositionToAttachTo;
	}

	[SerializeField]
	private TextMeshProUGUI titleLabel;

	[SerializeField]
	private TextMeshProUGUI countLabel;

	[SerializeField]
	private Transform dialogContainer;

	[NonSerialized]
	private int currentCount;

	[NonSerialized]
	private InitArgs initArgs;

	public static CountChangeDialog instance => null;

	public void Show(InitArgs initArgs)
	{
	}

	private void SetCurrentCount(int count)
	{
	}

	public void ButtonCallback_OnAdd()
	{
	}

	public void ButtonCallback_OnSubtract()
	{
	}

	public void ButtonCallback_OnExit()
	{
	}
}
