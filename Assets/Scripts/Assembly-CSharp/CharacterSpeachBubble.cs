using System;
using TMPro;
using UnityEngine;

public class CharacterSpeachBubble : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI label;

	[SerializeField]
	private CanvasGroup mainCanvasGroup;

	[NonSerialized]
	public string characterName;

	[NonSerialized]
	public CharacterAvatar avatar;

	public void SetAlpha(float alpha)
	{
	}

	public void SetActive(bool active)
	{
	}

	public void SetText(string text)
	{
	}
}
