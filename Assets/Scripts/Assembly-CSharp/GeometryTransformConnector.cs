using UnityEngine;

public class GeometryTransformConnector : MonoBehaviour
{
	[SerializeField]
	public string path;

	[SerializeField]
	public bool copyPosition;

	[SerializeField]
	public bool copyRotation;

	[SerializeField]
	public bool copyScale;

	public GeometryConnectorSettings FindSettings()
	{
		return null;
	}
}
