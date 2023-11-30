using System;
using GGMatch3;
using TMPro;
using UnityEngine;

public class OutOfMovesDialog : MonoBehaviour
{
	public delegate void OutOfMovesDelegate(OutOfMovesDialog dialog);

	[SerializeField]
	private string playButtonFormat;

	[SerializeField]
	private string movesCountFormat;

	[SerializeField]
	private TextMeshProUGUI buttonLabel;

	[SerializeField]
	private TextMeshProUGUI movesCounterLabel;

	[SerializeField]
	private TextMeshProUGUI coinsLabel;

	[SerializeField]
	private ComponentPool goalsPool;

	[SerializeField]
	private ComponentPool powerupsPool;

	[SerializeField]
	private RankedBoostersContainer rankedBoosters;

	[NonSerialized]
	public Match3Game game;

	private OutOfMovesDelegate onYes;

	private OutOfMovesDelegate onNo;

	public BuyMovesPricesConfig.OfferConfig offer;

	private MultiLevelGoals goals;

	public void Show(BuyMovesPricesConfig.OfferConfig offer, Match3Game game, MultiLevelGoals goals, OutOfMovesDelegate onYes, OutOfMovesDelegate onNo)
	{
	}

	public void Hide()
	{
	}

	public void OnBuyClicked()
	{
	}

	public void OnNotBuyClicked()
	{
	}

	public void Init(BuyMovesPricesConfig.OfferConfig offer)
	{
	}

	public void OnEnable()
	{
	}
}
