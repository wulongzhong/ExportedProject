using System;
using UnityEngine;

public class RocketDemo : MonoBehaviour
{
	[Serializable]
	public class Circle
	{
		public Vector3 position;

		public float radius;
	}

	[Serializable]
	public class TangentDistanceFactors
	{
		public float tangentMultDistance;

		public float radiusTangentMultDistance;
	}

	public enum DrawMode
	{
		DrawModeCircles = 0,
		DrawModePath = 1
	}

	public struct Tangents
	{
		public float gamaRad;

		public float betaRad;

		public float alphaRad;

		public float tan1AngleRad;

		public float tan2AngleRad;

		public Circle c1;

		public Circle c2;

		public Vector3 c1Tan1;

		public Vector3 c2Tan1;

		public Vector3 c1Tan2;

		public Vector3 c2Tan2;
	}

	public Circle c1;

	public Circle c2;

	public float angleOffset;

	[SerializeField]
	public TangentDistanceFactors tangentFactors;

	public bool controlPoint2LookingToStart;

	public DrawMode drawMode;

	public static Tangents FindOuterTangents(Circle c1, Circle c2)
	{
		return default(Tangents);
	}
}
