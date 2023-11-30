using System.Collections.Generic;
using UnityEngine;

public class VisibilityHelper
{
	private struct VisibilitySetting
	{
		public GameObject go;

		public bool isVisible;
	}

	private List<VisibilitySetting> visibilities;

	public void Clear()
	{
	}

	public void SaveIsVisible(List<RectTransform> list)
	{
	}

	public void SaveIsVisible(GameObject go)
	{
	}

	public void SetActive(List<Transform> list, bool isVisible)
	{
	}

	public void SetActive(Transform transform, bool isVisible)
	{
	}

	public void SetActive(GameObject go, bool isVisible)
	{
	}

	public void Complete()
	{
	}
}
