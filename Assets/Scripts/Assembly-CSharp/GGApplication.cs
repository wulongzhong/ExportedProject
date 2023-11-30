using System.Collections.Generic;
using UnityEngine;

public class GGApplication : ScriptableObjectSingleton<GGApplication>
{
	[SerializeField]
	public int currentVersion;

	[SerializeField]
	public string downloadMessage;

	[SerializeField]
	public List<string> locationsToAdd;

	public GGApplication()
	{
        //((ScriptableObjectSingleton<>)(object)this)._002Ector();
    }
}
