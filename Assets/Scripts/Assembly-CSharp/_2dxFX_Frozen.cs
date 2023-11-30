using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[ExecuteInEditMode]
public class _2dxFX_Frozen : MonoBehaviour
{
	public Material ForceMaterial;

	public bool ActiveChange;

	private string shader;

	public float _Alpha;

	public Texture2D __MainTex2;

	public float _Value1;

	public float _Value2;

	public float _Value3;

	public float _Value4;

	public bool _AutoScrollX;

	public float _AutoScrollSpeedX;

	public bool _AutoScrollY;

	public float _AutoScrollSpeedY;

	private float _AutoScrollCountX;

	private float _AutoScrollCountY;

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
