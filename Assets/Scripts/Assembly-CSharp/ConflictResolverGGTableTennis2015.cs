using System.Collections.Generic;

public class ConflictResolverGGTableTennis2015 : ConflictResolverBase
{
	private enum ConflictVersion
	{
		Local = 0,
		Remote = 1
	}

	private struct VersionArguments
	{
		public int stagesPassed;

		public long coins;
	}

	public List<string> filesToSync;

	public override List<string> FilesToSync()
	{
		return null;
	}

	public override bool ResolveConflict(GGSnapshotCloudSync.CloudSyncConflict conflict)
	{
		return false;
	}

	private ConflictVersion GetVersionToResolve(VersionArguments localVersion, VersionArguments remoteVersion)
	{
		return default(ConflictVersion);
	}

	public override void OnConflict()
	{
	}
}
