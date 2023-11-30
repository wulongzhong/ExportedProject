public class Singleton<T> where T : class, new()
{
	private static T _instance;

	public static T instance => null;

	public static T Instance => null;
}
