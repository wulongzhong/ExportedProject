using System;
using UnityEngine;

[Serializable]
public class StorylineActor
{
	[SerializeField]
	public string name;

	[SerializeField]
	public Sprite sprite;

	[SerializeField]
	public bool isLeft;

	[SerializeField]
	public Color textColor;
}
