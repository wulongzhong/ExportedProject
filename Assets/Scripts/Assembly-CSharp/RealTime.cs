using System;
using UnityEngine;

public class RealTime : MonoBehaviour
{
	private static RealTime mInst;

	private float mRealTime;

	private float mRealDelta;

	private float mRealTimeIgnoreApplicationPause;

	private float mRealDeltaIgnoreApplicationPause;

	private bool isCurrentFrameTimeSet;

	private DateTime currentFrameTime;

	private static bool applicationIsQuitting;

	public static float time => 0f;

	public static DateTime frameDateTime => default(DateTime);

	public static float deltaTimeIgnoreApplicationPause => 0f;

	public static float deltaTime => 0f;

	private static void Spawn()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}
}
