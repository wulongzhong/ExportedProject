using UnityEngine;

namespace GGMatch3
{
	public class JumpRampBehaviour : MonoBehaviour
	{
		[SerializeField]
		private Transform rotator;

		[SerializeField]
		private MeshRenderer spriteMesh;

		private float spriteOffset;

		public void Init(Vector3 position, IntVector2 direction)
		{
		}

		private void Update()
		{
		}
	}
}
