using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class RatingScreen : MonoBehaviour
{
	public struct ButtonState
	{
		public bool isActive;

		public bool isAccepted;

		public bool isDone;

		public float time;
	}

	private sealed class _003CDoAnimation_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RatingScreen _003C_003E4__this;

		private IEnumerator _003CwaitEnum_003E5__2;

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
		public _003CDoAnimation_003Ed__16(int _003C_003E1__state)
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

	private sealed class _003CWaitForButtonPress_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RatingScreen _003C_003E4__this;

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
		public _003CWaitForButtonPress_003Ed__18(int _003C_003E1__state)
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
	private List<Transform> widgetsToHide;

	[SerializeField]
	private VisualStyleSet buttonStyle;

	[SerializeField]
	private VisualStyleSet clickToContinueStyle;

	[SerializeField]
	private Animator mainAnimation;

	[SerializeField]
	private TextMeshProUGUI mainlabel;

	[SerializeField]
	private string inState;

	[SerializeField]
	private float minTimeBeforeClick;

	private IEnumerator animation;

	[SerializeField]
	private TextMeshProUGUI yesLabel;

	[SerializeField]
	private TextMeshProUGUI noLabel;

	private ButtonState buttonState;

	private void OnEnable()
	{
	}

	private void Init()
	{
	}

	private void PlayInState()
	{
	}

	private void ShowYesNo(string yesText, string noText)
	{
	}

	private IEnumerator DoAnimation()
	{
		return null;
	}

	private void End(bool isLike, bool isGoingToRate)
	{
	}

	private IEnumerator WaitForButtonPress()
	{
		return null;
	}

	private void ButtonPress(bool success)
	{
	}

	public void ButtonCallback_OnYes()
	{
	}

	public void ButtonCallback_OnNo()
	{
	}

	private void Update()
	{
	}
}
