using ProtoBuf.Meta;

public class ProtoIO
{
	public static bool LoadFromFile<T>(string filename, out T model) where T : class
	{
		model = null;
		return false;
	}

	public static bool LoadFromFileLocal<T>(string filename, out T model) where T : class
	{
		model = null;
		return false;
	}

	public static bool LoadFromFileLocal<S, T>(string filename, out T model) where S : TypeModel, new() where T : class
	{
		model = null;
		return false;
	}

	public static bool LoadFromFile<S, T>(string filename, GGFileIO fileIO, out T model) where S : TypeModel, new() where T : class
	{
		model = null;
		return false;
	}

	public static bool SaveToFile<T>(string filename, T model) where T : new()
	{
		return false;
	}

	public static bool SaveToFileCS<T>(string filename, T model) where T : new()
	{
		return false;
	}

	public static bool SaveToFile<S, T>(string filename, GGFileIO fileIO, T model) where S : TypeModel, new() where T : new()
	{
		return false;
	}

	public static byte[] SerializeToByteArray<S, T>(T model) where S : TypeModel, new() where T : new()
	{
		return null;
	}

	public static bool LoadFromByteStream<T>(byte[] encoded, out T model) where T : class
	{
		model = null;
		return false;
	}

	private static bool LoadFromByteStream<S, T>(byte[] encoded, out T model) where S : TypeModel, new() where T : class
	{
		model = null;
		return false;
	}

	public static string SerializeToByte64<T>(T Model) where T : class
	{
		return null;
	}

	public static bool LoadFromBase64String<T>(string base64String, out T model) where T : class
	{
		model = null;
		return false;
	}

	private static bool LoadFromBase64String<S, T>(string base64String, out T model) where S : TypeModel, new() where T : class
	{
		model = null;
		return false;
	}

	public static T Clone<T>(T model) where T : class, new()
	{
		return null;
	}
}
