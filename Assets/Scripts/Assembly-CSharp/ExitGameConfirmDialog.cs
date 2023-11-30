using System;
using GGMatch3;
using UnityEngine;

public class ExitGameConfirmDialog : MonoBehaviour
{
	public struct ExitGameConfirmArguments
	{
		public Action<bool> onCompleteCallback;

		public MultiLevelGoals goals;

		public Match3Game game;
	}

	[SerializeField]
	private ComponentPool goalPrefabsPool;

	[SerializeField]
	private RankedBoostersContainer rankedContainer;

	private ExitGameConfirmArguments arguments;

	public void Show(ExitGameConfirmArguments arguments)
	{
	}

	public void Init()
	{
	}

	public void OnEnable()
	{
	}

	public void ButtonCallback_OnExit()
	{
	}

	public void ButtonCallback_OnQuit()
	{
	}
}
