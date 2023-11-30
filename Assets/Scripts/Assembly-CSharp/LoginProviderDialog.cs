using System;
using UnityEngine;

public class LoginProviderDialog : MonoBehaviour
{
	public struct LoginResponse
	{
		public bool isCancelled;

		public LoginProvider loginProvider;
	}

	private Action<LoginResponse> onComplete;

	public void Show(Action<LoginResponse> onComplete)
	{
	}

	public void ButtonCallback_OnCancel()
	{
	}

	public void ButtonCallback_OnAppleLogin()
	{
	}

	public void ButtonCallback_OnFacebookLogin()
	{
	}

	private void Complete(LoginProvider provider)
	{
	}
}
