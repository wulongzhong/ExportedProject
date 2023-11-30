using System.Collections.Generic;
using UnityEngine;

public class CameraSetups : MonoBehaviour
{
	[SerializeField]
	public List<CarCamera.Settings> cameraSettings;

	[SerializeField]
	private string roomName;

	public void HideAllCameras()
	{
	}

	public CarCamera.Settings GetCarCamera(string cameraName)
	{
		return null;
	}

	public void LoadFromTransforms()
	{
	}
}
