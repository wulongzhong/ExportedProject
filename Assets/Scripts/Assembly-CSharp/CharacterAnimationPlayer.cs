using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CharacterAnimationPlayer : MonoBehaviour
{
	private struct AnimationState
	{
		public IEnumerator animationEnumerator;

		public DecoratingSceneConfig.AnimationSequence animationSequence;

		public ChangeAnimationArguments arguments;
	}

	private sealed class _003CDoPlay_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChangeAnimationArguments arguments;

		public CharacterAnimationPlayer _003C_003E4__this;

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
		public _003CDoPlay_003Ed__20(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public bool isAnimationRunning;

		internal void _003CDoPlaySequence_003Eb__0()
		{
		}
	}

	private sealed class _003CDoPlaySequence_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DecoratingSceneConfig.CharacterAnimationSequence sequence;

		public CharacterAvatar avatar;

		public CharacterAnimationPlayer _003C_003E4__this;

		private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

		private List<DecoratingSceneConfig.CharacterAnimationLine> _003Clines_003E5__2;

		private int _003Ci_003E5__3;

		private DecoratingSceneConfig.CharacterAnimationLine _003Citem_003E5__4;

		private float _003Ctime_003E5__5;

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
		public _003CDoPlaySequence_003Ed__21(int _003C_003E1__state)
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
	public string beatToPlay;

	[SerializeField]
	private List<CharacterAvatar> avatars;

	[SerializeField]
	private List<Transform> markers;

	[NonSerialized]
	public BeatMarkers beatMarkers;

	[NonSerialized]
	public DecoratingScene scene;

	private EnumeratorsList enumList;

	private AnimationState animationState;

	public DecoratingSceneConfig.AnimationSequence lastAnimation => null;

	private float deltaTime => 0f;

	public void Init(DecoratingScene scene)
	{
	}

	public Transform GetMarker(string name)
	{
		return null;
	}

	public void Stop()
	{
	}

	public void PlayWithSetup(ChangeAnimationArguments arguments)
	{
	}

	public void HideAvatars()
	{
	}

	public void Play(ChangeAnimationArguments arguments)
	{
	}

	public CharacterAvatar GetAvatar(string characterName)
	{
		return null;
	}

	private void StopAvatarAnimations()
	{
	}

	private IEnumerator DoPlay(ChangeAnimationArguments arguments)
	{
		return null;
	}

	private IEnumerator DoPlaySequence(CharacterAvatar avatar, DecoratingSceneConfig.CharacterAnimationSequence sequence)
	{
		return null;
	}

	public void Update()
	{
	}
}
