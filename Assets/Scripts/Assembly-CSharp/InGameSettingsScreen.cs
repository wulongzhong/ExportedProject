using UnityEngine;
using UnityEngine.UI;

public class InGameSettingsScreen : MonoBehaviour
{
	[SerializeField]
	private Image testerImage;

	[SerializeField]
	private int tries;

	[SerializeField]
	private float waitSeconds;

	private float lastClickTime;

	private int clicks;

	private void OnEnable()
	{
	}

	private void Init()
	{
	}

	public void ButtonCallback_OnExit()
	{
	}

	public void ButtonCallback_OnRate()
	{
	}

	public void ButtonCallback_OnTesterClick()
	{
	}

	public void ButtonCallback_OnTermsOfService()
	{
	}

	public void ButtonCallback_PrivacyPolicy()
	{
	}
}
