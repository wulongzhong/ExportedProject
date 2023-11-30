using System.IO;

public class GGSnapshotFileIO : GGFileIO
{
	private GGSnapshotCloudSync snapshotSync;

	public GGSnapshotFileIO(GGSnapshotCloudSync snapshotSync)
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

	public override Stream FileReadStream(string path)
	{
		return null;
	}
}
