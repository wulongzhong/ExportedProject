using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GGMatch3;

public class ShowTutorialMaskAction : BoardAction
{
	public class Parameters
	{
		public LevelDefinition.TutorialMatch match;

		public Match3Game game;

		public Action onMiddle;

		public Action onEnd;
	}

	public class SlotChipPair
	{
		private Slot slot;

		private Chip chip;

		public void Init(Slot slot, Chip chip)
		{
		}
	}

	private sealed class _003CDoShowTutorial_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShowTutorialMaskAction _003C_003E4__this;

		private Lock _003CswapLock_003E5__2;

		private Lock _003CtouchLock_003E5__3;

		private Lock _003CswipeLock_003E5__4;

		private Match3Game _003Cgame_003E5__5;

		private Slot _003CslotToSwipe_003E5__6;

		private Slot _003CexchangeSlot_003E5__7;

		private SetLock _003CtutorialLockSwipeSlot_003E5__8;

		private SetLock _003CtutorialLockExchangeSlot_003E5__9;

		private int _003CstartMove_003E5__10;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

        object IEnumerator<object>.Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        [DebuggerHidden]
		public _003CDoShowTutorial_003Ed__9(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }

	private Parameters parameters;

	public bool isBoardSettled;

	private ListSlotsProvider provider;

	private ShowPotentialMatchAction showPotentialMatchAction;

	private SlotChipPair swipeChipSlotInfo;

	private IEnumerator tutorialEnumerator;

	public void Init(Parameters parameters)
	{
	}

	public override void OnUpdate(float deltaTime)
	{
	}

	private IEnumerator DoShowTutorial()
	{
		return null;
	}

	public override void Stop()
	{
	}
}
