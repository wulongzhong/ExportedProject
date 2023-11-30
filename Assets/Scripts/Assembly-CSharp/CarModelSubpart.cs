using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CarModelSubpart : MonoBehaviour
{
	[Serializable]
	public class Settings
	{
		public float inDuration;

		public float fromScale;

		public float toScale;

		public AnimationCurve scaleCurve;

		public float moveDuration;

		public AnimationCurve moveCurve;

		public float openDuration;
	}

	[Serializable]
	public class BlinkSettings
	{
		public float inDuration;

		public float fromScale;

		public float toScale;

		public AnimationCurve scaleCurve;

		public float moveDuration;

		public float fromScaleChange;

		public float changeOffset;

		public AnimationCurve moveCurve;
	}

	private struct NutState
	{
		public Vector3 start;

		public Vector3 end;

		public Vector3 currentPosition;

		public float currentPercent;

		public Vector3 offset;

		public Transform nutTransform;

		public CarNut carNut;

		public Vector3 PercentPosition(Vector3 nutOffset)
		{
			return default(Vector3);
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public int variant;

		internal bool _003CRemoveAllModificationsOfVariant_003Eb__0(VariantModification mod)
		{
			return false;
		}
	}

	private sealed class _003CInAnimationScaleBounce_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarModelSubpart _003C_003E4__this;

		private Settings _003Csettings_003E5__2;

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
		public _003CInAnimationScaleBounce_003Ed__35(int _003C_003E1__state)
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

	private sealed class _003CDoChangeRotation_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarModelSubpart _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private float _003Cduration_003E5__3;

		private Quaternion _003CstartRotation_003E5__4;

		private Quaternion _003CendRotation_003E5__5;

		private AnimationCurve _003CtimeCurve_003E5__6;

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
		public _003CDoChangeRotation_003Ed__48(int _003C_003E1__state)
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

	private sealed class _003CDoShowChange_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarModelSubpart _003C_003E4__this;

		public float scaleMult;

		private float _003Ctime_003E5__2;

		private float _003Cduration_003E5__3;

		private Vector3 _003CstartPosition_003E5__4;

		private AnimationCurve _003Ccurve_003E5__5;

		private Vector3 _003CendPosition_003E5__6;

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
		public _003CDoShowChange_003Ed__54(int _003C_003E1__state)
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

	private sealed class _003CRotateInSingleNut_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NutState state;

		public float delay;

		public float duration;

		public CarNut nut;

		private Vector3 _003CfromPosition_003E5__2;

		private Vector3 _003CtoPosition_003E5__3;

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
		public _003CRotateInSingleNut_003Ed__55(int _003C_003E1__state)
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

	private sealed class _003CRotateOutSingleNut_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NutState state;

		public float delay;

		public float duration;

		public CarNut nut;

		public CarModelSubpart _003C_003E4__this;

		private Vector3 _003CfromPosition_003E5__2;

		private Vector3 _003CtoPosition_003E5__3;

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
		public _003CRotateOutSingleNut_003Ed__56(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public AssembleCarScreen screen;

		public CarModelSubpart _003C_003E4__this;

		public TalkingDialog talkingDialog;
	}

	private sealed class _003C_003Ec__DisplayClass57_1
	{
		public float time;

		public _003C_003Ec__DisplayClass57_0 CS_0024_003C_003E8__locals1;

		internal void _003CShowRemoveNutAnimations_003Eb__0(ScrewdriverTool.PressArguments _003Cp0_003E)
		{
		}
	}

	private sealed class _003CShowRemoveNutAnimations_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssembleCarScreen screen;

		public CarModelSubpart _003C_003E4__this;

		private _003C_003Ec__DisplayClass57_0 _003C_003E8__1;

		private _003C_003Ec__DisplayClass57_1 _003C_003E8__2;

		private CarNutsPool _003Cnuts_003E5__2;

		private List<CarNut> _003CnutsList_003E5__3;

		private Vector3 _003CoffsetDirection_003E5__4;

		private Vector3 _003CnutOffset_003E5__5;

		private NutState[] _003CnutStates_003E5__6;

		private int _003Ci_003E5__7;

		private Transform _003Citem_003E5__8;

		private CarNut _003Cnut_003E5__9;

		private NutState _003Cstate_003E5__10;

		private Vector3 _003CnutOffsetDirection_003E5__11;

		private float _003CtoolDistanceFromCamera_003E5__12;

		private ScrewdriverTool _003CscrewdriverTool_003E5__13;

		private float _003Cduration_003E5__14;

		private bool _003CautoShow_003E5__15;

		private DrillModel _003Cdrill_003E5__16;

		private Vector3 _003CfromPosition_003E5__17;

		private Vector3 _003CtoPosition_003E5__18;

		private Quaternion _003CtoolRotation_003E5__19;

		private CarCamera _003Ccamera_003E5__20;

		private EnumeratorsList _003CenumList_003E5__21;

		private float _003CtotalDuration_003E5__22;

		private float _003CstartN_003E5__23;

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
		public _003CShowRemoveNutAnimations_003Ed__57(int _003C_003E1__state)
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

	private sealed class _003CShowWelding_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarModelSubpart _003C_003E4__this;

		public AssembleCarScreen screen;

		private ComponentPool _003CweldingSpheres_003E5__2;

		private float _003Ctime_003E5__3;

		private float _003Cduration_003E5__4;

		private int _003Ci_003E5__5;

		private IEnumerator _003ClineEnum_003E5__6;

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
		public _003CShowWelding_003Ed__58(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public float time;

		internal void _003CShowNutAnimations_003Eb__0(ScrewdriverTool.PressArguments _003Cp0_003E)
		{
		}
	}

	private sealed class _003CShowNutAnimations_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarModelSubpart _003C_003E4__this;

		public AssembleCarScreen screen;

		private _003C_003Ec__DisplayClass60_0 _003C_003E8__1;

		private CarNutsPool _003Cnuts_003E5__2;

		private bool _003ChasNutOffset_003E5__3;

		private Vector3 _003CstartPostion_003E5__4;

		private Vector3 _003CendPosition_003E5__5;

		private Vector3 _003CnutOffset_003E5__6;

		private Vector3 _003CrotationAxis_003E5__7;

		private Vector3 _003CoffsetDirection_003E5__8;

		private NutState[] _003CnutStates_003E5__9;

		private Quaternion _003CbeginRotation_003E5__10;

		private int _003Ci_003E5__11;

		private Transform _003Citem_003E5__12;

		private ScrewdriverTool _003CscrewdriverTool_003E5__13;

		private DrillModel _003Cdrill_003E5__14;

		private NutState _003Cstate_003E5__15;

		private CarNut _003Cnut_003E5__16;

		private Vector3 _003CnutOffsetDirection_003E5__17;

		private float _003CtoolDistanceFromCamera_003E5__18;

		private float _003Cduration_003E5__19;

		private Vector3 _003CfromPosition_003E5__20;

		private Vector3 _003CtoPosition_003E5__21;

		private Quaternion _003CtoolRotation_003E5__22;

		private EnumeratorsList _003CenumList_003E5__23;

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
		public _003CShowNutAnimations_003Ed__60(int _003C_003E1__state)
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

	private sealed class _003CInAnimationOffset_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarModelSubpart _003C_003E4__this;

		public float percent;

		private float _003Ctime_003E5__2;

		private float _003Cduration_003E5__3;

		private AnimationCurve _003Ccurve_003E5__4;

		private Vector3 _003CstartPosition_003E5__5;

		private Vector3 _003CendPosition_003E5__6;

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
		public _003CInAnimationOffset_003Ed__61(int _003C_003E1__state)
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

	private sealed class _003CInAnimationScaleOffset_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarModelSubpart _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private float _003Cduration_003E5__3;

		private AnimationCurve _003Ccurve_003E5__4;

		private Vector3 _003CstartPosition_003E5__5;

		private Vector3 _003CendPosition_003E5__6;

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
		public _003CInAnimationScaleOffset_003Ed__62(int _003C_003E1__state)
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

	private sealed class _003CInAnimation_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public CarModelSubpart _003C_003E4__this;

		private IEnumerator _003CanimationEnum_003E5__2;

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
		public _003CInAnimation_003Ed__63(int _003C_003E1__state)
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
	private Vector3 scaleAtStart;

	[SerializeField]
	private Vector3 localPositionAtStart;

	[SerializeField]
	public CarModelPart part;

	[SerializeField]
	private Transform handleTransform_;

	[SerializeField]
	public List<SubpartVariant> variants;

	[SerializeField]
	public List<VariantModification> variantModifications;

	[SerializeField]
	public List<Transform> nutTransforms;

	[SerializeField]
	private List<WeldingLine> weldingLines;

	[SerializeField]
	public string defaultVariantGroupName;

	private IEnumerator activeAnimation;

	private IEnumerator openAnimation;

	[SerializeField]
	public Transform variantHandle;

	[SerializeField]
	public string variantGroupName;

	[SerializeField]
	public CarSubPartInfo subpartInfo;

	private bool isOpen;

	public CarModelInfo.VariantGroup firstVariantGroup => null;

	public Vector3 buttonHandlePosition
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Transform handleTransform => null;

	public string displayName => null;

	private BlinkSettings blinkSettings => null;

	private Settings settings => null;

	public bool HasWeldingAnimations => false;

	public bool HasNutAnimations => false;

	public bool IsPartOfCustomization(CarModelCustomization customization)
	{
		return false;
	}

	public void RemoveAllModificationsOfVariant(int variant)
	{
	}

	public bool HasVariantForGroup(CarModelInfo.VariantGroup group)
	{
		return false;
	}

	public void Editor_SetFirstNutPosition(Vector3 position)
	{
	}

	public void Init(CarModelPart part)
	{
	}

	private static void FindTransformsStartingWith(Transform root, string prefix, List<Transform> tags)
	{
	}

	public IEnumerator InAnimationScaleBounce()
	{
		return null;
	}

	public void Hide()
	{
	}

	public void ResetVariations()
	{
	}

	public void Show(bool force = false)
	{
	}

	public void ReparentToHingeIfNeeded()
	{
	}

	public void ApplyVariantModification(int selectedVariationIndex, bool useSharedMaterial)
	{
	}

	private void ShowActiveVariant()
	{
	}

	public void SetOffsetPosition()
	{
	}

	public void SetOffsetPosition(float p)
	{
	}

	public void SetExplodeOffset(float nTime, float distance)
	{
	}

	public static void ShowChange(List<CarModelSubpart> subparts, float scale = 1f)
	{
	}

	public void ChangeRotation()
	{
	}

	private IEnumerator DoChangeRotation()
	{
		return null;
	}

	public void ShowChange(float scale)
	{
	}

	public IEnumerator DoShowChange(float scaleMult)
	{
		return null;
	}

	private IEnumerator RotateInSingleNut(CarNut nut, NutState state, float duration, float delay)
	{
		return null;
	}

	private IEnumerator RotateOutSingleNut(CarNut nut, NutState state, float duration, float delay)
	{
		return null;
	}

	public IEnumerator ShowRemoveNutAnimations(AssembleCarScreen screen)
	{
		return null;
	}

	public IEnumerator ShowWelding(AssembleCarScreen screen)
	{
		return null;
	}

	public IEnumerator ShowNutAnimations(AssembleCarScreen screen)
	{
		return null;
	}

	public IEnumerator InAnimationOffset(float percent)
	{
		return null;
	}

	public IEnumerator InAnimationScaleOffset()
	{
		return null;
	}

	public IEnumerator InAnimation(float delay = 0f)
	{
		return null;
	}

	private void Update()
	{
	}
}
