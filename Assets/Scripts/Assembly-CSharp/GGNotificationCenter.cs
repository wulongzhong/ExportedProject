using System;
using System.Collections.Generic;

public class GGNotificationCenter : BehaviourSingletonInit<GGNotificationCenter>
{
	public delegate void GGNotificationCenterDelegate(string message);

	public class EventDispatcher
	{
		public delegate void EventDelegateListener(object data);

		public class EventDelegate
		{
			public EventDelegateListener onMessageCall;
		}

		public class EventDelegateList
		{
			public List<EventDelegate> eventList;

			public void NotifyListeners(object data)
			{
			}
		}

		protected Dictionary<Type, EventDelegateList> eventMap;

		public void AssignListener(Type type, EventDelegateListener listener)
		{
		}

		public void NotifyListeners(Type type, object data)
		{
		}
	}

	public const string PurchaseIAPSuccess = "Purchase.IAP.Success";

	protected List<EventDispatcher> eventDispatchers;

	private EventDispatcher _003CdefaultEventDispatcher_003Ek__BackingField;

	public EventDispatcher defaultEventDispatcher
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public event GGNotificationCenterDelegate onMessage
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

	public void AddEventDispatcher(EventDispatcher ed)
	{
	}

	public void RemoveEventDispatcher(EventDispatcher ed)
	{
	}

	protected void NotifyEventDispatchers(Type type, object data)
	{
	}

	public void Broadcast(string message)
	{
	}

	public void BroadcastEvent(object e)
	{
	}

	public GGNotificationCenter()
	{
		//((BehaviourSingletonInit<>)(object)this)._002Ector();
	}
}
