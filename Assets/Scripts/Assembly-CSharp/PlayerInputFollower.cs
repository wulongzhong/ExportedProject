using System.Collections.Generic;
using UnityEngine;

public class PlayerInputFollower : MonoBehaviour
{
	[SerializeField]
	private List<ParticleSystem> particles;

	[SerializeField]
	private List<TrailRenderer> trails;

	public void SetActive(bool active)
	{
	}

	public void Clear()
	{
	}
}
