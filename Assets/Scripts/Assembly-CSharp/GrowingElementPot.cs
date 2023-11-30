using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GrowingElementPot : MonoBehaviour
{
	[Serializable]
	public class Settings
	{
		public Vector3 startScale;

		public Vector3 endScale;

		public AnimationCurve scaleCurve;

		public float scaleDuration;
	}

	private sealed class _003CDoAnimateIn_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GrowingElementPot _003C_003E4__this;

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
		public _003CDoAnimateIn_003Ed__12(int _003C_003E1__state)
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
	private Transform scaleTransform;

	[SerializeField]
	private Transform flowerTransform;

	[SerializeField]
	private Transform stemTransform;

	private IEnumerator animationEnum;

	private Settings settings => null;

	public Vector3 WorldPositionForFlower => default(Vector3);

	public void SetActve(bool active)
	{
	}

	public void AnimateIn()
	{
	}

	public void StopAnimation()
	{
	}

	public IEnumerator DoAnimateIn()
	{
		return null;
	}

	public void Update()
	{
	}
}
