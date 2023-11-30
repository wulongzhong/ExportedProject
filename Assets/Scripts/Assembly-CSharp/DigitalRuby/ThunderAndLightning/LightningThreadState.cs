using System;
using System.Collections.Generic;
using System.Threading;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningThreadState
	{
		private Thread lightningThread;

		private AutoResetEvent lightningThreadEvent;

		private readonly Queue<Action> actionsForBackgroundThread;

		private readonly Queue<KeyValuePair<Action, ManualResetEvent>> actionsForMainThread;

		public bool Running;

		private bool isTerminating;

		private bool UpdateMainThreadActionsOnce()
		{
			return false;
		}

		private void BackgroundThreadMethod()
		{
		}

		public void TerminateAndWaitForEnd()
		{
		}

		public void UpdateMainThreadActions()
		{
		}

		public bool AddActionForMainThread(Action action, bool waitForAction = false)
		{
			return false;
		}

		public bool AddActionForBackgroundThread(Action action)
		{
			return false;
		}
	}
}
