using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[ExecuteInEditMode]
public class _2dxFX_AL_Blood : MonoBehaviour
{
	public Material ForceMaterial;

	public bool ActiveChange;

	public bool AddShadow;

	public bool ReceivedShadow;

	public int BlendMode;

	private string shader;

	public float _Alpha;

	public Texture2D __MainTex2;

	public float TurnToBlood;

	public float Blood;

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
