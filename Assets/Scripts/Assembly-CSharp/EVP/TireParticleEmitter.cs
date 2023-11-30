using UnityEngine;

namespace EVP
{
	public class TireParticleEmitter : MonoBehaviour
	{
		public enum Mode
		{
			PressureAndSkid = 0,
			PressureAndVelocity = 1
		}

		public Mode mode;

		public float emissionRate;

		public float emissionShuffle;

		public float maxLifetime;

		public float minVelocity;

		public float maxVelocity;

		public float tireVelocityRatio;

		public Color Color1;

		public Color Color2;

		public bool randomColor;

		private ParticleSystem m_particles;

		private ParticleSystem.EmitParams m_emitParams;

		private void OnEnable()
		{
		}

		public float EmitParticle(Vector3 position, Vector3 wheelVelocity, Vector3 tireVelocity, float pressureRatio, float intensityRatio, float lastParticleTime)
		{
			return 0f;
		}
	}
}
