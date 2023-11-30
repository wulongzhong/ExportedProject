using UnityEngine;

public class HammerAnimationBehaviour : MonoBehaviour
{
	[SerializeField]
	private Animation animationPlayer;

	[SerializeField]
	private string animationName;

	[SerializeField]
	private int frameOfHit;

	[SerializeField]
	private Transform hammerIcon;

	[SerializeField]
	private Transform powerHammerIcon;

	public float animationTime => 0f;

	public float animationNormalizedTime => 0f;

	public float timeWhenHammerHit => 0f;

	public void Init(PowerupType powerupType)
	{
	}

	public void RemoveFromGame()
	{
	}
}
