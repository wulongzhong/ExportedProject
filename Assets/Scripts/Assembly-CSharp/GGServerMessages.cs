using System.Collections.Generic;
using ProtoModels;

public class GGServerMessages : BehaviourSingletonInit<GGServerMessages>
{
	public delegate void OnMessageExecuted();

	private Dictionary<string, GGMessageHandlerConfig.GGServerMessageHandlerBase> messageHandlers;

	private GGMessageHandlerConfig.GGServerMessageHandlerBase defaultHandler;

	public event OnMessageExecuted onMessageExecuted
	{
		add
		{
		}
		remove
		{
		}
	}

	public override void Init()
	{
	}

	public void GetMessages(GGServerRequestsBackend.OnComplete onComplete)
	{
	}

	public void ExecuteMessageAttachment(string key, ServerMessages.GGServerMessage.Attachment attachment)
	{
	}

	public GGServerMessages()
	{
		//((BehaviourSingletonInit<>)(object)this)._002Ector();
	}
}
