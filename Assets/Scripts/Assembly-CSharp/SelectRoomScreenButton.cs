using System;
using TMPro;
using UnityEngine;

public class SelectRoomScreenButton : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI roomNameLabel;

	[NonSerialized]
	private RoomsDB.Room room;

	[NonSerialized]
	private SelectRoomScreen roomScreen;

	public void Init(RoomsDB.Room room, SelectRoomScreen roomScreen)
	{
	}

	public void ButtonCallback_OnClick()
	{
	}
}
