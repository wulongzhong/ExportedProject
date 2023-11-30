using System;
using UnityEngine;

public class UVOffsetAnim : MonoBehaviour
{
	[SerializeField]
	private Vector2 offsetSpeed;

	[NonSerialized]
	private MeshRenderer myRenderer;

	[NonSerialized]
	private Vector2 startOffset;

	[NonSerialized]
	private Vector2 offset;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}
}
