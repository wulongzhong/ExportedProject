using System;
using System.Collections.Generic;
using JSONData;
using UnityEngine;

public class DecoratingScene3DSetup : MonoBehaviour
{
	[Serializable]
	public class PivotConfig
	{
		[Serializable]
		public class Pivot
		{
			public string name;

			public Vector3 screenPosition;
		}

		public List<Pivot> pivots;
	}

	[Serializable]
	public class DashboxConfig
	{
		public List<ShapeGraphShape> shapes;
	}

	[Serializable]
	public class NamedCollisionConfig
	{
		public string name;

		public CollisionConfig collisionConfig;
	}

	[Serializable]
	public class CollisionConfig
	{
		[Serializable]
		public class Triangle
		{
			public float distanceFromCamera;

			public Vector3 p1;

			public Vector3 p2;

			public Vector3 p3;
		}

		public List<Triangle> triangles;
	}

	[Serializable]
	public class VisualObject
	{
		public string name;

		public Transform rootTransform;

		public Transform collisionRoot;

		public Transform dashboxRoot;

		public CollisionConfig collisionConfig;

		public DashboxConfig dashboxConfig;

		public PivotConfig pivotConfig;

		public List<NamedCollisionConfig> namedCollisionConfigs;
	}

	public int selectedObject;

	[SerializeField]
	public List<VisualObject> visualObjectList;

	public VisualObject GetForName(string name)
	{
		return null;
	}

	public void Init()
	{
	}

	private void FillVisualObject(VisualObject visualObject, Transform rootTransform)
	{
	}

	private void FillPivotConfig(PivotConfig pivotConfig, Transform root)
	{
	}

	private void FillDashboxConfig(DashboxConfig dashboxConfig, Transform root)
	{
	}

	private void FillMesh(DashboxConfig dashboxConfig, Transform transform, Mesh mesh)
	{
	}

	private void FillCollisionConfig(VisualObject visualObject, CollisionConfig collisionConfig, Transform root, NamedCollisionConfig namedCollision)
	{
	}

	public Camera FindMainCamera()
	{
		return null;
	}

	private void FillMesh(VisualObject visualObject, CollisionConfig collisionConfig, Transform transform, Mesh mesh)
	{
	}
}
