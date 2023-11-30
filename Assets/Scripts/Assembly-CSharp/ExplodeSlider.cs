using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class ExplodeSlider : MonoBehaviour
{
	[Serializable]
	public class ExplosionSettings
	{
		public float minValueWhenSwitch;

		public float distanceFromCenter;

		public float durationToReturn;

		public AnimationCurve unexplodeTimeCurve;

		public AnimationCurve sliderCurve;
	}

	private sealed class _003CSpringOnSlider_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ExplodeSlider _003C_003E4__this;

		public float change;

		private float _003CcurrentTime_003E5__2;

		private ExplodeAnimation _003CexplodeAnimation_003E5__3;

		private float _003CendTime_003E5__4;

		private float _003Cduration_003E5__5;

		private float _003Ctime_003E5__6;

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
		public _003CSpringOnSlider_003Ed__18(int _003C_003E1__state)
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

	private sealed class _003CUnexplode_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ExplodeSlider _003C_003E4__this;

		private float _003CstartValue_003E5__2;

		private float _003Cduration_003E5__3;

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
		public _003CUnexplode_003Ed__19(int _003C_003E1__state)
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
	private Slider slider;

	[SerializeField]
	private Transform unexplodeButton;

	[NonSerialized]
	private AssembleCarScreen screen;

	[NonSerialized]
	private IEnumerator sliderAnim;

	[NonSerialized]
	private float sliderValueOnDragStart;

	public ExplosionSettings settings => null;

	public float value => 0f;

	public bool isExploded => false;

	private CarScene scene => null;

	public void Reset()
	{
	}

	public void Init(AssembleCarScreen screen)
	{
	}

	public void StopSlider()
	{
	}

	private void UpdateButtonActive(float value)
	{
	}

	private IEnumerator SpringOnSlider(float change)
	{
		return null;
	}

	public IEnumerator Unexplode()
	{
		return null;
	}

	public void ButtonCallbacks_OnUnexplode()
	{
	}

	public void SliderCallback_OnDragStart()
	{
	}

	public void SliderCallback_OnDragEnd()
	{
	}

	public void SliderCallback_OnValueChanged()
	{
	}

	private void Update()
	{
	}
}
