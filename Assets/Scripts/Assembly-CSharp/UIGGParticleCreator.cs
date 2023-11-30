using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UIGGParticleCreator
{
	[Serializable]
	public class ParticleSettings
	{
		public string name;

		public GameObject particlePrefab;

		public Transform parent;

		public bool keepTransform;
	}

	private List<GameObject> createdGameObjects;

	public List<ParticleSettings> settings;

	public ParticleSettings GetSettings(string name)
	{
		return null;
	}

	public void DestroyCreatedObjects()
	{
	}

	private GameObject Create(GameObject prefab)
	{
		return null;
	}

	public void CreateAndRunParticles(string name, Transform origin)
	{
	}

	public void CreateAndRunParticles(GameObject particlePrefab, Transform parent, Transform origin, bool keepTransform)
	{
	}
}
