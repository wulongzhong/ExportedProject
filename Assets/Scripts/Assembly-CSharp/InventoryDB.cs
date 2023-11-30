using ProtoModels;
using UnityEngine;

public class InventoryDB : ScriptableObject
{
	[SerializeField]
	public string filename;

	private DecoratingRooms _model;

	private static InventoryDB _instance;

	public DecoratingRooms model => null;

	public static InventoryDB instance => null;

	public void ResetAll()
	{
	}

	public void ReloadModel()
	{
	}

	public void SaveModel()
	{
	}
}
