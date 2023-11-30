using System;
using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class VisualObjectParticles : MonoBehaviour
{
	public enum PositionType
	{
		ChangeSuccess = 0,
		BuySuccess = 1
	}

	[Serializable]
	public class PieceCreatorPool
	{
		public PositionType type;

		public GameObject prefab;
	}

	[SerializeField]
	private SpriteSortingSettings sortingLayer;

	[SerializeField]
	private List<PieceCreatorPool> pieceCreatorPools;

	private PieceCreatorPool GetPool(PositionType type)
	{
		return null;
	}

	public void CreateParticles(PositionType positionType, GameObject parent, VisualObjectBehaviour visualObjectBehaviour)
	{
	}

	public GameObject CreateParticles(PositionType positionType, GameObject parent)
	{
		return null;
	}
}
