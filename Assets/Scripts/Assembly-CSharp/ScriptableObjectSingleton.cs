using UnityEngine;

public class ScriptableObjectSingleton<T> : ScriptableObject where T : ScriptableObject
{
	private static bool applicationIsQuitting;

	protected static bool didTryToLoadSingleton_;

	protected static T instance_;

	public static T instance => null;

	public void OnDestroy()
	{
	}

	protected virtual void UpdateData()
	{
	}
}
