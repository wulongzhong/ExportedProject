public class BehaviourSingletonInit<T> : MonoBehaviourInit where T : MonoBehaviourInit
{
	private static T _instance;

	private static object _lock;

	private static bool applicationIsQuitting_;

	public static T instance => null;

	public static T Instance => null;

	private static bool applicationIsQuitting
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void OnDestroy()
	{
	}
}
