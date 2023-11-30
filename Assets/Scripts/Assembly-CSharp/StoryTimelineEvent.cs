using System;
using UnityEngine;

[Serializable]
public class StoryTimelineEvent
{
	public enum EventType
	{
		ShowAnimation = 0,
		Message = 1,
		WaitToClick = 2,
		ShowPhone = 3,
		HideUI = 4,
		ChangePhoneState = 5,
		HideActors = 6,
		HidePhone = 7,
		ShowProp = 8,
		HideProp = 9,
		ShowMoreTextIcon = 10,
		ShowSkipButton = 11,
		HideSkipButton = 12,
		MoveActorOut = 13,
		HideActor = 14,
		DebugCheckpoint = 15,
		CloseAllHinges = 16,
		CloseHinge = 17,
		OpenHinge = 18,
		HideActorText = 19,
		HidePhoneInstant = 20,
		FadeOverlay = 21
	}

	[SerializeField]
	public EventType eventType;

	[SerializeField]
	public StoryMessage storyMessage;

	[SerializeField]
	public string animationName;

	[SerializeField]
	public PhoneState phoneState;

	[SerializeField]
	public string propName;

	[SerializeField]
	public float maxWaitTime;

	[SerializeField]
	public Color overlayColor;

	[SerializeField]
	public bool fadeIn;
}
