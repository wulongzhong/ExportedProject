using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomsDB : ScriptableObjectSingleton<RoomsDB>
{
	[Serializable]
	public class Room
	{
		public string name;

		public string sceneName;

		public string displayName;

		public string description;

		public bool getFromAssetBundleOnEditor;

		public string assetBundleURLOSX;

		public string assetBundleURLAndroid;

		public string assetBundleURLIOS;

		public Sprite cardSprite;

		public GiftBoxScreen.GiftsDefinition giftDefinition;

		public bool isOnlyForEditor;

		public bool remove;

		public int totalStarsInRoom;

		private RoomsDB rooms;

		public string editorAssetPath;

		[NonSerialized]
		public DecoratingScene sceneBehaviour;

		[NonSerialized]
		public bool isSceneLoaded;

		[NonSerialized]
		public string loadedSceneName;

		[NonSerialized]
		public AssetBundle loadedAssetBundle;

		public string assetBundleURL => null;

		public bool isPassed => false;

		public bool isLocked => false;

		public bool isOpen => false;

		private RoomsBackend.RoomAccessor roomAccessor => null;

		public void Init(RoomsDB rooms)
		{
		}
	}

	public class LoadRoomRequest
	{
		public Room room;

		public float progress;

		public bool isDone;

		public bool isError;

		public LoadRoomRequest(Room room)
		{
		}
	}

	private sealed class _003CLoadRoom_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadRoomRequest roomRequest;

		public RoomsDB _003C_003E4__this;

		private Room _003Croom_003E5__2;

		private Scene _003Cscene_003E5__3;

		private bool _003CroomLoaded_003E5__4;

		private List<Room> _003Crooms_003E5__5;

		private int _003Ci_003E5__6;

		private Room _003Citem_003E5__7;

		private AsyncOperation _003CasyncWait_003E5__8;

		private string _003CsceneName_003E5__9;

		private WWW _003Cwww_003E5__10;

		private AssetBundle _003CassetBundle_003E5__11;

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
		public _003CLoadRoom_003Ed__11(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
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
	private List<Room> roomsList;

	[NonSerialized]
	private List<Room> rooms_;

	public List<Room> rooms => null;

	public Room ActiveRoom => null;

	public Room NextRoom(Room room)
	{
		return null;
	}

	public int IndexOf(Room room)
	{
		return 0;
	}

	protected override void UpdateData()
	{
	}

	public IEnumerator LoadRoom(LoadRoomRequest roomRequest)
	{
		return null;
	}

	public RoomsDB()
	{
		//((ScriptableObjectSingleton<>)(object)this)._002Ector();
	}
}
