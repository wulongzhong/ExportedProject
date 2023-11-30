using System;
using System.Collections;
using System.Collections.Generic;

public class EnumeratorsList
{
	protected struct EnumeratorDesc
	{
		public IEnumerator enumerator;

		public float delay;

		public Action onStart;

		public Action interuptionHandler;

		public bool started;

		public bool useScaledTime;

		//public EnumeratorDesc(IEnumerator enumerator, float delay, Action onStart, Action interuptionHandler, bool useScaledTime = false)
		//{
		//}
	}

	protected List<EnumeratorDesc> list;

	public EnumeratorsList Add(IEnumerator e, float delay = 0f, Action onStart = null, Action interuptionHandler = null, bool useScaledTime = false)
	{
		return null;
	}

	public EnumeratorsList Clear()
	{
		return null;
	}

	public bool Update()
	{
		return false;
	}
}
