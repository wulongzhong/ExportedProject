using System;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningParticleSpellScript : LightningSpellScript, ICollisionHandler
	{
		public ParticleSystem ParticleSystem;

		public float CollisionInterval;

		protected float collisionTimer;

		public Action<GameObject, List<ParticleCollisionEvent>, int> CollisionCallback;

		public bool EnableParticleLights;

		public RangeOfFloats ParticleLightRange;

		public RangeOfFloats ParticleLightIntensity;

		public Color ParticleLightColor1;

		public Color ParticleLightColor2;

		public LayerMask ParticleLightCullingMask;

		private ParticleSystem.Particle[] particles;

		private readonly List<GameObject> particleLights;

		private void PopulateParticleLight(Light src)
		{
		}

		private void UpdateParticleLights()
		{
		}

		private void UpdateParticleSystems()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		protected override void OnCastSpell()
		{
		}

		protected override void OnStopSpell()
		{
		}

		private void DigitalRuby_002EThunderAndLightning_002EICollisionHandler_002EHandleCollision(GameObject obj, List<ParticleCollisionEvent> collisions, int collisionCount)
		{
		}

        void ICollisionHandler.HandleCollision(GameObject obj, List<ParticleCollisionEvent> collision, int collisionCount)
        {
            throw new NotImplementedException();
        }
    }
}
