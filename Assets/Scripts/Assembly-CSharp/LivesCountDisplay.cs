using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class LivesCountDisplay : MonoBehaviour
{
	private sealed class _003CCheckLivesRegeneration_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LivesCountDisplay _003C_003E4__this;

		private float _003Ctimer_003E5__2;

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
		public _003CCheckLivesRegeneration_003Ed__12(int _003C_003E1__state)
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
	private List<Transform> widgetsToHide;

	[SerializeField]
	private VisualStyleSet livesCountStyle;

	[SerializeField]
	private VisualStyleSet infiniteEnergyCountStyle;

	[SerializeField]
	private VisualStyleSet fullLivesCountStyle;

	[SerializeField]
	private TextMeshProUGUI livesText;

	[SerializeField]
	private TextMeshProUGUI heartsLivesText;

	[SerializeField]
	public float regenerationIntervalSeconds;

	private VisibilityHelper visibility;

	private IEnumerator updateEnumerator;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void UpdateVisualy()
	{
	}

	public IEnumerator CheckLivesRegeneration()
	{
		return null;
	}
}
