using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class WeldingLine : MonoBehaviour
{
	private struct WeldSpherePos
	{
		public Vector3 position;

		public Vector3 scale;

		public float time;

		public bool isSet;

		public WeldSphere sphere;

		public float localTime;
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public float time;

		internal void _003CDoWeld_003Eb__0(ScrewdriverTool.PressArguments _003Cp0_003E)
		{
		}
	}

	private sealed class _003CDoWeld_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarModel model;

		public WeldingLine _003C_003E4__this;

		public AssembleCarScreen screen;

		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		private ComponentPool _003CweldingSpheres_003E5__2;

		private Vector3 _003CfromPos_003E5__3;

		private Vector3 _003CtoPos_003E5__4;

		private List<WeldSpherePos> _003Cpositions_003E5__5;

		private float _003Cduration_003E5__6;

		private GGSoundSystem.LoopSoundFxClip _003Csound_003E5__7;

		private ScrewdriverTool _003CscrewdriverTool_003E5__8;

		private float _003CsphereFadeDuration_003E5__9;

		private Vector3 _003Coffset_003E5__10;

		private DrillModel _003Cwelder_003E5__11;

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
		public _003CDoWeld_003Ed__5(int _003C_003E1__state)
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

	public Transform from;

	public Transform to;

	public string cameraPosition;

	[SerializeField]
	private float sphereSize;

	public IEnumerator DoWeld(AssembleCarScreen screen, CarModel model)
	{
		return null;
	}
}
