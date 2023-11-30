using System;
using UnityEngine;
using UnityEngine.UI;

public class UIBoardShadow : MonoBehaviour
{
	[SerializeField]
	private Image shadowImage;

	[SerializeField]
	private Color normalColor;

	[NonSerialized]
	private Match3Game game;

	public void Init(Match3Game game)
	{
	}

	private void LateUpdate()
	{
	}

	private void SetPosition(Match3Game game)
	{
	}
}
