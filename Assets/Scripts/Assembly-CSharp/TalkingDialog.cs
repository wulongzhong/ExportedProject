using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Spine.Unity;
using TMPro;
using UnityEngine;

public class TalkingDialog : MonoBehaviour
{
	[Serializable]
	public class TalkLine
	{
		public TalkCharacter character;

		public string say;

		public TalkLine()
		{
		}

		public TalkLine(string say, TalkCharacter character)
		{
		}
	}

	public class ShowArguments
	{
		public List<TalkLine> thingsToSay;

		public Action onComplete;

		public InputHandler inputHandler;

		public void AddThingsToSay(List<TalkLine> lines)
		{
		}
	}

	[Serializable]
	public class CharacterDescription
	{
		public TalkCharacter character;

		public Transform root;

		public TextMeshProUGUI label;

		public SkeletonGraphic skeleton;

		public string animationName;
	}

	private struct ClickParams
	{
		public bool isWaitingForClick;

		public bool isClicked;
	}

	private sealed class _003CDoShow_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public TalkingDialog _003C_003E4__this;

		public ShowArguments showArguments;

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
		public _003CDoShow_003Ed__11(int _003C_003E1__state)
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

	private sealed class _003CDoShowText_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalkingDialog _003C_003E4__this;

		private List<TalkLine> _003CthingsToSay_003E5__2;

		private int _003Ci_003E5__3;

		private IEnumerator _003Ce_003E5__4;

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
		public _003CDoShowText_003Ed__17(int _003C_003E1__state)
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

	private sealed class _003CDoWaitForClick_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalkingDialog _003C_003E4__this;

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
		public _003CDoWaitForClick_003Ed__19(int _003C_003E1__state)
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
	private TextMeshProUGUI talkLabel;

	[SerializeField]
	private Transform clickContainer;

	[NonSerialized]
	private ShowArguments showArguments;

	[NonSerialized]
	private IEnumerator animEnum;

	[SerializeField]
	private List<CharacterDescription> characters;

	[NonSerialized]
	private ClickParams clickParams;

	private bool isActive;

	[NonSerialized]
	private List<Transform> characterRootTransform;

	public IEnumerator DoShow(ShowArguments showArguments, float delay = 0f)
	{
		return null;
	}

	public void ShowSingleLine(string toSay, TalkCharacter character)
	{
	}

	public void Show(ShowArguments showArguments)
	{
	}

	private void ShowCharacter(TalkCharacter character, string text)
	{
	}

	public void Hide()
	{
	}

	private IEnumerator DoShowText()
	{
		return null;
	}

	private void InputHandler_OnClick(Vector2 screenPosition)
	{
	}

	private IEnumerator DoWaitForClick()
	{
		return null;
	}

	public void ButtonCallback_OnClick()
	{
	}

	private void Update()
	{
	}
}
