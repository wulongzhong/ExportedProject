using System;
using System.Collections.Generic;
using UnityEngine;

public class MarkMeshMaterialsWithTag : MonoBehaviour
{
	[Serializable]
	public class TagSelector
	{
		public string selector;

		public string tag;
	}

	public class FoundMesh
	{
		public MeshRenderer meshRenderer;

		public int materialIndex;
	}

	[SerializeField]
	private List<TagSelector> tags;

	[SerializeField]
	private List<string> ignorePaths;

	private void FindAllMeshes(string selector, Transform root, List<FoundMesh> results)
	{
	}

	public static List<MeshMaterialTag> FindAllMeshMaterialTags(Transform root)
	{
		return null;
	}

	private static void FindTagsRecursively(Transform root, List<MeshMaterialTag> tags)
	{
	}

	public List<MeshMaterialTag> FindAllMeshMaterialTags()
	{
		return null;
	}

	private bool IsOnIgnoreList(FoundMesh mesh)
	{
		return false;
	}

	public static bool IsPathSelected(string path, string selector)
	{
		return false;
	}

	public static string RelativePath(Transform root, Transform relative)
	{
		return null;
	}
}
