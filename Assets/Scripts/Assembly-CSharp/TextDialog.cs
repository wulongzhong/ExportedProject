using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextDialog : MonoBehaviour
{
	public struct MessageArguments
	{
		public string message;

		public bool showProgress;

		public float fromProgress;

		public float toProgress;
	}

	private sealed class _003CDoProgressBar_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TextDialog _003C_003E4__this;

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
		public _003CDoProgressBar_003Ed__13(int _003C_003E1__state)
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
	private TextMeshProUGUI textLabel;

	[SerializeField]
	private float introDuration;

	[SerializeField]
	private float time;

	[SerializeField]
	private Transform progressContainer;

	[SerializeField]
	private Image progressBar;

	[SerializeField]
	private float progressBarDuration;

	[SerializeField]
	private TextMeshProUGUI progressTextLabel;

	private Action onComplete;

	private IEnumerator animation;

	private MessageArguments messageArguments;

	public void ShowOk(MessageArguments messageArguments, Action onComplete)
	{
	}

	public void ButtonCallback_OnClick()
	{
	}

	private IEnumerator DoProgressBar()
	{
		return null;
	}

	private void Update()
	{
	}
}
