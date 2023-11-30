using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CarNut : MonoBehaviour
{
	[Serializable]
	public class MaterialChange
	{
		[SerializeField]
		public MeshRenderer renderer;

		[SerializeField]
		public Material outline;

		[SerializeField]
		public Material normal;

		public void SetMaterial(bool isOutline)
		{
		}
	}

	private sealed class _003CDoRotateIn_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarNut _003C_003E4__this;

		public Vector3 fromPosition;

		public Vector3 toPosition;

		public float duration;

		private float _003Ctime_003E5__2;

		private float _003Crotations_003E5__3;

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
		public _003CDoRotateIn_003Ed__18(int _003C_003E1__state)
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
	private Transform screwInTransform;

	[SerializeField]
	private Transform tailTransfrom;

	[SerializeField]
	private Transform headTransfrom;

	[SerializeField]
	private float rotationsTillLength;

	[NonSerialized]
	private bool initialScaleSet;

	[NonSerialized]
	private Vector3 initialScale;

	[SerializeField]
	private List<MaterialChange> materialChanges;

	public Rigidbody rigidbody => null;

	public float nutSize => 0f;

	public void Init()
	{
	}

	private void SetMaterial(bool isOutline)
	{
	}

	public void SetScale(float scale)
	{
	}

	public void Drop()
	{
	}

	public void SetRotation(Quaternion rotation)
	{
	}

	public void SetRotateIn(Vector3 fromPosition, Vector3 toPosition, float n)
	{
	}

	public IEnumerator DoRotateIn(Vector3 fromPosition, Vector3 toPosition, float duration)
	{
		return null;
	}
}
