using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class ScrollableSelectCarScreen : MonoBehaviour
{
	public class ChangeCarArguments
	{
		public CarsDB.Car passedCar;

		public CarsDB.Car unlockedCar;
	}

	private sealed class _003CDoChangeRoomsAnimation_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ScrollableSelectCarScreen _003C_003E4__this;

		public ChangeCarArguments changeRoom;

		private ScrollableSelectCarScreenButton _003CpassedRoom_003E5__2;

		private ScrollableSelectCarScreenButton _003CunlockedRoom_003E5__3;

		private float _003Cdelay_003E5__4;

		private float _003Ctime_003E5__5;

		private IEnumerator _003Cenumerator_003E5__6;

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
		public _003CDoChangeRoomsAnimation_003Ed__14(int _003C_003E1__state)
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

	private sealed class _003CMoveCenterContainerToCenterChild_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RectTransform item;

		public float duration;

		private RectTransform _003Ccontainer_003E5__2;

		private Vector3 _003CstartPosition_003E5__3;

		private Vector3 _003CendPosition_003E5__4;

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
		public _003CMoveCenterContainerToCenterChild_003Ed__17(int _003C_003E1__state)
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
	private ScrollRect scrollRect;

	[SerializeField]
	private List<Transform> widgetsToHide;

	[SerializeField]
	private RectTransform mainTransform;

	[SerializeField]
	private Transform stopInteractionWidget;

	[SerializeField]
	private ComponentPool roomsPool;

	[SerializeField]
	private float spacing;

	[NonSerialized]
	private MainConfig config;

	[NonSerialized]
	private List<ScrollableSelectCarScreenButton> btns;

	private ChangeCarArguments changeCarArguments;

	private IEnumerator animationEnumerator;

	public void Show(MainConfig config)
	{
	}

	public void Show(ChangeCarArguments changeCarArguments, MainConfig config)
	{
	}

	private void Init(ChangeCarArguments changeRoomArguments)
	{
	}

	private IEnumerator DoChangeRoomsAnimation(ChangeCarArguments changeRoom)
	{
		return null;
	}

	private ScrollableSelectCarScreenButton GetButton(CarsDB.Car car)
	{
		return null;
	}

	private void CenterContainerToCenterChild(RectTransform item)
	{
	}

	private IEnumerator MoveCenterContainerToCenterChild(RectTransform item, float duration)
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}
}
