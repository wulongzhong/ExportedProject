using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[ExecuteInEditMode]
public class _2dxFX_JellyAutoMove : MonoBehaviour
{
	public Material ForceMaterial;

	public bool ActiveChange;

	private string shader;

	public float _Alpha;

	public float Heat;

	public float RandomPos;

	public float Inside;

	public float Stabilisation;

	public float Speed;

	public int ShaderChange;

	private Material tempMaterial;

	private Material defaultMaterial;

	private Image CanvasImage;

	private Vector3 SaveMove1;

	private Vector3 SaveMove2;

	private SpriteRenderer CanvasSpriteRenderer;

	public bool ActiveUpdate;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void CallUpdate()
	{
	}

	private void Update()
	{
	}

	private void XUpdate()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}
}
