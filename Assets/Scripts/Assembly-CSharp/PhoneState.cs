using System;
using UnityEngine;

[Serializable]
public class PhoneState
{
	[SerializeField]
	public StoryDialogPhone.PhoneState state;

	[SerializeField]
	public string caller;

	[SerializeField]
	public string messageSpriteName;
}
