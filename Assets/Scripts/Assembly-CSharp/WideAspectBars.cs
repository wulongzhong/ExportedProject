using UnityEngine;

public class WideAspectBars : MonoBehaviour
{
	private struct AlphaState
	{
		public bool isActive;

		public float startAlpha;

		public float endAlpha;

		public float time;

		public float duration;

		public bool hideAtEnd;

		public bool notActive => false;
	}

	[SerializeField]
	private CanvasGroup canvasGroup;

	private AlphaState state;

	public void Hide()
	{
	}

	public void SetAlpha(float alpha)
	{
	}

	public void AnimateShow()
	{
	}

	public void AnimateHide()
	{
	}

	private void Update()
	{
	}
}
