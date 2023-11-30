using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GGMatch3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CompletionDialog : UILayer
{
	public class InitArguments
	{
		public struct Task
		{
			public string name;

			public SingleCurrencyPrice price;

			public CarModelPart part;

			public int index;

			public void SetIndex(int index)
			{
			}
		}

		public bool showModal;

		public List<Task> tasks;

		public Action<Task> onComplete;

		public Action onCancel;

		public CarModel.ProgressState progressState;

		public CarModelPart selectedPart;
	}

	private sealed class _003CDoShowStarAndExit_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CompletionDialogTask task;

		public CompletionDialog _003C_003E4__this;

		private IEnumerator _003CconfirmAnim_003E5__2;

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
		public _003CDoShowStarAndExit_003Ed__13(int _003C_003E1__state)
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
	private ComponentPool tasksPool;

	[SerializeField]
	private Image progressImage;

	[SerializeField]
	private TextMeshProUGUI progressText;

	[SerializeField]
	private float animationDelay;

	[SerializeField]
	private float padding;

	[SerializeField]
	private StarParticlesAnim starParticles;

	[NonSerialized]
	private InitArguments initArguments;

	[NonSerialized]
	private IEnumerator exitAnimation;

	public void Show(InitArguments init)
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void Init(InitArguments init)
	{
	}

	private IEnumerator DoShowStarAndExit(CompletionDialogTask task)
	{
		return null;
	}

	private void CompleteDialogTask_OnPressed(CompletionDialogTask task)
	{
	}

	public override void OnGoBack(NavigationManager nav)
	{
	}

	public void ButtonCallback_OnBack()
	{
	}

	private void ReportDone(CompletionDialogTask task)
	{
	}
}
