using System;
using System.Collections.Generic;
using Expressive;
using Expressive.Expressions;
using Expressive.Functions;
using UnityEngine;

public class DecoratingSceneConfig : ScriptableObjectSingleton<DecoratingSceneConfig>
{
	[Serializable]
	public class CharacterAnimationLine
	{
		public enum LineType
		{
			NamedAnimation = 0,
			Pause = 1
		}

		[SerializeField]
		public LineType lineType;

		[SerializeField]
		public bool isCharacterVisible;

		[SerializeField]
		public string namedAnimationRoom;

		[SerializeField]
		public string namedAnimationName;

		[SerializeField]
		public int namedAnimationIndex;

		[SerializeField]
		public float pauseDuration;

		public CharacterAnimation GetCharacterAnimation(DecoratingSceneConfig config)
		{
			return null;
		}
	}

	[Serializable]
	public class CharacterAnimationSequence
	{
		[SerializeField]
		public string characterName;

		[SerializeField]
		public List<CharacterAnimationLine> animationLines;
	}

	[Serializable]
	public class AnimationSequence
	{
		private class ExpressionFunctions
		{
			internal class UnlockedFunction : IFunction
			{
				public ExpressionFunctions functions;

				private IDictionary<string, object> _003CVariables_003Ek__BackingField;

				public IDictionary<string, object> Variables
				{
					get
					{
						return null;
					}
					set
					{
					}
				}

				public string Name => null;

				public object Evaluate(IExpression[] parameters, ExpressiveOptions options)
				{
					return null;
				}
			}

			internal class OwnedFunction : IFunction
			{
				public ExpressionFunctions functions;

				private IDictionary<string, object> _003CVariables_003Ek__BackingField;

				public IDictionary<string, object> Variables
				{
					get
					{
						return null;
					}
					set
					{
					}
				}

				public string Name => null;

				public object Evaluate(IExpression[] parameters, ExpressiveOptions options)
				{
					return null;
				}
			}

			private UnlockedFunction unlockedFunction;

			private OwnedFunction ownedFunction;

			private DecoratingScene scene;

			public void Start(DecoratingScene scene)
			{
			}

			public void End()
			{
			}

			public void RegisterFunctions(Expression expression)
			{
			}

			public bool IsUnlocked(string name)
			{
				return false;
			}

			public bool IsOwned(string name)
			{
				return false;
			}
		}

		private static ExpressionFunctions expressionFunctions;

		[SerializeField]
		public string name;

		[SerializeField]
		public string expressionString;

		[SerializeField]
		public string openAnimationFor;

		[SerializeField]
		public bool leaveAfterInit;

		[SerializeField]
		public AnimationBeats.TestSetup testSetup;

		[SerializeField]
		public List<CharacterAnimationSequence> characters;

		private Expression availableExpression => null;

		public bool IsForOpenAnimation(string objectName)
		{
			return false;
		}

		public bool isAvailable(DecoratingScene scene)
		{
			return false;
		}
	}

	[Serializable]
	public class AnimationSequenceGroup
	{
		[SerializeField]
		public string groupName;

		[SerializeField]
		public List<AnimationSequence> animations;

		private List<AnimationSequence> availableSequences;

		public List<AnimationSequence> AvailableSequences(DecoratingScene scene)
		{
			return null;
		}

		public AnimationSequence SequencForOpenAnimation(string objectName)
		{
			return null;
		}
	}

	[Serializable]
	public class ScaleAnimationSettings
	{
		public string name;

		public Vector3 scaleFrom;

		public AnimationCurve scaleCurve;

		public float duration;

		public Vector3 localPositionFrom;

		public AnimationCurve localPositionCurve;
	}

	public interface IAnimationPart
	{
		bool isAnimationActive { get; }

		void ResetAnimationState();

		void StartAnimation(CharacterAvatar avatar);

		float Update(float deltaTime, CharacterAvatar avatar);
	}

	public interface IAnimationPartPlayer
	{
		bool isAnimationActive { get; }

		void StartAnimation(CharacterAvatar avatar);

		void UpdateAnimation(float deltaTime, CharacterAvatar avatar);

		void Init(List<CharacterAnimation.AnimationPart> parts);

		void Init(List<CharacterAnimation.TextAnimationPart> parts);

		void Init(List<CharacterAnimation.LookAnimationPart> parts);
	}

	public class AnimationPartPlayer : IAnimationPartPlayer
	{
		private struct AnimationState
		{
			public bool isActive;

			public int currentPartIndex;
		}

		private List<IAnimationPart> animationParts;

		private AnimationState animationState;

		public bool isAnimationActive => false;

		public void Init(List<CharacterAnimation.AnimationPart> parts)
		{
		}

		public void Init(List<CharacterAnimation.TextAnimationPart> parts)
		{
		}

		public void Init(List<CharacterAnimation.LookAnimationPart> parts)
		{
		}

		public void StartAnimation(CharacterAvatar avatar)
		{
		}

		public void UpdateAnimation(float deltaTime, CharacterAvatar avatar)
		{
		}
	}

	[Serializable]
	public class CharacterAnimation
	{
		[Serializable]
		public class TextAnimationPart : IAnimationPart
		{
			private struct AnimationState
			{
				public bool isAnimating;

				public float time;
			}

			public string text;

			public float duration;

			[NonSerialized]
			private AnimationState animationState;

			public bool isAnimationActive => false;

			public void ResetAnimationState()
			{
			}

