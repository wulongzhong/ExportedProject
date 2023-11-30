using UnityEngine;

public class BehaviourSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T _instance;

	private static object _lock;

	private static bool applicationIsQuitting;

	public static T instance => null;

	public static T Instance => null;

	public void OnDestroy()
	{
	}
}
