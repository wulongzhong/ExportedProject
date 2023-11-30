using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GGMatch3;
using UnityEngine;
using UnityEngine.UI;

public class SyncGameScreen : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public bool synchronizingToServer;

		public GGSnapshotCloudSync snapshotSync;

		internal void _003CDoSyncNow_003Eb__0(GGServerRequestsBackend.ServerRequest request)
		{
		}
	}

	private sealed class _003CDoSyncNow_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SyncGameScreen _003C_003E4__this;

		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		private float _003CstartTime_003E5__2;

		private float _003CmaxDurationSec_003E5__3;

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
		public _003CDoSyncNow_003Ed__5(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public bool requestRunning;

		public bool synchronizingToServer;

		public GGSnapshotCloudSync snapshotSync;

		public NavigationManager nav;

		internal void _003CDoLogin_003Eb__0(GGServerRequestsBackend.ServerRequest _003Cp0_003E)
		{
		}

		internal void _003CDoLogin_003Eb__1(GGServerRequestsBackend.ServerRequest request)
		{
		}

		internal void _003CDoLogin_003Eb__2(bool _003Cp0_003E)
		{
		}
	}

	private sealed class _003CDoLogin_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SyncGameScreen _003C_003E4__this;

		private _003C_003Ec__DisplayClass6_0 _003C_003E8__1;

		private GGServerRequestsBackend.IdRequest _003CidRequest_003E5__2;

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
		public _003CDoLogin_003Ed__6(int _003C_003E1__state)
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
	private Image fillImage;

	private IEnumerator action;

	public void LoginToFacebook(string userId)
	{
	}

	public void LoginToApple(string userId)
	{
	}

	public void SynchronizeNow()
	{
	}

	private IEnumerator DoSyncNow()
	{
		return null;
	}

	private IEnumerator DoLogin()
	{
		return null;
	}

	private void Update()
	{
	}
}
