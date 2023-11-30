using UnityEngine;

[ExecuteInEditMode]
public class CameraSettings : MonoBehaviour
{
	[SerializeField]
	private Camera camera;

	[SerializeField]
	private Transform lookAtTransform;

	[SerializeField]
	private bool changeAnglesAtStart;

	[SerializeField]
	private bool useHorizontalAngleRange;

	[SerializeField]
	private GGMath.FloatRange horizontalAngleRange;

	public CarCamera.Settings LoadSettings()
	{
		return null;
	}

	private void Update()
	{
	}
}
