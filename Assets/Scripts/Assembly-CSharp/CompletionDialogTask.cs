using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CompletionDialogTask : MonoBehaviour
{
	private sealed class _003CDoConfirmPress_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float scaleFrom;

		public float scaleTo;

		public float duration;

		public EasingEquation easing;

		public CompletionDialogTask _003C_003E4__this;

		private Vector3 _003CfromScale_003E5__2;

		private Vector3 _003CtoScale_003E5__3;

		private float _003Ctime_003E5__4;

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
		public _003CDoConfirmPress_003Ed__13(int _003C_003E1__state)
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
	private TextMeshProUGUI headerLabel;

	[SerializeField]
	private TextMeshProUGUI priceLabel;

	[SerializeField]
	private List<Transform> selectedList;

	[SerializeField]
	private List<Transform> hideWhenSelected;

	[SerializeField]
	private List<Image> taskImages;

	[SerializeField]
	private Sprite defaultTaskSprite;

	[SerializeField]
	private CurrencyPrefabAnimation animation;

	private Action<CompletionDialogTask> onComplete;

	[NonSerialized]
	public CompletionDialog.InitArguments.Task task;

	public void Init(CompletionDialog.InitArguments.Task task, Action<CompletionDialogTask> onComplete)
	{
	}

	public void AnimateIn(float delay)
	{
	}

	public void ShowSelected()
	{
	}

	public void SetSelectedActive(bool active)
	{
	}

	public IEnumerator DoConfirmPress(float duration, float scaleFrom, float scaleTo, EasingEquation easing)
	{
		return null;
	}

	public void ButtonCallback_OnPress()
	{
	}
}
