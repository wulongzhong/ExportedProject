using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GGMatch3;
using TMPro;
using UnityEngine;

public class GiftBoxScreen : MonoBehaviour
{
	public enum GiftType
	{
		Coins = 0,
		Powerup = 1,
		Booster = 2,
		Energy = 3,
		Stars = 4
	}

	public struct ShowArguments
	{
		public string title;

		public Action onComplete;

		public GiftsDefinition giftsDefinition;
	}

	[Serializable]
	public class Gift
	{
		public GiftType giftType;

		public PowerupType powerupType;

		public BoosterType boosterType;

		public int amount;

		public int hours;

		public TimeSpan duration => default(TimeSpan);

		public static Gift CreateCoins(int amount)
		{
			return null;
		}

		public static Gift CreatePowerup(PowerupType powerupType, int amount)
		{
			return null;
		}

		public static Gift CreateBooster(BoosterType boosterType, int amount)
		{
			return null;
		}

		public static Gift CreateStars(int amount)
		{
			return null;
		}

		public static Gift CreateEnergy(int hours)
		{
			return null;
		}

		public void ConsumeGift()
		{
		}
	}

	[Serializable]
	public class GiftsDefinition
	{
		public List<Gift> gifts;

		public void ConsumeGift()
		{
		}

		public void Add(Gift gift)
		{
		}
	}

	private sealed class _003CInAnimation_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GiftBoxScreen _003C_003E4__this;

		private IEnumerator _003CwaitingEnum_003E5__2;

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
		public _003CInAnimation_003Ed__19(int _003C_003E1__state)
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

	private ShowArguments showArguments;

	[SerializeField]
	private List<Transform> widgetsToHide;

	[SerializeField]
	private RectTransform giftBoxContainer;

	[SerializeField]
	private Animator giftBoxAnimator;

	[SerializeField]
	private UIWaitForTap waitForTap;

	[SerializeField]
	private Transform openContainer;

	[SerializeField]
	private ComponentPool giftItemPool;

	[SerializeField]
	private TextMeshProUGUI titleText;

	[SerializeField]
	private float padding;

	private IEnumerator animation;

	private GiftsDefinition giftsDefinition;

	public string giftBoxInAnimationName;

	public void Show(ShowArguments showArguments)
	{
	}

	private void OnEnable()
	{
	}

	private void Init(ShowArguments showArguments)
	{
	}

	private IEnumerator InAnimation()
	{
		return null;
	}

	private void Update()
	{
	}
}
