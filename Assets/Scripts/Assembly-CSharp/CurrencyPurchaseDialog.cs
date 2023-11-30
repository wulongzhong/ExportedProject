using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GGMatch3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyPurchaseDialog : UILayer
{
	public enum PageType
	{
		FirstPage = 0,
		AllPage = 1
	}

	[Serializable]
	public class LimitTypePageConfig
	{
		[SerializeField]
		private int maxBigElements;

		[SerializeField]
		private int maxSmallElements;

		private PageSpace pageSpace;

		public void Pack(List<PageItemInfo> infos)
		{
		}
	}

	[Serializable]
	public class PageConfig
	{
		private PageSpace pageSpace;

		public virtual void Pack(List<PageItemInfo> infos)
		{
		}

		public static int Sort_Rank(PageItemInfo a, PageItemInfo b)
		{
			return 0;
		}
	}

	public class PageItemInfo
	{
		public Vector2 space;

		public int count;

		public List<PageSpace.FittingResult> results;

		public int rank;

		public PageSpace.SpacingInfo spacingInfo;
	}

	public class PageSpace
	{
		public class FittingResult
		{
			public bool succeeded;

			public Vector2 position;
		}

		public class SpacingInfo
		{
			public Vector2 size;

			public Vector2 offset;

			public Vector2 groupOffset;

			public Vector2 direction;

			public float totalSize => 0f;
		}

		public float occupiedSpace;

		private SpacingInfo spaceInfo;

		public float freeSpace => 0f;

		public void Clear()
		{
		}

		public void Init(SpacingInfo info)
		{
		}

		public FittingResult TryToFit(Vector2 space)
		{
			return null;
		}
	}

	private sealed class _003CDoAnimateOut_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CurrencyPurchaseDialog _003C_003E4__this;

		public Action onEnd;

		private EnumeratorsList _003CenumList_003E5__2;

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
		public _003CDoAnimateOut_003Ed__35(int _003C_003E1__state)
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

	private Action onHide;

	[SerializeField]
	private LimitTypePageConfig firstPageConfig;

	private PageConfig defaultPageConfig;

	[SerializeField]
	private ComponentPool namedOffersPool;

	[SerializeField]
	private ComponentPool unamedOffersPool;

	[SerializeField]
	private ComponentPool unamedGroupContainerPool;

	[SerializeField]
	private RectTransform offersContainer;

	[SerializeField]
	private RectTransform namedOffersContainer;

	[SerializeField]
	private RectTransform unamedOffersContainer;

	[SerializeField]
	private RectTransform nextButtonContainer;

	[SerializeField]
	private Vector2 spacingBigPrefabs;

	[SerializeField]
	private Vector2 spacingSmallPrefabs;

	[SerializeField]
	private Vector2 groupsSpacing;

	[SerializeField]
	private int smallItemsPerGroup;

	[SerializeField]
	private TextMeshProUGUI coinsCurrencyLabel;

	[SerializeField]
	private float totalScrollingPaddingHorizontalWorldSpace;

	[SerializeField]
	private ScrollRect scrollRect;

	private OffersDB offers;

	[SerializeField]
	private CurrencyPurchaseDialogNextButton nextButton;

	[SerializeField]
	private float animationDelayPerColumn;

	private List<CurrencyPurchaseDialogMultyPrefab> groupSmallItems;

	private List<CurrencyPurchaseDialogSmallPrefab> smallItems;

	private List<CurrencyPurchaseDialogBigPrefab> bigItems;

	private PageType type;

	private IEnumerator animateOutEnum;

	public void Show(OffersDB offers, Action onHide = null)
	{
	}

	public void Init()
	{
	}

	public void Init(OffersDB offers, Action onHide, PageType type)
	{
	}

	private List<RectTransform> CreateSmallPrefabs(List<OffersDB.ProductDefinition> products, int startIndex, int length)
	{
		return null;
	}

	public void ButtonCallback_Next()
	{
	}

	public void ButtonCallback_Close()
	{
	}

	public override void OnGoBack(NavigationManager nav)
	{
	}

	private void Hide()
	{
	}

	private void OnHideEnd()
	{
	}

	private IEnumerator DoAnimateOut(Action onEnd = null)
	{
		return null;
	}

	public void Update()
	{
	}

	public void OnButtonPressed(CurrencyPurchaseDialogSmallPrefab button)
	{
	}

	public void OnButtonPressed(CurrencyPurchaseDialogBigPrefab button)
	{
	}

	private void BuyOffer(OffersDB.ProductDefinition product)
	{
	}

	private void OnEnable()
	{
	}
}
