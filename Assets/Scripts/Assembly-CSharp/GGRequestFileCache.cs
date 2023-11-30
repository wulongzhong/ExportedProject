using System;
using ProtoModels;

public class GGRequestFileCache : SingletonInit<GGRequestFileCache>
{
	public string filename;

	private RequestCache cache;

	public override void Init()
	{
	}

	public void Clear()
	{
	}

	private void Save()
	{
	}

	public void Put(string key, byte[] cachedObject, TimeSpan timeToLive)
	{
	}

	private RequestCache.Request GetRequest(string key)
	{
		return null;
	}

	private bool IsExpired(RequestCache.Request request)
	{
		return false;
	}

	public T Get<T>(string key) where T : class
	{
		return null;
	}

	public GGRequestFileCache()
	{
        //((SingletonInit<>)(object)this)._002Ector();
    }
}
