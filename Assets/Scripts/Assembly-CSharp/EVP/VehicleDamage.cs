using UnityEngine;

namespace EVP
{
	public class VehicleDamage : MonoBehaviour
	{
		public MeshFilter[] meshes;

		public MeshCollider[] colliders;

		public Transform[] nodes;

		public float minVelocity;

		public float multiplier;

		public float damageRadius;

		public float maxDisplacement;

		public float maxVertexFracture;

		public float nodeDamageRadius;

		public float maxNodeRotation;

		public float nodeRotationRate;

		public float vertexRepairRate;

		public bool enableRepairKey;

		public KeyCode repairKey;

		private VehicleController m_vehicle;

		private Vector3[][] m_originalMeshes;

		private Vector3[][] m_originalColliders;

		private Vector3[] m_originalNodePositions;

		private Quaternion[] m_originalNodeRotations;

		private bool m_repairing;

		private float m_meshDamage;

		private float m_colliderDamage;

		private float m_nodeDamage;

		public bool isRepairing => false;

		public float meshDamage => 0f;

		public float colliderDamage => 0f;

		public float nodeDamage => 0f;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		public void Repair()
		{
		}

		public void RepairImmediate()
		{
		}

		private void ProcessImpact()
		{
		}

		private float DeformMesh(Mesh mesh, Vector3[] originalMesh, Transform localTransform, Vector3 contactPoint, Vector3 contactVelocity)
		{
			return 0f;
		}

		private float DeformNode(Transform T, Vector3 originalLocalPos, Quaternion originalLocalRot, Vector3 contactPoint, Vector3 contactVelocity)
		{
			return 0f;
		}

		private Vector3 AnglesToVector(Vector3 Angles)
		{
			return default(Vector3);
		}

		private float DeformColliders(Vector3 contactPoint, Vector3 impactVelocity)
		{
			return 0f;
		}

		private void ProcessRepair()
		{
		}

		private bool RepairMesh(Mesh mesh, Vector3[] originalMesh, float repairRate, float repairedThreshold)
		{
			return false;
		}

		private bool RepairNode(Transform T, Vector3 originalLocalPosition, Quaternion originalLocalRotation, float repairRate, float repairedThreshold)
		{
			return false;
		}

		private void RestoreMeshes()
		{
		}

		private void RestoreNodes()
		{
		}

		private void RestoreColliders()
		{
		}
	}
}
