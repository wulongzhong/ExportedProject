public class GGCloudSyncFileIO : GGFileIO
{
	private GGCloudSyncFileIOSync sync;

	public GGCloudSyncFileIO(GGCloudSyncFileIOSync ggSync)
	{
	}

	public override void Write(string path, string text)
	{
	}

	public override void Write(string path, byte[] bytes)
	{
	}

	public override string ReadText(string path)
	{
		return null;
	}

	public override byte[] Read(string path)
	{
		return null;
	}

	public override bool FileExists(string path)
	{
		return false;
	}
}
