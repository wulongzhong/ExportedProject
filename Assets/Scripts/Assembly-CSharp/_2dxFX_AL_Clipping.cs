using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[ExecuteInEditMode]
public class _2dxFX_AL_Clipping : MonoBehaviour
{
	public Material ForceMaterial;

	public bool ActiveChange;

	public bool AddShadow;

	public bool ReceivedShadow;

	public int BlendMode;

	private string shader;

	public float _Alpha;

	public float _ClipLeft;

	public float _ClipRight;

	public float _ClipUp;

	public float _ClipDown;

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
