using UnityEngine;

public class GGFileIOCloudSync : MonoBehaviour
{
	public const string NOTIFICATION_NEW_DATA = "CloudSync.NewData";

	public const string NOTIFICATION_DATA_UPLOADED = "CloudSync.DataUploaded";

	public static GGFileIOCloudSync instance_;

	public static GGFileIOCloudSync instance => null;

	public static bool isCloudSyncNotification(string message)
	{
		return false;
	}

	public virtual GGFileIO GetDefaultFileIO()
	{
		return null;
	}

	public virtual GGFileIO GetCloudFileIO()
	{
		return null;
	}

	public virtual bool IsInConflict(string name)
	{
		return false;
	}

	public virtual void synchronize()
	{
	}
}
