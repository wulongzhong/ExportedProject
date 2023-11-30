public class SingletonInit<T> : InitClass where T : InitClass, new()
{
	private static T _instance;

	public static T Instance => null;

	public static T instance => null;
}
