using UnityEngine;

public class StoryTimelineBehaviour : MonoBehaviour
{
	[SerializeField]
	public bool hasError;

	[SerializeField]
	public string errorLine;

	[SerializeField]
	private string storyTimelineStrig;

	[SerializeField]
	public StoryTimeline storyTimeline;

	[SerializeField]
	public bool animateInCameraOnEnd;

	[SerializeField]
	public bool animateInIfCanceled;

	[SerializeField]
	public bool fadeOutFromBlackAtEnd;

	[SerializeField]
	public bool autoSetHorizontalAngle;
}
