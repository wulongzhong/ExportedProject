using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class WinScreenAnimation : MonoBehaviour
{
	private sealed class _003CDoPlay_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WinScreenAnimation _003C_003E4__this;

		private bool _003CcalledOnMiddle_003E5__2;

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
		public _003CDoPlay_003Ed__8(int _003C_003E1__state)
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
	private Animator animationAnimator;

	[SerializeField]
	private Transform animationTransform;

	[SerializeField]
	private string stateNameToPlay;

	[SerializeField]
	private float normalizedTimeOfMiddle;

	private Action onMiddle;

	private Action onEnd;

	private IEnumerator animationEnumerator;

	public void ShowAnimation(Action onMiddle, Action onEnd)
	{
	}

	private IEnumerator DoPlay()
	{
		return null;
	}

	private void Update()
	{
	}
}
