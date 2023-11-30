using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CarsDBSettings : ScriptableObjectSingleton<CarsDBSettings>
{
	[SerializeField]
	public CarCamera.BlendSettings blendSettings;

	[SerializeField]
	public ExplodeSlider.ExplosionSettings explosionSettings;

	[SerializeField]
	private List<CarSettings> carSettings;

	public CarModelSubpart.Settings subpartInSettings;

	public CarModelSubpart.BlinkSettings subpartBlinkSettings;

	public CarSettings GetCarSettings(string carName)
	{
		return null;
	}

	public CarCamera.Settings GetCarCamera(string carName, string cameraName)
	{
		return null;
	}

	public void CopySettingsFromCarsDB(CarsDB carsDB)
	{
	}

	public CarsDBSettings()
	{
		//((ScriptableObjectSingleton<>)(object)this)._002Ector();
	}
}
