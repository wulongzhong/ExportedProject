public class GGSupportMenu
{
	private static GGSupportMenu _instance;

	public static GGSupportMenu instance => null;

	public virtual void showRateApp(string rateProvider)
	{
	}

	public virtual bool isNetworkConnected()
	{
		return false;
	}
}
