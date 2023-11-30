using UnityEngine;

public class WorldButtonHandle : MonoBehaviour
{
	[SerializeField]
	public Sprite sprite;

	[SerializeField]
	public float additionalAngleTolerance;

	[SerializeField]
	public bool alwaysShow;

	[SerializeField]
	public bool scaleWithDistance;

	[SerializeField]
	public float scale;

	[SerializeField]
	public float minDistanceToStartScaling;

	[SerializeField]
	public bool setPositionToPartHandle;
}
