using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScrollableSelectCarScreenButton : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI titleLabel;

	[SerializeField]
	private TextMeshProUGUI descriptionLabel;

	[SerializeField]
	private List<RectTransform> widgetsToHide;

	[SerializeField]
	private RectTransform lockedStyle;

	[SerializeField]
	private RectTransform completeStyle;

	[SerializeField]
	private RectTransform unlockAnimation;

	[SerializeField]
	private RectTransform passAnimation;

	[SerializeField]
	public float unlockAnimationDuration;

	[SerializeField]
	public float passAnimationDuration;

	[SerializeField]
	private Image mainImage;

	[NonSerialized]
	public CarsDB.Car car;

	[NonSerialized]
	private CarsDB carsDB;

	public void Init(CarsDB.Car car, CarsDB carsDB)
	{
	}

	public void ShowPassedAnimation()
	{
	}

	public void ShowUnlockAnimation()
	{
	}

	public void ShowOpenNotPassed()
	{
	}

	public void ShowLocked()
	{
	}

	public void Callback_OnClick()
	{
	}
}
