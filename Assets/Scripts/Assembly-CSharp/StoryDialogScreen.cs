using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StoryDialogScreen : MonoBehaviour
{
	private sealed class _003CDoShowStoryTimeline_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StoryDialogScreen _003C_003E4__this;

		public StoryDialogAnimationParameters p;

		private CarScene _003CcarScene_003E5__2;

		private StoryTimeline _003Cstory_003E5__3;

		private Action<AnimationCompleteParameters> _003ConDone_003E5__4;

		private int _003Ci_003E5__5;

		private IEnumerator _003Canimation_003E5__6;

		private IEnumerator _003CstoryShow_003E5__7;

		private IEnumerator _003CwaitToClick_003E5__8;

		private IEnumerator _003Cphone_003E5__9;

		private IEnumerator _003CactorOut_003E5__10;

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
		public _003CDoShowStoryTimeline_003Ed__31(int _003C_003E1__state)
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

	private sealed class _003CDoShowPhone_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StoryDialogScreen _003C_003E4__this;

		private IEnumerator _003Canim_003E5__2;

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
		public _003CDoShowPhone_003Ed__33(int _003C_003E1__state)
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

	private sealed class _003CDoHidePhone_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StoryDialogScreen _003C_003E4__this;

		private IEnumerator _003Canim_003E5__2;

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
		public _003CDoHidePhone_003Ed__34(int _003C_003E1__state)
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

	private sealed class _003CFadeOverlay_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StoryDialogScreen _003C_003E4__this;

		public Color color;

		public float from;

		public float duration;

		public float to;

		public bool hideAtEnd;

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
		public _003CFadeOverlay_003Ed__37(int _003C_003E1__state)
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

	private sealed class _003CDoMoveActorOut_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool isLeftCharacter;

		public StoryDialogScreen _003C_003E4__this;

		public Sprite actorSprite;

		private Animator _003Canimator_003E5__2;

		private float _003Ctime_003E5__3;

		private float _003CmaxDuration_003E5__4;

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
		public _003CDoMoveActorOut_003Ed__38(int _003C_003E1__state)
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

	private sealed class _003CDoShowStoryMessage_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StoryDialogScreen _003C_003E4__this;

		public StoryMessage message;

		public Sprite actorSprite;

		private float _003Ctime_003E5__2;

		private TextMeshProUGUI _003CdialogText_003E5__3;

		private Image _003CspeakingCharacterImage_003E5__4;

		private Image _003CnotSpeakingCharacterImage_003E5__5;

		private Image _003CspeakingCharacterTextBubbleImage_003E5__6;

		private float _003CscaleDuration_003E5__7;

		private float _003CsmallScale_003E5__8;

		private Vector3 _003CspeakCharacterScaleStart_003E5__9;

		private Vector3 _003CnotSpeakingCharacterScaleStart_003E5__10;

		private int _003CmessageLength_003E5__11;

		private float _003CreadTextDuration_003E5__12;

		private float _003CstartAlpha_003E5__13;

		private float _003Cduration_003E5__14;

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
		public _003CDoShowStoryMessage_003Ed__39(int _003C_003E1__state)
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

	private sealed class _003CDoWaitUntilUserClicks_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StoryDialogScreen _003C_003E4__this;

		public float maxWaitTime;

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
		public _003CDoWaitUntilUserClicks_003Ed__40(int _003C_003E1__state)
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
	private CanvasGroup overlayCanvas;

	[SerializeField]
	private Image overlayImage;

	[SerializeField]
	private Transform clickContainer;

	[SerializeField]
	private Transform blackBarsOuter;

	[SerializeField]
	private Transform blackBarDialogArea;

	[SerializeField]
	private Transform textDialogContainer;

	[SerializeField]
	private Transform leftTextBubbleContainer;

	[SerializeField]
	private TextMeshProUGUI leftTextBubbleLabel;

	[SerializeField]
	private TextMeshProUGUI leftTextBubbleNameLabel;

	[SerializeField]
	private Image leftTextBubbleImage;

	[SerializeField]
	private Transform rightTextBubbleContainer;

	[SerializeField]
	private TextMeshProUGUI rightTextBubbleLabel;

	[SerializeField]
	private TextMeshProUGUI rightTextBubbleNameLabel;

	[SerializeField]
	private Image rightTextBubbleImage;

	[SerializeField]
	private List<Transform> moreTextIcon;

	[SerializeField]
	private Transform skipButton;

	[SerializeField]
	private TextMeshProUGUI dialogText;

	[SerializeField]
	private Transform phoneContainer;

	[SerializeField]
	private Transform leftCharacterContainer;

	[SerializeField]
	private Image leftCharacterImage;

	[SerializeField]
	private Transform rightCharacterContainer;

	[SerializeField]
	private Image rightCharacterImage;

	[SerializeField]
	private StoryDialogPhone phoneUI;

	[NonSerialized]
	private IEnumerator animationAction;

	[NonSerialized]
	private bool isUserClicked;

	[NonSerialized]
	private bool registerClick;

	[NonSerialized]
	private StoryDialogAnimationParameters currentAnimationParameters;

	public void ShowScreen()
	{
	}

	public void ShowStoryTimeline(CarScene carScene, StoryTimeline story, Action<AnimationCompleteParameters> onDone)
	{
	}

	public void ShowStoryTimeline(StoryDialogAnimationParameters parameters)
	{
	}

	private Camera FindActiveCamera(StoryDialogAnimationParameters p)
	{
		return null;
	}

	private IEnumerator DoShowStoryTimeline(StoryDialogAnimationParameters p)
	{
		return null;
	}

	private void AnimationCleanup()
	{
	}

	public IEnumerator DoShowPhone()
	{
		return null;
	}

	public IEnumerator DoHidePhone()
	{
		return null;
	}

	public IEnumerator FadeInOverlay(Color color, float duration)
	{
		return null;
	}

	public IEnumerator FadeOutOverlay(Color color, float duration)
	{
		return null;
	}

	public IEnumerator FadeOverlay(Color color, float duration, float from, float to, bool hideAtEnd)
	{
		return null;
	}

	public IEnumerator DoMoveActorOut(bool isLeftCharacter, Sprite actorSprite)
	{
		return null;
	}

	public IEnumerator DoShowStoryMessage(StoryMessage message, Sprite actorSprite)
	{
		return null;
	}

	private IEnumerator DoWaitUntilUserClicks(float maxWaitTime = -1f)
	{
		return null;
	}

	public void ButtonCallback_OnClick()
	{
	}

	private void Update()
	{
	}

	public void ButtonCallback_OnSkip()
	{
	}
}
