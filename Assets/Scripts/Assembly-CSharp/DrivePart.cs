using System;
using System.Collections.Generic;
using UnityEngine;

public class DrivePart : MonoBehaviour
{
	[SerializeField]
	private DrivePartType drivePartType;

	[NonSerialized]
	public List<CarModelSubpart> parentedSubparts;

	[SerializeField]
	private Transform transformToMove_;

	private Transform transformToMove => null;

	public void MakeMovableUnderHinge(CarModelSubpart subpart)
	{
	}
}
