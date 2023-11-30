using System;
using System.Collections.Generic;
using UnityEngine;

public class DrillModel : MonoBehaviour
{
	[Serializable]
	public class MaterialColorChange
	{
		public Material material;

		public string propertyName;

		public void SetColor(Color color)
		{
		}
	}

	[Serializable]
	public class Variant
	{
		public string variantName;

		public Transform variantTransform;
	}

	[SerializeField]
	private Transform turnerTransform;

	[SerializeField]
	private List<Transform> activeParts;

	[SerializeField]
	private Transform localOffset;

	[SerializeField]
	private List<BlasterParticleCollision> blasterParticleCollisions;

	[SerializeField]
	private List<MaterialColorChange> colorChanges;

	[SerializeField]
	private List<Variant> variants;

	private List<ParticleCollisionEvent> activeCollisions_;

	public bool canHaveParticleCollisions => false;

	public bool hasCollisionEvents => false;

	public List<ParticleCollisionEvent> activeCollisions => null;

	public void SetColorToParticles(Color color)
	{
	}

	public void ClearAllCollisionEvents()
	{
	}

	public void InitWithVariant(int variantIndex)
	{
	}

	public void InitWithVariant(string variantName)
	{
	}

	public void Show(Vector3 position, Quaternion rotation)
	{
	}

	public void SetOffsetted(Vector3 offsetted)
	{
	}

	public void SetPressed(bool isPressed)
	{
	}

	public void SetActive(bool active)
	{
	}

	public void Hide()
	{
	}
}
