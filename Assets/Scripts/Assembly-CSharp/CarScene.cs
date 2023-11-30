using System;
using System.Collections.Generic;
using UnityEngine;

public class CarScene : MonoBehaviour
{
	[Serializable]
	public class DisplayTag
	{
		public enum DisplayType
		{
			Hide = 0,
			Show = 1
		}

		[SerializeField]
		public string tag;

		[SerializeField]
		public DisplayType display;
	}

	[SerializeField]
	public CarModel carModel;

	[SerializeField]
	public CarCamera camera;

	[SerializeField]
	public IntroSequence introSequence;

	[SerializeField]
	public StoryTimelineBehaviour introStoryTimeline;

	[SerializeField]
	public StoryTimelineBehaviour carCompleteStoryTimeline;

	[SerializeField]
	public StoryTimelineBehaviour debugStoryTimeline;

	[SerializeField]
	private BPCEMVisualisation lightSetupToTurnOff;

	[SerializeField]
	private List<StorylineActor> actors;

	[SerializeField]
	private List<StoryVideoSequence> animations;

	[SerializeField]
	private List<PhoneSprite> phoneSprites;

	[SerializeField]
	private List<Transform> propTransforms;

	[SerializeField]
	private List<StorySound> sounds;

	[SerializeField]
	private bool changePositionOfLocation;

	[SerializeField]
	private Vector3 locationPosition;

	[SerializeField]
	public List<DisplayTag> displayTags;

	public bool hasIntro => false;

	public StorylineActor GetActor(string name)
	{
		return null;
	}

	public StorySound GetSound(string name)
	{
		return null;
	}

	public void HideAllProps()
	{
	}

	public void ResetStateForAnimations()
	{
	}

	public Transform GetProp(string propName)
	{
		return null;
	}

	public void HideAllAnimations()
	{
	}

	public StoryVideoSequence GetAnimation(string name)
	{
		return null;
	}

	public PhoneSprite GetPhoneSprite(string name)
	{
		return null;
	}

	public void Init()
	{
	}

	public void ApplyLocationPosition(GameObject location)
	{
	}

	public T CreateFromPrefab<T>(GameObject prefab) where T : MonoBehaviour
	{
		return null;
	}
}
