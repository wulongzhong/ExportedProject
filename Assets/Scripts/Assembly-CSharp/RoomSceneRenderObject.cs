using System;
using UnityEngine;

public class RoomSceneRenderObject : MonoBehaviour
{
	private struct AlphaChange
	{
		public bool isActive;

		public float startAlpha;

		public float endAlpha;

		public float duration;

		public float time;

		public DecorateRoomScreen screen;
	}

	[SerializeField]
	private Material textureMaterial;

	[NonSerialized]
	private float animationAlpha_;

	[NonSerialized]
	private float alpha_;

	private AlphaChange alphaChange;

	public float animationAlpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float alpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public void SetAlpha(float alpha)
	{
	}

	public void AnimateAlphaTo(float endAlpha, float duration, DecorateRoomScreen screen)
	{
	}

	private void ApplyAlpha(float alpha, float animationAlpha)
	{
	}

	private void Update()
	{
	}
}
