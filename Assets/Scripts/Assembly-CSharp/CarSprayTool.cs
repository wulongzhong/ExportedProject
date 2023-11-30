using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CarSprayTool : MonoBehaviour
{
	public struct FillPercentageUpdateState
	{
		public float timeWaitingForUpdate;

		public bool needsUpdate;
	}

	public struct CurrentState
	{
		public bool isLastPointSet;

		public Vector3 lastPointPosition;

		public float lastTimeCheckedPercentage;

		public bool needsToCheckPercentage;
	}

	public struct InitArguments
	{
		public AssembleCarScreen screen;

		public PaintTransformation paintTransformation;

		public Action onDone;

		public GGSoundSystem.LoopSFXType sountType;
	}

	private sealed class _003CEndOfFrameUpdate_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarSprayTool _003C_003E4__this;

		private float _003CprevFillPercentage_003E5__2;

		private float _003CnextFillPercentage_003E5__3;

		private float _003Ctime_003E5__4;

		private float _003Cduration_003E5__5;

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
		public _003CEndOfFrameUpdate_003Ed__42(int _003C_003E1__state)
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
	private Image fillImage;

	[SerializeField]
	private TextMeshProUGUI fillText;

	[SerializeField]
	private CarSprayToolTarget sprayTool;

	[SerializeField]
	private GameObject sandBlasterPrefab;

	[SerializeField]
	private float viewportBoundsX;

	[SerializeField]
	private float viewportBoundsY;

	[SerializeField]
	private Vector3 viewportSpeed;

	[SerializeField]
	private Transform targetTransform;

	private float fillTreshold;

	private float spraySize;

	private float minTimeBeforeCanUpdateFillPercentage;

	private Vector3 lastHitPoint;

	private bool offsetToolWhenPressed;

	private bool offsetStreamWhenPressed;

	private bool useParticleWhenPossible;

	private bool isUsingParticles;

	private FillPercentageUpdateState fillUpdateState;

	private CurrentState currentState;

	private DrillModel sandBlasterModel_;

	private InitArguments initArguments;

	private float currentFillPercentage;

	private GGSoundSystem.LoopSoundFxClip sound;

	private float sprayCameraDastince => 0f;

	private AssembleCarScreen screen => null;

	public PaintTransformation paintTransformation => null;

	private bool IsUsingParticles(DrillModel model)
	{
		return false;
	}

	public DrillModel GetSandBlasterModel(CarScene carScene)
	{
		return null;
	}

	public void Init(InitArguments initArguments)
	{
	}

	public void Hide()
	{
	}

	private void UpdateFill(float percentage)
	{
	}

	private Vector3 StreamOffset(Vector3 screenPosition)
	{
		return default(Vector3);
	}

	private void OnDrag(Vector3 screenPosition)
	{
	}

	private void UpdateSandBlasterHitPoint(Vector3 hitPoint, Ray ray)
	{
	}

	private void UpdateSandBlasterPosition(Vector3 screenPosition)
	{
	}

	private void UpdateSandBlasterPosition2(Vector3 screenPosition, Vector3 hitPoint)
	{
	}

	private void Update()
	{
	}

	private IEnumerator EndOfFrameUpdate()
	{
		return null;
	}

	private void HandleCamera(Vector3 screenPosition)
	{
	}

	private void HandleHitPoint(Vector3 hitPointWorldPosition)
	{
	}

	public void ButtonCallback_OnFinish()
	{
	}
}
