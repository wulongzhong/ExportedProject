using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class RoomsStats : MonoBehaviour
{
	private sealed class _003CDoCheckStats_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoomsStats _003C_003E4__this;

		private int _003CallRoomsStars_003E5__2;

		private RoomsDB _003CroomsDB_003E5__3;

		private List<RoomsDB.Room> _003Crooms_003E5__4;

		private int _003Ci_003E5__5;

		private RoomsDB.Room _003Croom_003E5__6;

		private RoomsDB.LoadRoomRequest _003CroomRequest_003E5__7;

		private IEnumerator _003CupdateEnum_003E5__8;

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
		public _003CDoCheckStats_003Ed__2(int _003C_003E1__state)
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

	private IEnumerator action;

	public void CheckStats()
	{
	}

	private IEnumerator DoCheckStats()
	{
		return null;
	}

	private int TotalStarsCount(RoomsDB.Room room)
	{
		return 0;
	}

	private void Update()
	{
	}
}
