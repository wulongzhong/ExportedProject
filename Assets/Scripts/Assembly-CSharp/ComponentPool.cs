using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ComponentPool
{
	public Transform parent;

	public GameObject prefab;

	[SerializeField]
	private bool resetScale;

	[SerializeField]
	private bool resetRotation;

	[NonSerialized]
	public List<GameObject> usedObjects;

	private List<GameObject> notUsedObjects;

	public Vector2 prefabSizeDelta => default(Vector2);

	public float prefabWidth => 0f;

	public float prefabHeight => 0f;

	public void Clear()
	{
	}

	public void HideNotUsed()
	{
	}

	public GameObject Instantiate(bool activate = false)
	{
		return null;
	}

	public GameObject Next(bool activate = false)
	{
		return null;
	}

	public T Next<T>(bool activate = false) where T : MonoBehaviour
	{
		return null;
	}
}
