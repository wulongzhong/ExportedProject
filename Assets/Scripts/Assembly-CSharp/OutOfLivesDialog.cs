using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class OutOfLivesDialog : MonoBehaviour
{
	public class State
	{
		public int lives;

		public float secsToNextLife;
	}

	private sealed class _003CUpdateLives_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OutOfLivesDialog _003C_003E4__this;

		private float _003Ctime_003E5__2;

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
		public _003CUpdateLives_003Ed__24(int _003C_003E1__state)
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

	[SerializeField]
	private TextMeshProUGUI livesCountLabel;

	[SerializeField]
	private TextMeshProUGUI timeCountLabel;

	[SerializeField]
	private TextMeshProUGUI priceLabel;

	[SerializeField]
	private TextMeshProUGUI coinsLabel;

	[SerializeField]
	private string priceFormat;

	private Action onAllLivesRefilled;

	private Action onMinLivesAvailable;

	private Action onHide;

	private State initState;

	private State currentState;

	[SerializeField]
	private List<RectTransform> widgetsToHide;

	[SerializeField]
	private VisualStyleSet noLivesStyle;

	[SerializeField]
	private VisualStyleSet someLivesStyle;

	[SerializeField]
	private VisualStyleSet fullLivesStyle;

	private LivesPriceConfig.PriceConfig priceConfig;

	private IEnumerator updateLivesEnum;

	private int maxLives => 0;

	public void Show(LivesPriceConfig.PriceConfig priceConfig, Action onAllLivesRefilled, Action onMinLivesAvailable, Action onHide)
	{
	}

	public void Init()
	{
	}

	public void Hide()
	{
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void UpdateVisuals()
	{
	}

	public void UpdateState()
	{
	}

	public void Update()
	{
	}

	public IEnumerator UpdateLives()
	{
		return null;
	}

	public void ButtonCallback_RefillLives()
	{
	}
}
