using System;
using System.Collections.Generic;
using UnityEngine;

public class Match3GameStarter : MonoBehaviour
{
	[SerializeField]
	private Match3Game gamePrefab;

	[SerializeField]
	private Transform parent;

	[NonSerialized]
	private List<GameObject> createdGameObjects;

	public void DestroyCreatedGameObjects()
	{
	}

	public Match3Game CreateGame()
	{
		return null;
	}

	public void GoToMainScene()
	{
	}
}
