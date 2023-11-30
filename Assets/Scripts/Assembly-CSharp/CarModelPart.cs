using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CarModelPart : MonoBehaviour
{
	private delegate List<CarModelPart> ReturnListDelegate(CarModelPart part);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static ReturnListDelegate _003C_003E9__29_0;

		public static ReturnListDelegate _003C_003E9__29_1;

		internal List<CarModelPart> _003CInit_003Eb__29_0(CarModelPart part)
		{
			return null;
		}

		internal List<CarModelPart> _003CInit_003Eb__29_1(CarModelPart part)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public bool isDone;

		public AssembleCarScreen screen;

		public CarModelSubpart subpart;

		internal void _003CRemoveSubpart_003Eb__0(CarConfirmPurchase.InitArguments _003Cp0_003E)
		{
		}

		internal void _003CRemoveSubpart_003Eb__1()
		{
		}

		internal void _003CRemoveSubpart_003Eb__2()
		{
		}
	}

	private sealed class _003CRemoveSubpart_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssembleCarScreen screen;

		public CarModelSubpart subpart;

		private _003C_003Ec__DisplayClass32_0 _003C_003E8__1;

		public CarModelPart _003C_003E4__this;

		private IEnumerator _003CenumAnimation_003E5__2;

		private TalkingDialog _003CtalkingDialog_003E5__3;

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
		public _003CRemoveSubpart_003Ed__32(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public AssembleCarScreen screen;
	}

	private sealed class _003C_003Ec__DisplayClass34_1
	{
		public float animationProgressPercent;

		public CarModelSubpart item;

		public _003C_003Ec__DisplayClass34_0 CS_0024_003C_003E8__locals1;
	}

	private sealed class _003C_003Ec__DisplayClass34_2
	{
		public bool isDone;

		public TalkingDialog talkingDialog;

		public _003C_003Ec__DisplayClass34_1 CS_0024_003C_003E8__locals2;

		internal void _003CAnimateIn_003Eb__0(CarConfirmPurchase.InitArguments _003Cp0_003E)
		{
		}

		internal void _003CAnimateIn_003Eb__1()
		{
		}

		internal void _003CAnimateIn_003Eb__2()
		{
		}
	}

	private sealed class _003CAnimateIn_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssembleCarScreen screen;

		public CarModelPart _003C_003E4__this;

		private _003C_003Ec__DisplayClass34_0 _003C_003E8__1;

		private _003C_003Ec__DisplayClass34_1 _003C_003E8__2;

		private _003C_003Ec__DisplayClass34_2 _003C_003E8__3;

		private EnumeratorsList _003CenumList_003E5__2;

		private IEnumerator _003CcustomizationsEnum_003E5__3;

		private int _003Ci_003E5__4;

		private bool _003CskipAnimation_003E5__5;

		private IEnumerator _003CremoveEnum_003E5__6;

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
		public _003CAnimateIn_003Ed__34(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public CarModelInfo.VariantGroup groupToShow;

		public bool isVariantChosen;

		public CarModelPart _003C_003E4__this;

		internal void _003CShowCustomizations_003Eb__0(CarVariationPanel _003Cp0_003E)
		{
		}

		internal void _003CShowCustomizations_003Eb__1(CarVariationPanel _003Cp0_003E)
		{
		}
	}

	private sealed class _003CShowCustomizations_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<string> variantGroups;

		public CarModelPart _003C_003E4__this;

		public AssembleCarScreen screen;

		private _003C_003Ec__DisplayClass35_0 _003C_003E8__1;

		private int _003Ci_003E5__2;

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
		public _003CShowCustomizations_003Ed__35(int _003C_003E1__state)
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
	public List<CarModelSubpart> subparts;

	[SerializeField]
	public CarModel model;

	[SerializeField]
	public CarPartInfo partInfo;

	[SerializeField]
	private Transform buttonHandleTransform;

	[SerializeField]
	public List<WorldButtonHandle> worldButtonHandles;

	[SerializeField]
	public List<PaintTransformation> paintTransformations;

	[SerializeField]
	public Transform colliderRoot;

	private List<CarModelSubpart> subpartsWithVariantHandles_;

	public Sprite buttonHandleSprite => null;

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

	public Vector3 directionHandlePosition => default(Vector3);

	public bool isShowing => false;

	public List<CarModelSubpart> subpartsWithVariantHandles => null;

	public List<CarModelSubpart> subpartsWithInteraction => null;

	public List<CarModelSubpart> subpartsWithInfoBoxes => null;

	public CarModelInfo.VariantGroup firstVariantGroup => null;

	public void ResetModel()
	{
	}

	public void RefreshVisibilityBasedOnPartBeingOpen(CarModelPart part)
	{
	}

	public void SetExplodeOffset(float nTime)
	{
	}

	public void ReparentSubpartsToHinges()
	{
	}

	public void Init(CarModel model)
	{
	}

	private bool IsCircularInList(List<CarModelPart> parts, ReturnListDelegate returnList)
	{
		return false;
	}

	private IEnumerator RemoveSubpart(CarModelSubpart subpart, AssembleCarScreen screen)
	{
		return null;
	}

	public void ShowSubpartsIfRemoving()
	{
	}

	public IEnumerator AnimateIn(AssembleCarScreen screen)
	{
		return null;
	}

	public IEnumerator ShowCustomizations(List<string> variantGroups, AssembleCarScreen screen)
	{
		return null;
	}

	public void InitForRuntime(RoomsBackend.RoomAccessor backend)
	{
	}

	public void HideSubparts()
	{
	}

	public void SetActiveIfOwned()
	{
	}

	public void SetActive(bool active)
	{
	}
}
