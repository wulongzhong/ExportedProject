using System;

public class IAppleSignInProvider
{
	[Serializable]
	public class SignInResponse
	{
		public bool cancelled;

		public string error;

		public string user_id;

		public bool isError => false;
	}

	public virtual bool isAvailable => false;

	public virtual void SignIn(Action<SignInResponse> onComplete)
	{
	}
}
