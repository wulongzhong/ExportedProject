using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[ExecuteInEditMode]
public class _2dxFX_AL_EnergyBar : MonoBehaviour
{
	public Material ForceMaterial;

	public bool ActiveChange;

	public bool AddShadow;

	public bool ReceivedShadow;

	public int BlendMode;

	private string shader;

	public float _Alpha;

	public float BarProgress;

	public float _Value2;

	public float _Value3;

	public float _Value4;

	public float _Value5;

	public int ShaderChange;

	private Material tempMaterial;

	private Material defaultMaterial;

	private Image CanvasImage;

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
