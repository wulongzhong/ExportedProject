using System.Collections.Generic;
using UnityEngine;

public class ToggleSoundsButton : MonoBehaviour
{
	public enum SoundType
	{
		Music = 0,
		SoundFx = 1
	}

	[SerializeField]
	private SoundType soundType;

	[SerializeField]
	private List<Transform> widgetsToHide;

	[SerializeField]
	private VisualStyleSet onStyle;

	[SerializeField]
	private VisualStyleSet offStyle;

	private bool isOff
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void OnEnable()
	{
	}

	public void ButtonCallback_OnClick()
	{
	}

	private void UpdateVisualState()
	{
	}
}
