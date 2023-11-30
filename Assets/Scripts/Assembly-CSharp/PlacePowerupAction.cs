using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GGMatch3;
using UnityEngine;

public class PlacePowerupAction : BoardAction
{
	[Serializable]
	public class Settings
	{
		public float delayBetweenPowerups;

		public float durationForPowerup;

		public AnimationCurve powerupCurve;

		public float startScale;

		public float startAlpha;

		public float normalizedTimeForParticles;
	}

	public class Parameters
	{
		public Match3Game game;

		public ChipType powerup;

		public float initialDelay;

		public int addCoins;

		public Slot slotWhereToPlacePowerup;

		public bool internalAnimation;

		public Action onComplete;
	}

	public class ConstraintsFilter
	{
		public List<Slot> GetSlotsThatCanBeReplacedWithPowerup(List<Slot> slots)
		{
			return null;
		}

		public List<Slot> GetTappableSlots(List<Slot> slots)
		{
			return null;
		}

		public List<Slot> GetSwappableSlotsForDiscoBomb(List<Slot> slots)
		{
			return null;
		}

		public List<Slot> GetNoPowerupPlacementSlots(List<Slot> slots)
		{
			return null;
		}
	}

	private sealed class _003CDoReplaceChipWithPowerup_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlacePowerupAction _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private IEnumerator _003Cenumerator_003E5__3;

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
		public _003CDoReplaceChipWithPowerup_003Ed__12(int _003C_003E1__state)
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

	private sealed class _003CPowerupCreation_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlacePowerupAction _003C_003E4__this;

		public IntVector2 positionWherePowerupWillBeCreated;

		private Match3Game _003Cgame_003E5__2;

		private float _003Ctime_003E5__3;

		private Slot _003CpowerupSlot_003E5__4;

		private TransformBehaviour _003CchipTransform_003E5__5;

		private float _003Cduration_003E5__6;

		private AnimationCurve _003Ccurve_003E5__7;

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
		public _003CPowerupCreation_003Ed__13(int _003C_003E1__state)
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

	private Slot slot;

	private Parameters parameters;

	private Lock slotLock;

	private IEnumerator replaceChipWithPowerup;

	private float deltaTime;

	private Settings settings => null;

	public static Slot GetSlotThatCanBeReplacedWithPowerup(Match3Game game, ChipType powerup)
	{
		return null;
	}

	public void Init(Parameters parameters)
	{
	}

	public override void OnUpdate(float deltaTime)
	{
	}

	public IEnumerator DoReplaceChipWithPowerup()
	{
		return null;
	}

	private IEnumerator PowerupCreation(IntVector2 positionWherePowerupWillBeCreated)
	{
		return null;
	}
}
