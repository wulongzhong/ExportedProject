using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using ProtoModels;

public class GGCloudSyncFileIOSync : GGFileIOCloudSync
{
	public delegate void OnNewCloudData(GGCloudSyncFileIOSync sync);

	private sealed class _003CDoSyncWithDelay_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GGCloudSyncFileIOSync _003C_003E4__this;

		private float _003CcurrentDelay_003E5__2;

		private float _003CsyncDelay_003E5__3;

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
		public _003CDoSyncWithDelay_003Ed__29(int _003C_003E1__state)
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

	private string cloudSyncInfoFileName;

	private CloudSyncInfo cloudSyncInfo;

	private GGCloudSyncFileIO syncFileIO;

	private bool isInSync;

	private DateTime cloudSyncStartTime;

	private int syncCountForMinute;

	public event OnNewCloudData onNewCloudData
	{
		add
		{
		}
		remove
		{
		}
	}

	public void SaveCloudSyncInfo()
	{
	}

	public void Init()
	{
	}

	private CloudSyncInfo.CloudSyncFileInfo GetCloudSyncFileInfo(string filename)
	{
		return null;
	}

	public override bool IsInConflict(string filename)
	{
		return false;
	}

	public override GGFileIO GetDefaultFileIO()
	{
		return null;
	}

	public override GGFileIO GetCloudFileIO()
	{
		return null;
	}

	public override void synchronize()
	{
	}

	public void OnCloudSyncFinished(GGServerRequestsBackend.ServerRequest request)
	{
	}

	public byte[] GetServerBytes(string filename)
	{
		return null;
	}

	public byte[] GetPreviousServerBytes(string filename)
	{
		return null;
	}

	public byte[] GetLocalBytes(string filename)
	{
		return null;
	}

	public string GetLocalFileGuid(string filename)
	{
		return null;
	}

	public string GetServerFileGuid(string filename)
	{
		return null;
	}

	public void MarkResolved(string filename)
	{
	}

	public string GetPreviousServerFileGuid(string filename)
	{
		return null;
	}

	public void SetGuid(string filename, string guid)
	{
	}

	private bool HasStagedChanges()
	{
		return false;
	}

	private CloudSyncData GetDataListForChangesSinceLastSync()
	{
		return null;
	}

	public void SyncWithDelay()
	{
	}

	private IEnumerator DoSyncWithDelay()
	{
		return null;
	}

	private void OnApplicationPause(bool paused)
	{
	}
}
