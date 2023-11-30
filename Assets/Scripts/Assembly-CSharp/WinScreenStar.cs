using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class WinScreenStar : MonoBehaviour
{
	private sealed class _003CDoMoveTo_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WinScreenStar _003C_003E4__this;

		public RectTransform moveToTransform;

		private Transform _003CmyTransform_003E5__2;

		private Vector3 _003CstartPositionLocal_003E5__3;

		private Vector3 _003CendPositionLocal_003E5__4;

		private int _003CstartAngle_003E5__5;

		private float _003CendAngle_003E5__6;

		private int _003CstartScale_003E5__7;

		private float _003CendScale_003E5__8;

		private float _003Ctime_003E5__9;

		private float _003Cduration_003E5__10;

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
		public _003CDoMoveTo_003Ed__3(int _003C_003E1__state)
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
	private Image image;

	private WinScreen winScreen;

	private WinScreen.Settings settings => null;

	public void Show(WinScreen winScreen)
	{
	}

	public IEnumerator DoMoveTo(RectTransform moveToTransform)
	{
		return null;
	}
}
