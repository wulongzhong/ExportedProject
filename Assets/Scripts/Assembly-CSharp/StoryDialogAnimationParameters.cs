using System;

public class StoryDialogAnimationParameters
{
	public CarScene carScene;

	public StoryTimeline story;

	public Action<AnimationCompleteParameters> onDone;

	public int lastExecutedCommandIndex;
}
