using System.Collections;
using UnityEngine;

public class CurrencyPurchaseDialogNextButton : MonoBehaviour
{
	[SerializeField]
	private CurrencyPrefabAnimation animationIn;

	[SerializeField]
	private CurrencyPrefabAnimation animationOut;

	public void Init()
	{
	}

	public void AnimateIn(float delay = 0f)
	{
	}

	public void AnimateOut(float delay = 0f)
	{
	}

	public IEnumerator DoAnimateOut(float delay)
	{
		return null;
	}

	public IEnumerator DoAnimateIn(float delay)
	{
		return null;
	}
}
