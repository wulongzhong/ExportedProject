using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[ExecuteInEditMode]
public class _2dxFX_Shiny_Reflect : MonoBehaviour
{
	public Material ForceMaterial;

	public bool ActiveChange;

	public Texture2D __MainTex2;

	private string shader;

	public float _Alpha;

	public float Light;

	public float LightSize;

	public bool UseShinyCurve;

	public AnimationCurve ShinyLightCurve;

	public float AnimationSpeedReduction;

	public float Intensity;

	public float OnlyLight;

	public float LightBump;

	private float ShinyLightCurveTime;

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
