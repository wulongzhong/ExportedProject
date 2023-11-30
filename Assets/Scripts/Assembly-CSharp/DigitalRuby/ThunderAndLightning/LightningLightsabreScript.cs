using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningLightsabreScript : LightningBoltPrefabScript
	{
		public float BladeHeight;

		public float ActivationTime;

		public AudioSource StartSound;

		public AudioSource StopSound;

		public AudioSource ConstantSound;

		private int state;

		private Vector3 bladeStart;

		private Vector3 bladeDir;

		private float bladeTime;

		private float bladeIntensity;

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		public bool TurnOn(bool value)
		{
			return false;
		}

		public void TurnOnGUI(bool value)
		{
		}
	}
}
