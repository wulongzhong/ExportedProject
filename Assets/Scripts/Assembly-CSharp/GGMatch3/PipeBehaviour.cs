using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	public class PipeBehaviour : MonoBehaviour
	{
		[SerializeField]
		private Transform rotator;

		[SerializeField]
		private Transform scaler;

		[SerializeField]
		private List<SpriteRenderer> coloredSprites;

		[SerializeField]
		private Transform offsetPositionTransform;

		[SerializeField]
		public Transform exitTransform;

		[SerializeField]
		private List<Transform> visibleWhenEntrance;

		[SerializeField]
		private List<Transform> visibleWhenExit;

		public void SetScale(float scale)
		{
		}

		public void SetOffsetPosition(Vector3 offsetPosition)
		{
		}

		public void SetColor(Color color)
		{
		}

		public void Init(Vector3 center, Vector3 direction, bool isExit)
		{
		}

		public void Init(Slot slot, bool isExit)
		{
		}
	}
}
