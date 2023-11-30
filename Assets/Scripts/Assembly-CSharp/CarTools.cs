using System;
using System.Collections.Generic;
using UnityEngine;

public class CarTools : MonoBehaviour
{
	[Serializable]
	public class Category
	{
		public string name;

		public List<Transform> visible;
	}

	public List<Category> categories;

	public void HideAll()
	{
	}

	public void ShowAll()
	{
	}

	private void SetActive(bool active)
	{
	}

	public void ShowCategory(Category category)
	{
	}

	private Transform FirstTransformInHierarchyWithMultipleChildren(Transform root)
	{
		return null;
	}
}
