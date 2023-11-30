using UnityEngine;

namespace EVP
{
	public class TireMarksRenderer : MonoBehaviour
	{
		public enum Mode
		{
			PressureAndSkid = 0,
			PressureOnly = 1
		}

		public Mode mode;

		public float pressureBoost;

		public int maxMarks;

		public float minDistance;

		public float groundOffset;

		public float textureOffsetY;

		public float fadeOutRange;

		public Material material;

		private int m_markCount;

		private int m_markArraySize;

		private MarkPoint[] m_markPoints;

		private CommonTools.BiasLerpContext m_biasCtx;

		private bool m_segmentsUpdated;

		private int m_segmentCount;

		private int m_segmentArraySize;

		private Mesh m_mesh;

		private Vector3[] m_vertices;

		private Vector3[] m_normals;

		private Vector4[] m_tangents;

		private Color[] m_colors;

		private Vector2[] m_uvs;

		private int[] m_triangles;

		private Vector2[] m_values;

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		public int AddMark(Vector3 pos, Vector3 normal, float pressureRatio, float skidRatio, float width, int lastIndex)
		{
			return 0;
		}

		public void Clear()
		{
		}

		private void AddSegment(MarkPoint first, MarkPoint second)
		{
		}

		private void LateUpdate()
		{
		}
	}
}
