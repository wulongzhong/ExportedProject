using UnityEngine;

public class GGSupportMenuAndroid : GGSupportMenu
{
	private AndroidJavaObject javaInstance;

	public override void showRateApp(string rateProvider)
	{
	}

	public override bool isNetworkConnected()
	{
		return false;
	}
}
