using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CurrencyPrefabAnimation : MonoBehaviour
{
	[Serializable]
	public class Scaler
	{
		[SerializeField]
		private bool scaleX;

		[SerializeField]
		private bool scaleY;

		[SerializeField]
		private bool scaleZ;

		public void LocalScale(Transform trans, float scale)
		{
		}
	}

	private sealed class _003CDoPlay_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CurrencyPrefabAnimation _003C_003E4__this;

		public float delay;

		public Action onEnd;

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
		public _003CDoPlay_003Ed__10(int _003C_003E1__state)
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
	private AnimationCurve scaleCurve;

	[SerializeField]
	private AnimationCurve alphaCurve;

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private Transform targetTransform;

	[SerializeField]
	private float duration;

	[SerializeField]
	private Scaler scaler;

	public IEnumerator animateInEnum;

	public void Init()
	{
	}

	public void Play(float delay, Action onEnd = null)
	{
	}

	public void Stop()
	{
	}

	public IEnumerator DoPlay(float delay, Action onEnd = null)
	{
		return null;
	}

	public void Update()
	{
	}
}
