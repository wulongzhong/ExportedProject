using UnityEngine;

public class SmoothCameraOrbit : MonoBehaviour
{
	public Transform target;

	public Vector3 targetOffset;

	public float distance;

	public float maxDistance;

	public float minDistance;

	public float xSpeed;

	public float ySpeed;

	public int yMinLimit;

	public int yMaxLimit;

	public int zoomRate;

	public float panSpeed;

	public float zoomDampening;

	public float autoRotate;

	private float xDeg;

	private float yDeg;

	private float currentDistance;

	private float desiredDistance;

	private Quaternion currentRotation;

	private Quaternion desiredRotation;

	private Quaternion rotation;

	private Vector3 position;

	private float idleTimer;

	private float idleSmooth;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	public void Init()
	{
	}

	private void LateUpdate()
	{
	}

	private static float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}
}
