using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class StarConsumeAnimation : MonoBehaviour
{
	[Serializable]
	public class Settings
	{
		public float moveStartScale;

		public float moveEndScale;

		public float moveDuration;

		public float animationDelayDuration;

		public float moveEndAlpha;

		public AnimationCurve moveCurve;

		public float endScale;

		public float scaleDuration;

		public float whiteoutAlphaEnd;

		public AnimationCurve scaleCurve;
	}

	public struct InitParams
	{
		public DecorateRoomScreen screen;

		public DecorateRoomSceneVisualItem visualItem;

		public Action onEnd;
	}

	private sealed class _003CDoAnimation_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StarConsumeAnimation _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private Settings _003Csettings_003E5__3;

		private Vector3 _003CstartLocalPos_003E5__4;

		private Vector3 _003CendLocalPos_003E5__5;

		private Vector3 _003CstartScale_003E5__6;

		private float _003CstartAlpha_003E5__7;

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
		public _003CDoAnimation_003Ed__9(int _003C_003E1__state)
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
	private StarConsumeAnimationStar star;

	[SerializeField]
	private RectTransform originStarTransform;

	private InitParams initParams;

	private IEnumerator animationEnumerator;

	public Settings settings => null;

	public void Show(InitParams initParams)
	{
	}

	private IEnumerator DoAnimation()
	{
		return null;
	}

	private void Update()
	{
	}
}