			public void StartAnimation(CharacterAvatar avatar)
			{
			}

			public float Update(float deltaTime, CharacterAvatar avatar)
			{
				return 0f;
			}
		}

		[Serializable]
		public class LookAnimationPart : IAnimationPart
		{
			public enum LookAt
			{
				Position = 0,
				LocalOffset = 1,
				Character = 2,
				ObjectInRoom = 3,
				Pause = 4,
				ChangeWeight = 5,
				Marker = 6
			}

			private struct AnimationState
			{
				public bool isAnimating;

				public float time;
			}

			public LookAt lookAtType;

			public string lookAtName;

			public float weight;

			public Vector3 offset;

			public float transitionDuration;

			public float duration;

			[NonSerialized]
			private AnimationState animationState;

			public bool isAnimationActive => false;

			public void ResetAnimationState()
			{
			}

			public void StartAnimation(CharacterAvatar avatar)
			{
			}

			public float Update(float deltaTime, CharacterAvatar avatar)
			{
				return 0f;
			}

			private Vector3 LookAtPosition(CharacterAvatar avatar)
			{
				return default(Vector3);
			}
		}

		[Serializable]
		public class AnimationPart : IAnimationPart
		{
			private struct AnimationState
			{
				public bool isAnimating;

				public float time;
			}

			public bool setTransform;

			public Vector3 position;

			public Vector3 rotationEuler;

			public float duration;

			public string property;

			[NonSerialized]
			private AnimationState animationState;

			public bool isAnimationActive => false;

			public void ResetAnimationState()
			{
			}

			public void StartAnimation(CharacterAvatar avatar)
			{
			}

			public float Update(float deltaTime, CharacterAvatar avatar)
			{
				return 0f;
			}
		}

		[SerializeField]
		public bool playAtInit;

		[SerializeField]
		public bool leaveAfterInit;

		[SerializeField]
		public List<AnimationPart> animationParts;

		[SerializeField]
		public List<TextAnimationPart> textAnimations;

		[SerializeField]
		public List<LookAnimationPart> lookAnimations;

		[SerializeField]
		private List<string> unlockedThatEnable;

		[SerializeField]
		private List<string> ownedThatDisable;

		[SerializeField]
		private List<string> ownedThaEnable;

		private IAnimationPartPlayer partPlayer;

		private IAnimationPartPlayer textPartPlayer;

		private IAnimationPartPlayer lookPartPlayer;

		private List<IAnimationPartPlayer> players;

		[NonSerialized]
		public AnimationsList animationList;

		public bool isAnimationActive => false;

		public void Init(AnimationsList animationList)
		{
		}

		public void StartAnimation(CharacterAvatar avatar)
		{
		}

		public void UpdateAnimation(float deltaTime, CharacterAvatar avatar)
		{
		}
	}

	[Serializable]
	public class RoomAnimationList
	{
		[SerializeField]
		public string roomName;

		[SerializeField]
		public List<AnimationsList> sceneObjectAnimations;

		public void Init()
		{
		}

		public AnimationsList GetAnimationsForSceneObject(string sceneObjectName)
		{
			return null;
		}
	}

	[Serializable]
	public class AnimationsList
	{
		public string sceneObjectName;

		public bool isDefaultAnimation;

		public List<CharacterAnimation> animations;

		private List<CharacterAnimation> availableAnimations_;

		public void Init()
		{
		}
	}

	[Serializable]
	public class VisualObjectOverride
	{
		public bool isSettingSaved;

		public string visualObjectName;

		public Vector3 iconHandlePositionOffset;

		public Vector3 iconHandlePositionScale;

		public Vector3 iconHandleRotation;
	}

	[Serializable]
	public class RoomConfig
	{
		public string roomName;

		[SerializeField]
		private List<VisualObjectOverride> objectOverrides;

		public VisualObjectOverride GetObjectOverride(string objectName)
		{
			return null;
		}
	}

	[SerializeField]
	private bool animationsEnabled;

	public float additionalTimeForRandomAnimation;

	public float additionalTimeForNewObjectAnimation;

	public float additionalInitialTime;

	public AnimationCurve headAnimationCurve;

	public Vector3 speachBubbleHeadOffset;

	public List<AnimationBeats.Sequence> beatsSequences;

	[SerializeField]
	public List<AnimationSequenceGroup> animations;

	[SerializeField]
	public List<RoomAnimationList> roomCharacterAnimations;

	public ScaleAnimationSettings scaleAnimationSettings;

	public List<ScaleAnimationSettings> scaleAnimationSettingsList;

	[SerializeField]
	public List<RoomConfig> roomConfigs;

	public AnimationBeats.Sequence GetBeatsSequence(string groupName, string animationName)
	{
		return null;
	}

	public AnimationSequenceGroup GetAnimationSequenceGroup(string name)
	{
		return null;
	}

	public RoomAnimationList GetRoomAnimationList(string roomName)
	{
		return null;
	}

	public AnimationsList GetAnimationsForSceneObject(string roomName, string sceneObjectName)
	{
		return null;
	}

	public RoomConfig GetRoomConfig(string roomName)
	{
		return null;
	}

	public ScaleAnimationSettings GetScaleAnimationSettingsOrDefault(string name)
	{
		return null;
	}

	protected override void UpdateData()
	{
	}

	public DecoratingSceneConfig()
	{
        //((ScriptableObjectSingleton<>)(object)this)._002Ector();
    }
}
