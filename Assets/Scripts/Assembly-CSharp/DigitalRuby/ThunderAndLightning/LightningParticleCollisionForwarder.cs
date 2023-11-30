using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningParticleCollisionForwarder : MonoBehaviour
	{
		public MonoBehaviour CollisionHandler;

		private ParticleSystem _particleSystem;

		private readonly List<ParticleCollisionEvent> collisionEvents;

		private void Start()
		{
		}

		private void OnParticleCollision(GameObject other)
		{
		}
	}
}
