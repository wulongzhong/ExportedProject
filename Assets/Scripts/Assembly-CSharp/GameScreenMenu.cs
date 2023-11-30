using UnityEngine;

public class GameScreenMenu : MonoBehaviour
{
	public enum State
	{
		Open = 0,
		Closed = 1
	}

	[SerializeField]
	private CurrencyPrefabAnimation backgroundInAnimation;

	[SerializeField]
	private CurrencyPrefabAnimation backgroundOutAnimation;

	[SerializeField]
	private CurrencyPrefabAnimation exitButtonInAnimation;

	[SerializeField]
	private CurrencyPrefabAnimation exitButtonOutAnimation;

	[SerializeField]
	private RectTransform backgroundButton;

	private State state;

	public void Show()
	{
	}

	public void OnEnable()
	{
	}

	public void Hide()
	{
	}

	public void ButtonCallback_OnMenuButtonClicked()
	{
	}
}
