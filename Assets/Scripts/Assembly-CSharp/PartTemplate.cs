using UnityEngine;

public class PartTemplate : MonoBehaviour
{
	public enum CopyType
	{
		CopyAllChildren = 0,
		CopyRoot = 1
	}

	[SerializeField]
	public string path;

	[SerializeField]
	public CopyType copyType;

	public string linkName => null;
}
