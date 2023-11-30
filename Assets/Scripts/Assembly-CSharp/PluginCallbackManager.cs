using System;
using System.Collections.Generic;

public class PluginCallbackManager : BehaviourSingletonInit<PluginCallbackManager>
{
	public class Response
	{
		[Serializable]
		public class BaseParameters
		{
			public string callback_id;
		}

		public string jsonResponse;

		public BaseParameters baseParameters;

		public Response(BaseParameters baseParameters, string jsonResponse)
		{
		}
	}

	public delegate void CallbackDelegate(Response msg);

	private Dictionary<string, CallbackDelegate> callbacks;

	private static int nextCallbackId;

	public string RegisterCallback(CallbackDelegate callback)
	{
		return null;
	}

	public void OnCallCallback(string jsonMessage)
	{
	}

	public PluginCallbackManager()
	{
		//((BehaviourSingletonInit<>)(object)this)._002Ector();
	}
}
