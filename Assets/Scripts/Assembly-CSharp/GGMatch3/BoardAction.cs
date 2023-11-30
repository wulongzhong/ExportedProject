namespace GGMatch3
{
	public class BoardAction
	{
		public LockContainer lockContainer;

		private bool _003CisAlive_003Ek__BackingField;

		private bool _003CisStarted_003Ek__BackingField;

		public virtual bool isAlive
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public virtual bool isStarted
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public virtual void Reset()
		{
		}

		public virtual void OnStart(ActionManager manager)
		{
		}

		public virtual void Stop()
		{
		}

		public virtual void OnUpdate(float deltaTime)
		{
		}
	}
}
