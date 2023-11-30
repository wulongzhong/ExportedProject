using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[ExecuteInEditMode]
public class _2dxFX_AL_Offset : MonoBehaviour
{
	public Material ForceMaterial;

	public bool ActiveChange;

	public bool AddShadow;

	public bool ReceivedShadow;

	public int BlendMode;

	private string shader;

	public float _Alpha;

	public float _OffsetX;

	public float _OffsetY;

	public float _ZoomX;

	public float _ZoomY;

	public float _ZoomXY;

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
