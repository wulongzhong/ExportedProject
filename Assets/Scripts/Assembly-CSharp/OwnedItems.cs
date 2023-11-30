using ProtoModels;

public class OwnedItems
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public string name;

		internal bool _003CisOwned_003Eb__0(OwnedItemDAO o)
		{
			return false;
		}
	}

	public static string DefaultOwnedItemsFilename;

	public OwnedItemsDAO ownedItems;

	private string _003COwnedItemsFilename_003Ek__BackingField;

	public string OwnedItemsFilename
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public OwnedItems(string filename)
	{
	}

	public void ReloadModel()
	{
	}

	public void AddToOwned(string name, bool canStockpile)
	{
	}

	public OwnedItemDAO GetOrCreateItemWithName(string name)
	{
		return null;
	}

	public UsedItemDAO GetOrCreateUsedItemWithName(string name)
	{
		return null;
	}

	public bool isOwned(string name)
	{
		return false;
	}

	public OwnedItemDAO GetItemWithName(string name)
	{
		return null;
	}

	public void Save()
	{
	}
}
