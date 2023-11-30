using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class WellDoneScreen : MonoBehaviour
{
	public struct InitArguments
	{
		public string mainText;

		public Action onComplete;
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public bool complete;

		internal void _003CDoAnimation_003Eb__0()
		{
		}
	}

	private sealed class _003CDoAnimation_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WellDoneScreen _003C_003E4__this;

		private _003C_003Ec__DisplayClass7_0 _003C_003E8__1;

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
		public _003CDoAnimation_003Ed__7(int _003C_003E1__state)
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
	private WellDoneContainer container;

	[SerializeField]
	private TextMeshProUGUI mainTextLabel;

	private IEnumerator animation;

	private InitArguments initArguments;

	public void Show(InitArguments initArguments)
	{
	}

	private void Init()
	{
	}

	private IEnumerator DoAnimation()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}
}
