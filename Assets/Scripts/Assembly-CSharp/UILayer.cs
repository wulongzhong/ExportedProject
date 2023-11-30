using GGMatch3;
using UnityEngine;

public class UILayer : MonoBehaviour
{
	[SerializeField]
	private bool escToGoBack;

	[SerializeField]
	protected GGSoundSystem.SFXType backSound;

	public virtual void OnGoBack(NavigationManager nav)
	{
	}
}
