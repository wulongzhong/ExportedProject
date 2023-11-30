using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CharacterAvatar : MonoBehaviour
{
	public struct ChangeAnimationArguments
	{
		public DecoratingSceneConfig.CharacterAnimation animation;

		public bool useFadeInOut;

		public float initialDelay;

		public RoomSceneRenderObject roomRenderer;

		public float additionalTime;

		public Action onComplete;

		public VisualObjectBehaviour lookAt;

		public static ChangeAnimationArguments Create(string roomName, string sceneObjectName, int animationVariantIndex = 0)
		{
			return default(ChangeAnimationArguments);
		}
	}

	private struct LookAtState
	{
		public bool isActive;

		public Vector3 lookAtPosition;

		public float duration;

		public Vector3 startLookAtPosition;

		public float weightAtStart;

		public float weight;

		public float time;
	}

	private struct AnimationState
	{
		public bool isActive;

		public DecoratingSceneConfig.CharacterAnimation characterAnimation;

		public float additionalTime;

		public ChangeAnimationArguments changeAnimationArguments;

		public void Complete()
		{
		}
	}

	private sealed class _003CDoPopIn_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterAvatar _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

        object IEnumerator<object>.Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        [DebuggerHidden]
		public _003CDoPopIn_003Ed__52(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }

	[SerializeField]
	private float popInDuration;

	[SerializeField]
	private AnimationCurve popInCurve;

	[SerializeField]
	private Vector3 startScale;

	[SerializeField]
	private Vector3 endScale;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private Transform shadowTransform;

	[SerializeField]
	private float shadowy;

	[SerializeField]
	private string idleState;

	[SerializeField]
	public string roomName;

	[SerializeField]
	public string sceneObjectName;

	[SerializeField]
	public int animationIndex;

	[SerializeField]
	private float lookAtChangeSpeed;

	[SerializeField]
	public Transform headLookAt;

	[SerializeField]
	private float maxHeadAngleDeg;

	[SerializeField]
	private float maxHorizontalHeadAngleDeg;

	[SerializeField]
	public float lookAtWeight;

	[NonSerialized]
	public DecoratingScene decoratingScene;

	private AnimatorControllerParameter[] allParameters_;

	[NonSerialized]
	public float timeNotAnimating;

	private LookAtState lookAtState;

	private AnimationState animationState;

	private IEnumerator animationEnum;

	[NonSerialized]
	public DecoratingSceneConfig.CharacterAnimation lastAnimation;

	private AnimatorControllerParameter[] allParameters => null;

	public bool isRunningDefaultAnimation => false;

	public bool isAnimating => false;

	public Vector3 headPosition => default(Vector3);

	public Vector3 bubblePosition => default(Vector3);

	private CharacterSpeachBubble speachBubble => null;

	public void InitWithDecoratingScene(DecoratingScene decoratingScene)
	{
	}

	public void ShowSpeachBubble(string text)
	{
	}

	public void HideSpeachBubble()
	{
	}

	public void StopLookAt()
	{
	}

	public void UpdateLookAtInAnimation(Vector3 position)
	{
	}

	public void ChangeLookAtWeight(float weight, float animateDuration)
	{
	}

	public void LookAt(Vector3 position, float weight, float animateDuration)
	{
	}

	public void StopAnimation()
	{
	}

	public void RunAnimation(ChangeAnimationArguments animationArguments)
	{
	}

	public void RunAnimation(string sceneObjectName, float additionalTime)
	{
	}

	public void SetProperty(string name, bool value)
	{
	}

	public void SetPosition(Vector3 position)
	{
	}

	public void SetRotation(Vector3 eulerRotation)
	{
	}

	public void PopIn()
	{
	}

	private IEnumerator DoPopIn()
	{
		return null;
	}

	private void LateUpdate()
	{
	}

	private void Update()
	{
	}

	private Vector3 GetAcceptableHeadLookAtPosition(Vector3 initialPosition)
	{
		return default(Vector3);
	}

	private void OnAnimatorIK(int layerIndex)
	{
	}
}
