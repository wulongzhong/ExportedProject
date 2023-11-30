using System;
using System.Collections.Generic;
using UnityEngine;

public class BlasterParticleCollision : MonoBehaviour
{
	[NonSerialized]
	public List<ParticleCollisionEvent> collisionEvents;

	public bool HasCollisionEvents => false;

	public void ClearCollisionEvents()
	{
	}

	private void OnParticleCollision(GameObject other)
	{
	}
}
