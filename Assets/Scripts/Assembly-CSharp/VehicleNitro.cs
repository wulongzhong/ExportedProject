using UnityEngine;

public class VehicleNitro : MonoBehaviour
{
	public enum Mode
	{
		Acceleration = 0,
		Impulse = 1
	}

	public Mode mode;

	public float value;

	public float maxVelocity;

	public KeyCode key;

	private Rigidbody m_rigidbody;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}
}
