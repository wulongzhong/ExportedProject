using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[ExecuteInEditMode]
public class _2dxFX_Mystic_Distortion_Additive : MonoBehaviour
{
	public Material ForceMaterial;

	public bool ActiveChange;

	private string shader;

	public float _Alpha;

	public float _Pitch;

	public bool Pitch_Wave;

	public float _Pitch_Speed;

	public float _Pitch_Offset;

	public float _OffsetX;

	public float _OffsetY;

	public float _DistanceX;

	public float _DistanceY;

	public float _WaveTimeX;

	public float _WaveTimeY;

	public bool AutoPlayWaveX;

	public float AutoPlaySpeedX;

	public bool AutoPlayWaveY;

	public float AutoPlaySpeedY;

	public bool AutoRandom;

	public float AutoRandomRange;

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
