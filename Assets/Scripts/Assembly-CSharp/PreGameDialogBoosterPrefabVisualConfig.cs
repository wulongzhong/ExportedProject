using System.Collections.Generic;
using GGMatch3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PreGameDialogBoosterPrefabVisualConfig : MonoBehaviour
{
	[SerializeField]
	private Image image;

	[SerializeField]
	private VisualStyleSet ownedStyle;

	[SerializeField]
	private VisualStyleSet notOwnedStyle;

	[SerializeField]
	private List<RectTransform> hideAtStart;

	[SerializeField]
	private TextMeshProUGUI label;

	public void Init(ChipType chipTypeUsedForRepresentation)
	{
	}

	public void SetLabel(string text)
	{
	}

	public void SetStyle(bool owned)
	{
	}
}
