using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AnimationBeats
{
	[Serializable]
	public class Animation
	{
		public enum AnimationType
		{
			PlayAnimation = 0,
			Say = 1,
			LookAtRoom = 2,
			LookAtCharacter = 3,
			Animate = 4,
			StopLooking = 5,
			SetTransform = 6,
			LookAtMarker = 7,
			SetTransformToMarker = 8,
			LookAtPosition = 9
		}

		public enum Character
		{
			C0 = 0,
			C1 = 1
		}

		public Character character;

		public AnimationType type;

		public string stringValue;

		public Vector3 position;

		public Vector3 rotation;

		public float duration;

		public float transitionDuration;

		public float startOffset;
	}

	[Serializable]
	public class Beat
	{
		[SerializeField]
		private string name;

		public List<Animation> animations;
	}

	[Serializable]
	public class TestSetup
	{
		public List<string> objectsToOwn;

		public bool ShouldBeOwned(string name)
		{
			return false;
		}
	}

	[Serializable]
	public class Sequence
	{
		[Serializable]
		public class MarkerTransform
		{
			public string name;

			public Vector3 position;

			public Vector3 rotationEuler;
		}

		public string groupName;

		public string animationName;

		public List<Beat> beats;

		public bool isExpressionSet;

		public string expressionString;

		public string openAnimationFor;

		public TestSetup testSetup;

		[SerializeField]
		public List<MarkerTransform> markers;
	}
}
