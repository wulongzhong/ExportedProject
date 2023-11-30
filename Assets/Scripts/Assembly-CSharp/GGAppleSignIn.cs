using System;

public class GGAppleSignIn : BehaviourSingletonInit<GGAppleSignIn>
{
	private IAppleSignInProvider signInProvider;

	public bool isAvailable => false;

	public override void Init()
	{
	}

	public void SignIn(Action<IAppleSignInProvider.SignInResponse> onComplete)
	{
	}

	public GGAppleSignIn()
	{
		//((BehaviourSingletonInit<>)(object)this)._002Ector();
	}
}
