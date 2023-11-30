using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CarModel : MonoBehaviour
{
	public struct ProgressState
	{
		public int completed;

		public int total;

		public bool isPassed => false;

		public float progress => 0f;

		public float Progress(int removeCompleted)
		{
			return 0f;
		}
	}

	private sealed class _003CDoShowChange_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float scaleMult;

		public CarModel _003C_003E4__this;

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
		public _003CDoShowChange_003Ed__47(int _003C_003E1__state)
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

	public CarModelSubpart selectedSubpart;

	[SerializeField]
	public CarNutsPool nuts;

	[SerializeField]
	public ComponentPool weldingSpheres;

	[SerializeField]
	public List<CarModelPart> parts;

	[SerializeField]
	public List<PartHinge> hinges;

	[SerializeField]
	public List<DrivePart> driveParts;

	[SerializeField]
	public List<CarModelCustomization> customizations;

	[SerializeField]
	public CarModelInfo modelInfo;

	[SerializeField]
	private CarModelColliders colliders;

	[SerializeField]
	private bool indexAsGroup;

	[NonSerialized]
	private IEnumerator animation;

	public ExplodeAnimation explodeAnimation;

	private List<CarModelPart> availableCarModelParts_;

	private Dictionary<string, List<CarModelCustomization>> customizationsForTagMap;

	private bool isSubpartsReparented;

	private List<CarModelSubpart> subpartsHelperList_;

	private RoomsBackend.RoomAccessor roomBackend => null;

	public bool isIntroShown
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isPassed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public PartHinge GetHinge(string name)
	{
		return null;
	}

	public List<CarModelCustomization> CustomizationsForTag(string tag)
	{
		return null;
	}

	public void ApplyCustomizationToTag(MeshMaterialTag materialTag)
	{
	}

	public List<CarModelPart> AvailablePartsAsTasks()
	{
		return null;
	}

	private CarModelColliders GetOrCreateCarModelColliders()
	{
		return null;
	}

	public void InstantReturnToClosedPositionAllHinges()
	{
	}

	public void SetCollidersActive(bool active)
	{
	}

	public void InitializeParts()
	{
	}

	private CarModelPart InitPart(Transform child)
	{
		return null;
	}

	public void InitPhysics()
	{
	}

	public bool IsAllElementsPickedUpInGroup(int index)
	{
		return false;
	}

	public int SelectedIndexForVariantGroup(string groupName)
	{
		return 0;
	}

	public void RefreshVariations()
	{
	}

	private void ReparentSubpartsToHinges()
	{
	}

	public void ReturnToOriginalPosition()
	{
	}

	public void InitForRuntime()
	{
	}

	public void RefreshVisibilityBasedOnPartBeingOpen(CarModelPart part)
	{
	}

	public void RefreshVisibilityOnParts()
	{
	}

	public ProgressState GetProgressState()
	{
		return default(ProgressState);
	}

	public void InitExplodeAnimation()
	{
	}

	public List<CarModelSubpart> AllOwnedSubpartsInVariantGroup(CarModelInfo.VariantGroup group)
	{
		return null;
	}

	public void ShowChnage()
	{
	}

	private IEnumerator DoShowChange(float scaleMult)
	{
		return null;
	}

	private void Update()
	{
	}
}
