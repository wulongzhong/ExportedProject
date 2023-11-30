using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TutorialHandController : MonoBehaviour
{
	[Serializable]
	public class Settings
	{
		public float scaleHandFrom;

		public float scaleHandTo;

		public float alphaHandFrom;

		public float alphaHandTo;

		public float scaleInDuration;

		public AnimationCurve scaleInCurve;

		public float delayAfterScale;

		public float moveDuration;

		public AnimationCurve moveCurve;

		public float waitOnDestination;

		public float fromAlphaMove;

		public float toAlphaMove;
	}

	public struct InitArguments
	{
		public Vector3 startLocalPosition;

		public Vector3 endLocalPosition;

		public bool repeat;

		public Settings settings;
	}

	private sealed class _003CDoAnimation_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialHandController _003C_003E4__this;

		public InitArguments initArguments;

		private IEnumerator _003CanimEnum_003E5__2;

		private float _003Ctime_003E5__3;

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
		public _003CDoAnimation_003Ed__12(int _003C_003E1__state)
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

	private sealed class _003CDoMove_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialHandController _003C_003E4__this;

		private Vector3 _003CfromPosition_003E5__2;

		private Vector3 _003CtoPosition_003E5__3;

		private float _003Cduration_003E5__4;

		private float _003Ctime_003E5__5;

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
		public _003CDoMove_003Ed__13(int _003C_003E1__state)
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

	private sealed class _003CScaleIn_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialHandController _003C_003E4__this;

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
		public _003CScaleIn_003Ed__14(int _003C_003E1__state)
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
	private Transform handContainer;

	[SerializeField]
	private TrailRenderer trail;

	[SerializeField]
	private CanvasGroup handAlpha;

	private InitArguments initArguments;

	private IEnumerator animation;

	private Settings settngs => null;

	public void Show(InitArguments initArguments)
	{
	}

	public void Hide()
	{
	}

	private IEnumerator DoAnimation(InitArguments initArguments)
	{
		return null;
	}

	private IEnumerator DoMove()
	{
		return null;
	}

	private IEnumerator ScaleIn()
	{
		return null;
	}

	private void Update()
	{
	}
}
