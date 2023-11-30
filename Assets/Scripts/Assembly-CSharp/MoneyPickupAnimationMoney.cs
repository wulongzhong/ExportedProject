using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyPickupAnimationMoney : MonoBehaviour
{
	public enum Style
	{
		Coin = 0,
		Star = 1
	}

	[Serializable]
	public class StylePool
	{
		public Style style;

		public ComponentPool pool;
	}

	[SerializeField]
	private RectTransform starStyle;

	[SerializeField]
	private RectTransform coinStyle;

	[SerializeField]
	private List<StylePool> stylePools;

	[NonSerialized]
	public int index;

	[NonSerialized]
	public Style style;

	[SerializeField]
	private TextMeshProUGUI bottomLabel;

	[NonSerialized]
	public Vector3 startLocalPosition;

	[NonSerialized]
	public Vector3 startTravelScale;

	private StylePool GetStylePool(Style style)
	{
		return null;
	}

	public void SetStyle(Style style)
	{
	}

	public void Init(int index, Vector3 startLocalPosition)
	{
	}

	public void Init(int index, Vector3 startLocalPosition, Style style, int count)
	{
	}
}
