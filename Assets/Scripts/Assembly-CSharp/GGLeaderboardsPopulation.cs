using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GGLeaderboardsPopulation : MonoBehaviour
{
	public delegate void OnComplete();

	private sealed class _003CDoUpdateUser_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GGLeaderboardsPopulation _003C_003E4__this;

		public GGServerRequestsBackend.UpdateRequest update;

		public GGServerRequestsBackend.OnComplete onComplete;

		private GGServerRequestsBackend.NonceRequest _003CnonceReq_003E5__2;

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
		public _003CDoUpdateUser_003Ed__10(int _003C_003E1__state)
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

	public int level;

	public int startPid;

	public int endPid;

	public string nameBase;

	public int startScore;

	public string updateCountry;

	private int currentPid;

	private OnComplete onPopulationComplete;

	public void UpdateLeaderboards(OnComplete onComplete)
	{
	}

	private IEnumerator DoUpdateUser(GGServerRequestsBackend.UpdateRequest update, GGServerRequestsBackend.OnComplete onComplete)
	{
		return null;
	}

	public void onRequestComplete(GGServerRequestsBackend.ServerRequest request)
	{
	}
}
