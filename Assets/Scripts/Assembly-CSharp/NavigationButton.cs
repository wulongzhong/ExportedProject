using UnityEngine;

public class NavigationButton : MonoBehaviour
{
	public enum ActionType
	{
		Push = 0,
		PushModal = 1,
		Pop = 2
	}

	[SerializeField]
	private ActionType action;

	[SerializeField]
	private string screenName;

	[SerializeField]
	private GGSoundSystem.SFXType pressSound;

	public void OnClick()
	{
	}
}
