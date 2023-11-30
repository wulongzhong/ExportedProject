using UnityEngine;

public class TasksButton : MonoBehaviour
{
	[SerializeField]
	private Transform animationTransform;

	[SerializeField]
	private bool alwaysHideAnimation;

	[SerializeField]
	private Transform arrowAnimationTransform;

	[SerializeField]
	private Transform canNotBuyTransform;

	[SerializeField]
	private Transform activePlayButtonVersion;

	[SerializeField]
	private Transform nonActivePlayButtonVersion;

	public void Show(CarScene scene, MainConfig config)
	{
	}

	public void HideAnimation()
	{
	}
}
