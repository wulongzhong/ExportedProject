using System.Collections.Generic;
using UnityEngine;

public class Match3ParticleSystem : MonoBehaviour
{
	[SerializeField]
	private bool includeHidden;

	private List<ParticleSystem> particleSystems;

	private bool started;

	private bool initialized;

	public void StartParticleSystems()
	{
	}

	public List<ParticleSystem> GetAllParticleSystems()
	{
		return null;
	}

	private void Init()
	{
	}

	private void TryAddParticleSystemFromTransform(Transform t)
	{
	}

	private void Update()
	{
	}
}
