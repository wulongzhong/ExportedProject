using UnityEngine;

public class CarModelColliders : MonoBehaviour
{
	private class State
	{
		public CarModelPart part;
	}

	private class OutState
	{
		public bool hasCollider;

		public bool isInColliderSubtree;

		public CarModelSubpart subpart;
	}

	public void Init(CarModel model)
	{
	}

	private void CopyRecursively(Transform localParent, Transform searchParent, State state, OutState outState)
	{
	}

	private void StripObject(GameObject objectToStrip)
	{
	}
}
