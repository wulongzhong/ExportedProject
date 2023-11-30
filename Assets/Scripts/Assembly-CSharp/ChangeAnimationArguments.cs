using System;

public struct ChangeAnimationArguments
{
	public DecoratingSceneConfig.AnimationSequence animation;

	public Action onComplete;

	public bool showWideBars;

	public bool isNoAnimation => false;

	public bool isAnimationAvailable => false;

	public static ChangeAnimationArguments NoAnimation => default(ChangeAnimationArguments);

	public static ChangeAnimationArguments Create(string roomName, string sceneObjectName)
	{
		return default(ChangeAnimationArguments);
	}
}
