using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class VisualStyleSet
{
	[Serializable]
	public class ObjectStyle
	{
		public enum Action
		{
			Show = 0,
			Hide = 1
		}

		public Action action;

		public Transform visual;

		public void Apply()
		{
		}

		public void Apply(VisibilityHelper visibility)
		{
		}
	}

	[SerializeField]
	private List<ObjectStyle> objects;

	public void Apply()
	{
	}

	public void Apply(VisibilityHelper visibility)
	{
	}
}
