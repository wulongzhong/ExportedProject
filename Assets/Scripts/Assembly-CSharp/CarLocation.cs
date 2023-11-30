using System;
using System.Collections.Generic;
using UnityEngine;

public class CarLocation : MonoBehaviour
{
	[Serializable]
	public class TaggedObjects
	{
		[SerializeField]
		public string tag;

		[SerializeField]
		public List<Transform> objects;

		public void Show()
		{
		}

		public void SetActive(bool active)
		{
		}
	}

	[SerializeField]
	private BPCEMVisualisation visualisation;

	[SerializeField]
	private Transform ambientAudio;

	[SerializeField]
	private List<TaggedObjects> taggedObjects;

	[SerializeField]
	private List<Transform> hideList;

	public void Init(CarScene car)
	{
	}

	public void InitPerOnEnable()
	{
	}

	public void PlayAmbientAudio()
	{
	}

	public void StopAmbientAudio()
	{
	}

	private void SetActive(string tag, bool active)
	{
	}

	private void ShowAll()
	{
	}
}
