using UnityEngine;

public class CopyPositionFromSkeleton : MonoBehaviour
{
	[SerializeField]
	private CarSkeletonDefinition.Position position;

	[SerializeField]
	public bool copyRotation;

	[SerializeField]
	private Vector3 localOffset;

	private void Reset()
	{
	}

	public void CopyPosition()
	{
	}
}
