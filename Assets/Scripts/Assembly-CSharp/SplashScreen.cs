using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GGMatch3;
using UnityEngine;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public NavigationManager nav;

		public bool termsOfServiceDone;

		public Action<bool> _003C_003E9__0;

		internal void _003CDoLoadFirstScene_003Eb__0(bool success)
		{
		}
	}

	private sealed class _003CDoLoadFirstScene_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SplashScreen _003C_003E4__this;

		private _003C_003Ec__DisplayClass6_0 _003C_003E8__1;

		private AsyncOperation _003CasyncOperation_003E5__2;

		private bool _003CneedsToShowTermsOfService_003E5__3;

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
		public _003CDoLoadFirstScene_003Ed__6(int _003C_003E1__state)
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
	private string sceneName;

	[SerializeField]
	private bool showTermsOfServiceDialog;

	[SerializeField]
	private Image progressBarSprite;

	private IEnumerator animationEnumerator;

	private void OnEnable()
	{
	}

	private void Init()
	{
	}

	private IEnumerator DoLoadFirstScene()
	{
		return null;
	}

	private void Update()
	{
	}
}
