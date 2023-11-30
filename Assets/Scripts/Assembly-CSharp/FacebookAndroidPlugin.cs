using UnityEngine;

public class FacebookAndroidPlugin : IFacebookProvider
{
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public FBLoginParams loginParams;

		internal void _003CLogin_003Eb__0(PluginCallbackManager.Response response)
		{
		}
	}

	private AndroidJavaObject javaInstance;

	public override void Login(FBLoginParams loginParams)
	{
	}

	public override bool IsInitialized()
	{
		return false;
	}
}
