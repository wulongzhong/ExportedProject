using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CarSettings
{
	[SerializeField]
	public string carName;

	[SerializeField]
	private List<CarCamera.Settings> carCameraSettings;

	public CarCamera.Settings GetSettings(string name)
	{
		return null;
	}
}
