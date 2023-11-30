using System.Collections.Generic;
using ProtoModels;

public class RoomsBackend : SingletonInit<RoomsBackend>
{
	public class RoomAccessor
	{
		public bool needsToBeRenewed;

		public RoomsBackend roomsBackend;

		public RoomDecoration.Room room;

		private List<VisualObjectAccessor> visualObjectAccessors;

		private List<VariantGroupAccessor> variantGroupAccessors;

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

		private List<RoomDecoration.VisualObject> visualObjects => null;

		private List<RoomDecoration.VariantGroup> variantGroups => null;

		public void SetNeedsToBeRenewed()
		{
		}

		public RoomAccessor CreateRenewedAccessor()
		{
			return null;
		}

		public RoomAccessor(RoomDecoration.Room room, RoomsBackend roomsBackend)
		{
		}

		public VisualObjectAccessor GetVisualObject(string visualObjectName)
		{
			return null;
		}

		public VariantGroupAccessor GetVariantGroup(string variantGroupName)
		{
			return null;
		}

		private RoomDecoration.VisualObject GetOrCreateVisualObjectModel(string visualObjectName)
		{
			return null;
		}

		private RoomDecoration.VisualObject GetVisualObjectModel(string visualObjectName)
		{
			return null;
		}

		private RoomDecoration.VariantGroup GetVariantGroupModel(string variantGroupName)
		{
			return null;
		}

		private RoomDecoration.VariantGroup GetOrCreateVariantGroupModel(string variantGroupName)
		{
			return null;
		}

		public bool IsOwned(string visualObjectName)
		{
			return false;
		}

		public void Save()
		{
		}
	}

	public class VariantGroupAccessor
	{
		public bool needsToBeRenewed;

		public RoomDecoration.VariantGroup variantGroup;

		public RoomAccessor roomAccessor;

		public RoomDecoration.VariantGroup.Property GetProperty(string name)
		{
			return null;
		}

		public RoomDecoration.VariantGroup.Property GetOrCreateProperty(string name)
		{
			return null;
		}

		public VariantGroupAccessor(RoomDecoration.VariantGroup variantGroup, RoomAccessor roomAccessor)
		{
		}

		public void Save()
		{
		}
	}

	public class VisualObjectAccessor
	{
		public bool needsToBeRenewed;

		public RoomDecoration.VisualObject visualObject;

		public RoomAccessor roomAccessor;

		public VisualObjectAccessor(RoomDecoration.VisualObject visualObject, RoomAccessor roomAccessor)
		{
		}

		public void Save()
		{
		}
	}

	public string filename;

	private RoomDecoration model_;

	private List<RoomAccessor> roomAccessors;

	public RoomDecoration model => null;

	public int selectedRoomIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public List<RoomDecoration.Room> rooms => null;

	public RoomAccessor GetRoom(string roomName)
	{
		return null;
	}

	private RoomDecoration.Room GetOrCreateRoomModel(string roomName)
	{
		return null;
	}

	public void Save()
	{
	}

	private RoomDecoration.Room GetRoomModel(string roomName)
	{
		return null;
	}

	private void RenewRoomAccessors()
	{
	}

	public void Reset()
	{
	}

	public void ReloadModel()
	{
	}

	public override void Init()
	{
	}

	public RoomsBackend()
	{
        //((SingletonInit<>)(object)this)._002Ector();
    }
}
