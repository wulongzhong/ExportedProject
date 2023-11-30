using System;
using System.Collections.Generic;
using UnityEngine;

public class CarSkeletonDefinition : MonoBehaviour
{
	public enum Position
	{
		Wheel_Front_Left = 0,
		Wheel_Front_Right = 1,
		Wheel_Rear_Left = 2,
		Wheel_Rear_Right = 3,
		Wheel_Rear1_Left = 4,
		Wheel_Rear1_Right = 5
	}

	[Serializable]
	public class SkeletonPoint
	{
		[SerializeField]
		public Position position;

		[SerializeField]
		public Transform transform;
	}

	[SerializeField]
	private List<SkeletonPoint> skeletonPoints;

	public SkeletonPoint GetPoint(Position position)
	{
		return null;
	}
}
