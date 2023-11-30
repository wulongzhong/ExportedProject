using System;
using System.Collections.Generic;

public class GGRequestCache : Singleton<GGRequestCache>
{
	public class CachedRequest
	{
		protected DateTime expireTime;

		public object cachedObject;

		public bool isExpired => false;

		public CachedRequest(object obj, TimeSpan timeToLive)
		{
		}
	}

	private Dictionary<string, CachedRequest> cache;

	public void Clear()
	{
	}

	public void Put(string key, object cachedObject, TimeSpan timeToLive)
	{
	}

	public T Get<T>(string key) where T : class
	{
		return null;
	}

	public GGRequestCache()
	{
        //((Singleton<>)(object)this)._002Ector();
    }
}
