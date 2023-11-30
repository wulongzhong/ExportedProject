using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class StoryTimeline
{
	[SerializeField]
	public List<StoryTimelineEvent> events;

	[SerializeField]
	public bool animateInCameraOnEnd;

	[SerializeField]
	public bool animateInIfCanceled;

	[SerializeField]
	public bool changeHorizontalAngleOfCameraOnEnd;

	[SerializeField]
	public float horizontalAngleOnEnd;

	[SerializeField]
	public bool fadeOutFromBlackAtEnd;

	[SerializeField]
	public bool autoSetHorizontalAngle;

	[SerializeField]
	public bool hasEvents => false;
}
