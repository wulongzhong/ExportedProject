using System;
using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<GameObject, string> _003C_003E9__14_0;

		internal string _003CStart_003Eb__14_0(GameObject go)
		{
			return null;
		}
	}

	public GameObject[] particles;

	public int maxButtons;

	public bool spawnOnAwake;

	public string removeTextFromButton;

	public string removeTextFromMaterialButton;

	public float autoChangeDelay;

	private int page;

	private int pages;

	private GameObject currentGO;

	private Color currentColor;

	private bool isPS;

	private bool _active;

	private int counter;

	public GUIStyle bigStyle;

	public void Start()
	{
	}

	public void Update()
	{
	}

	public void NextModel()
	{
	}

	public void Duplicate()
	{
	}

	public void DestroyAll()
	{
	}

	public void OnGUI()
	{
	}

	public void ReplaceGO(GameObject _go)
	{
	}

	public void PlayPS(ParticleSystem _ps, int _nr)
	{
	}
}
