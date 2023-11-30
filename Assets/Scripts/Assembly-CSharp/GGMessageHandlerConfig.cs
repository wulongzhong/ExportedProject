using System.Collections.Generic;
using ProtoModels;
using UnityEngine;

public class GGMessageHandlerConfig : ScriptableObject
{
	public class GGServerMessageHandlerBase
	{
		public virtual void Execute(ServerMessages.GGServerMessage.Attachment attachment)
		{
		}
	}

	private static GGMessageHandlerConfig instance_;

	public static GGMessageHandlerConfig instance => null;

	public virtual Dictionary<string, GGServerMessageHandlerBase> GetHandlers()
	{
		return null;
	}
}
