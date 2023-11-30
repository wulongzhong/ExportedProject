using UnityEngine;

public class GGPSphereCommand
{
	public struct Params
	{
		public Vector3 worldPosition;

		public Color brushColor;

		public float brushSize;

		public float brushHardness;

		public void SetToMaterial(Material material)
		{
		}
	}

	private static Material material_;

	public static Material sharedMaterial => null;
}
