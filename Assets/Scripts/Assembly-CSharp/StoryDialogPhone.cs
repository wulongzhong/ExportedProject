using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StoryDialogPhone : MonoBehaviour
{
	public enum PhoneState
	{
		Ringing = 0,
		CallInProgress = 1,
		NewMessage = 2
	}

	[Serializable]
	public class PhoneStateUI
	{
		public PhoneState phoneState;

		public Transform uiContainer;

		public string animationStateName;
	}

	private sealed class _003CDoShowPhone_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StoryDialogPhone _003C_003E4__this;

		private float _003CmaxTime_003E5__2;

		private float _003Ctime_003E5__3;

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
		public _003CDoShowPhone_003Ed__12(int _003C_003E1__state)
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

	private sealed class _003CDoHidePhone_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StoryDialogPhone _003C_003E4__this;

		private float _003CmaxTime_003E5__2;

		private float _003Ctime_003E5__3;

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
		public _003CDoHidePhone_003Ed__13(int _003C_003E1__state)
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
	private TextMeshProUGUI ringingCallerNameText;

	[SerializeField]
	private TextMeshProUGUI callInProgressCallerNameText;

	[SerializeField]
	private Image messageImage;

	[SerializeField]
	private PhoneStateUI[] phoneStatesUI;

	[SerializeField]
	private Animator phoneAnimation;

	[SerializeField]
	private Transform scalerTransform;

	public void SetCallerName(string name)
	{
	}

	public void SetMessageImage(Sprite sprite)
	{
	}

	public void ShowPhoneState(PhoneState phoneStateToShow)
	{
	}

	public void ShowPhoneStateNoAnimation(PhoneState phoneStateToShow)
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
}
