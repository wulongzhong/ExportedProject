using System.IO;

public class GGFileIOUnity : GGFileIO
{
	private string GetInternalPath()
	{
		return null;
	}

	protected string FullPath(string filename)
	{
		return null;
	}

	private void WritePlayerPrefs(string path, string text)
	{
	}

	private void WritePlayerPrefs(string path, byte[] bytes)
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
