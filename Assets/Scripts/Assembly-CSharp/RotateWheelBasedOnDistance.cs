using UnityEngine;

public class RotateWheelBasedOnDistance : MonoBehaviour
{
	[SerializeField]
	private Transform transformThatMoves;

	[SerializeField]
	private Vector3 originalTransformThatMovesPosition;

	[SerializeField]
	private Vector3 distanceAxis;

	[SerializeField]
	private float wheelRadius;

	[SerializeField]
	private Vector3 originalRotation;

	[SerializeField]
	private Vector3 rotationAxis;

	private void UpdatePosition()
	{
	}

	public void Update()
	{
	}
}
