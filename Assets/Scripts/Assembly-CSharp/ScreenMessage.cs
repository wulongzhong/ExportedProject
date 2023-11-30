using UnityEngine;
using UnityEngine.UI;

public class ScreenMessage : MonoBehaviour
{
	[SerializeField]
	private Animator animator;

	[SerializeField]
	private Text text;

	private ScreenMessagePanel panel;

	public void Init(ScreenMessagePanel panel, string text)
	{
	}

	public void Play()
	{
	}

	public void OnAnimationEnd()
	{
	}
}
