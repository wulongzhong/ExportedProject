using TMPro;
using UnityEngine;

public class CurrencyDisplay : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI countLabel;

	[SerializeField]
	private Transform currencySymbol;

	[SerializeField]
	private CurrencyType currencyType;

	[SerializeField]
	private bool displayCarPartsCurrency;

	[SerializeField]
	private UIGGParticleCreator particleCreator;

	public CurrencyType displayedCurrency => default(CurrencyType);

	public void InitWithDisplayCurrency()
	{
	}

	public void Init(long count)
	{
	}

	public void DisplayCount(long count)
	{
	}

	public void ShowShineParticle()
	{
	}
}
