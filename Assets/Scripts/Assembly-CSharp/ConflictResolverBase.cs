using System.Collections.Generic;
using UnityEngine;

public class ConflictResolverBase : ScriptableObject
{
	private static ConflictResolverBase instance_;

	public static ConflictResolverBase instance => null;

	public virtual bool ResolveConflict(GGSnapshotCloudSync.CloudSyncConflict conflict)
	{
		return false;
	}

	public virtual void OnConflict(GGCloudSyncFileIOSync sync)
	{
	}

	public virtual void OnConflict()
	{
	}

	public virtual void OnBeginSync()
	{
	}

	public virtual List<string> FilesToSync()
	{
		return null;
	}
}
