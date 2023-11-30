using UnityEngine;

public class LifetimeParticleAttractor : MonoBehaviour
{
	private ParticleSystem ps;

	private ParticleSystem.Particle[] m_Particles;

	public Transform target;

	public float speed;

	public float velocitySpeed;

	public float minLifetimeWhenStartActing;

	public bool useRemainingTime;

	public bool useCurveForSpeed;

	public AnimationCurve curveForSpeed;

	public bool useCurveForPosition;

	public AnimationCurve curveForPosition;

	private void InitializeIfNeeded()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
