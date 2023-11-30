using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class DemoScript : MonoBehaviour
	{
		private enum RotationAxes
		{
			MouseXAndY = 0,
			MouseX = 1,
			MouseY = 2
		}

		public ThunderAndLightningScript ThunderAndLightningScript;

		public LightningBoltScript LightningBoltScript;

		public ParticleSystem CloudParticleSystem;

		public float MoveSpeed;

		public bool EnableMouseLook;

		private const float fastCloudSpeed = 50f;

		private float deltaTime;

		private float fpsIncrement;

		private string fpsText;

		private RotationAxes axes;

		private float sensitivityX;

		private float sensitivityY;

		private float minimumX;

		private float maximumX;

		private float minimumY;

		private float maximumY;

		private float rotationX;

		private float rotationY;

		private Quaternion originalRotation;

		private static readonly GUIStyle style;

		private void UpdateThunder()
		{
		}

		private void UpdateMovement()
		{
		}

		private void UpdateMouseLook()
		{
		}

		private void UpdateQuality()
		{
		}

		private void UpdateOther()
		{
		}

		private void OnGUI()
		{
		}

		private void Update()
		{
		}

		private void Start()
		{
		}

		public static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		public static void ReloadCurrentScene()
		{
		}
	}
}
