using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using ProtoModels;

public class GGSnapshotCloudSync : GGFileIOCloudSync
{
	public delegate void OnConflict(CloudSyncConflict conflict);

	public delegate bool CanUseCloudSyncDelegate();

	private class PendingSynchronizeNowRequests
	{
		public GGServerRequestsBackend.OnComplete onComplete;
	}

	public class CloudSyncConflict
	{
		private GGServerRequestsBackend.CloudSyncRequest conflictRequest;

		private bool _003CisResolved_003Ek__BackingField;

		public CloudSyncData serverData => null;

		public bool isResolved
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public CloudSyncConflict(GGServerRequestsBackend.CloudSyncRequest conflictRequest)
		{
		}

		public void CancelConflict()
		{
		}

		public void ResolveConflictUsingServerVersion()
		{
		}

		public void ResolveConflictUsingLocalVersion()
		{
		}
	}

	private sealed class _003CDoPeriodicallyTryToSync_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GGSnapshotCloudSync _003C_003E4__this;

		private float _003CellapsedSecondsSinceHaveLocalChanges_003E5__2;

		private float _003CcloudSyncTimeDelaySeconds_003E5__3;

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
		public _003CDoPeriodicallyTryToSync_003Ed__32(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public GGSnapshotCloudSync _003C_003E4__this;

		public GGServerRequestsBackend.OnComplete onComplete;

		internal void _003CDoSynchronize_003Eb__0(GGServerRequestsBackend.ServerRequest request)
		{
		}
	}

	public const string MESSAGE_CONFLICT_RESOLVED = "MessageConflictResolved";

	private DateTime lastSyncTime;

	private int applicationPausedTimes;

	private int applicationPausedTimesWhenLastSync;

	public CanUseCloudSyncDelegate canUseCloudSyncDelegate;

	private List<PendingSynchronizeNowRequests> pendingSyncRequests;

	private GGServerRequestsBackend.ServerRequest lastFinishedRequest;

	private GGServerRequestsBackend.CloudSyncRequest inProgressRequest;

	private CloudSyncConflict conflict;

	private string snapshotSyncFileName;

	private SnapshotSyncInfo activeSnapshot;

	private GGSnapshotFileIO syncFileIO;

	public static bool syncNeeded => false;

	public bool shouldTryToSyncFromMain => false;

	private bool isSynchronizationInProgress => false;

	private bool haveLocalChanges => false;

	private bool isInConflict => false;

	public event OnConflict onConflict
	{
		add
		{
		}
		remove
		{
		}
	}

	public static void StopSyncNeeded()
	{
	}

	public static void CallOnFocus(bool pause)
	{
	}

	private void OnApplicationFocus(bool pause)
	{
	}

	public void SaveActiveSnapshot()
	{
	}

	public void Init()
	{
	}

	public override GGFileIO GetDefaultFileIO()
	{
		return null;
	}

	public override GGFileIO GetCloudFileIO()
	{
		return null;
	}

	public void UpdateSnapshot()
	{
	}

	private IEnumerator DoPeriodicallyTryToSync()
	{
		return null;
	}

	private void SynchronizeIfPossible()
	{
	}

	public void SynchronizeNow(GGServerRequestsBackend.OnComplete onComplete)
	{
	}

	private void DoSynchronize(GGServerRequestsBackend.OnComplete onComplete)
	{
	}

	private GGServerRequestsBackend.CloudSyncRequest CreateRequest()
	{
		return null;
	}

	private void SyncReceieved()
	{
	}

	public void HandleSyncRequestResult(GGServerRequestsBackend.ServerRequest request)
	{
	}

	public void HandlePendingRequests()
	{
	}

	private void UpdateLastKnownServerValues(int serverSnapshotId, string serverSnapshotGUID, string localGUID)
	{
	}

	private void SetConflictedState(GGServerRequestsBackend.CloudSyncRequest conflictedRequest)
	{
	}

	public void ResolveConflictTakeTheirs(CloudSyncData serverResponseData)
	{
	}

	public void ResolveConflictTakeMine(CloudSyncData serverResponseData)
	{
	}

	private CloudSyncData GetSnapshotForSync(List<string> files)
	{
		return null;
	}
}
