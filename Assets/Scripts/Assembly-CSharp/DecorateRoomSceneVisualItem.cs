using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DecorateRoomSceneVisualItem : MonoBehaviour
{
	[Serializable]
	public class Settings
	{
		public float durationOfPop;

		public Vector3 startScale;

		public AnimationCurve popCurve;

		public float delayPerIndex;

		public float loopDuration;

		public Vector3 loopOffset;

		public Vector3 loopScaleOffset;

		public AnimationCurve loopCurve;
	}

	public class PointWithIndex
	{
		public Vector2 point;

		public int index;
	}

	private sealed class _003CDoAnimation_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DecorateRoomSceneVisualItem _003C_003E4__this;

		public float delay;

		private RectTransform _003CtransformToChange_003E5__2;

		private float _003Ctime_003E5__3;

		private float _003CmyDelay_003E5__4;

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
		public _003CDoAnimation_003Ed__13(int _003C_003E1__state)
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
	private ComponentPool markersPool;

	[SerializeField]
	private RectTransform buyButtonContanier;

	[SerializeField]
	private RectTransform animationTransform;

	[SerializeField]
	private RectTransform animationOffsetTransform;

	[SerializeField]
	private List<RectTransform> widgetsToHide;

	[NonSerialized]
	public VisualObjectBehaviour visualObjectBehaviour;

	[NonSerialized]
	private DecorateRoomScreen screen;

	private IEnumerator animationCoroutine;

	private int index;

	private List<Vector2> pointsCachedList;

	public Settings settings => null;

	public void Init(VisualObjectBehaviour visualObjectBehaviour, DecorateRoomScreen screen, int index, float delay)
	{
	}

	private IEnumerator DoAnimation(float delay)
	{
		return null;
	}

	private void SetPositionOfBuyButton()
	{
	}

	private void Update()
	{
	}

	public void HideButton()
	{
	}

	public void ShowMarkers()
	{
	}

	public int Sort_MinX(PointWithIndex a, PointWithIndex b)
	{
		return 0;
	}

	public int Sort_MinY(PointWithIndex a, PointWithIndex b)
	{
		return 0;
	}

	public int Sort_Index(PointWithIndex a, PointWithIndex b)
	{
		return 0;
	}

	public void ButtonCallback_OnBuyButton()
	{
	}
}
