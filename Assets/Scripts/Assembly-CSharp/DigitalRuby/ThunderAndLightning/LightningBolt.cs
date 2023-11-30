using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBolt
	{
		public class LineRendererMesh
		{
			private GameObject _003CGameObject_003Ek__BackingField;

			private int _003CTag_003Ek__BackingField;

			private Action<LightningCustomTransformStateInfo> _003CCustomTransform_003Ek__BackingField;

			private Transform _003CTransform_003Ek__BackingField;

			private const int defaultListCapacity = 2048;

			private static readonly Vector2 uv1;

			private static readonly Vector2 uv2;

			private static readonly Vector2 uv3;

			private static readonly Vector2 uv4;

			private readonly List<int> indices;

			private readonly List<Vector3> vertices;

			private readonly List<Vector4> lineDirs;

			private readonly List<Color32> colors;

			private readonly List<Vector3> ends;

			private readonly List<Vector4> texCoordsAndGlowModifiers;

			private readonly List<Vector4> fadeLifetimes;

			private const int boundsPadder = 1000000000;

			private int currentBoundsMinX;

			private int currentBoundsMinY;

			private int currentBoundsMinZ;

			private int currentBoundsMaxX;

			private int currentBoundsMaxY;

			private int currentBoundsMaxZ;

			private Mesh mesh;

			private MeshFilter meshFilterGlow;

			private MeshFilter meshFilterBolt;

			private MeshRenderer meshRendererGlow;

			private MeshRenderer meshRendererBolt;

			public GameObject GameObject
			{
				get
				{
					return null;
				}
				private set
				{
				}
			}

			public Material MaterialGlow
			{
				set
				{
				}
			}

			public Material MaterialBolt
			{
				set
				{
				}
			}

			public MeshRenderer MeshRendererGlow => null;

			public MeshRenderer MeshRendererBolt => null;

			public int Tag
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public Action<LightningCustomTransformStateInfo> CustomTransform
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Transform Transform
			{
				get
				{
					return null;
				}
				private set
				{
				}
			}

			public bool Empty => false;

			public void PopulateMesh()
			{
			}

			public bool PrepareForLines(int lineCount)
			{
				return false;
			}

			public void BeginLine(Vector3 start, Vector3 end, float radius, Color32 color, float colorIntensity, Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity)
			{
			}

			public void AppendLine(Vector3 start, Vector3 end, float radius, Color32 color, float colorIntensity, Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity)
			{
			}

			public void Reset()
			{
			}

			private void PopulateMeshInternal()
			{
			}

			private void UpdateBounds(ref Vector3 point1, ref Vector3 point2)
			{
			}

			private void AddIndices()
			{
			}

			private void AppendLineInternal(ref Vector3 start, ref Vector3 end, ref Vector4 dir, ref Vector4 dirPrev1, ref Vector4 dirPrev2, Color32 color, float colorIntensity, ref Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity)
			{
			}
		}

		private sealed class _003CEnableLastRendererCoRoutine_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LightningBolt _003C_003E4__this;

			private LineRendererMesh _003ClineRenderer_003E5__2;

			private int _003Ctag_003E5__3;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            object IEnumerator<object>.Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CEnableLastRendererCoRoutine_003Ed__39(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }
        }

		private sealed class _003C_003Ec__DisplayClass41_0
		{
			public LightningBolt _003C_003E4__this;

			public LineRendererMesh currentLineRenderer;

			internal void _003CRenderGroup_003Eb__0()
			{
			}
		}

		private sealed class _003CNotifyBolt_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LightningBoltParameters p;

			public LightningBoltDependencies dependencies;

			public Vector3 start;

			public Vector3 end;

			public Transform transform;

			private float _003ClifeTime_003E5__2;

			private LightningCustomTransformStateInfo _003Cstate_003E5__3;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            object IEnumerator<object>.Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CNotifyBolt_003Ed__42(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }
        }

		private sealed class _003C_003Ec__DisplayClass44_0
		{
			public LightningBoltDependencies dependenciesRef;
		}

		private sealed class _003C_003Ec__DisplayClass44_1
		{
			public LightningBoltParameters parameters;

			public _003C_003Ec__DisplayClass44_0 CS_0024_003C_003E8__locals1;
		}

		private sealed class _003C_003Ec__DisplayClass44_2
		{
			public Transform transform;

			public _003C_003Ec__DisplayClass44_1 CS_0024_003C_003E8__locals2;

			internal void _003CProcessAllLightningParameters_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass48_0
		{
			public LightningBolt _003C_003E4__this;

			public Vector3 start;

			public Vector3 end;

			public LightningBoltParameters parameters;

			public LightningLightParameters lp;

			public int startGroupIndex;

			public LightningBoltQualitySetting quality;

			internal void _003CRenderLightningBolt_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass48_1
		{
			public LineRendererMesh currentLineRenderer;

			public _003C_003Ec__DisplayClass48_0 CS_0024_003C_003E8__locals1;

			internal void _003CRenderLightningBolt_003Eb__1()
			{
			}
		}

		private sealed class _003CGenerateParticleCoRoutine_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public ParticleSystem p;

			public Vector3 pos;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            object IEnumerator<object>.Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CGenerateParticleCoRoutine_003Ed__54(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }
        }

		public static int MaximumLightCount;

		public static int MaximumLightsPerBatch;

		private float _003CMinimumDelay_003Ek__BackingField;

		private bool _003CHasGlow_003Ek__BackingField;

		private CameraMode _003CCameraMode_003Ek__BackingField;

		private DateTime startTimeOffset;

		private LightningBoltDependencies dependencies;

		private float elapsedTime;

		private float lifeTime;

		private float maxLifeTime;

		private bool hasLight;

		private float timeSinceLevelLoad;

		private readonly List<LightningBoltSegmentGroup> segmentGroups;

		private readonly List<LightningBoltSegmentGroup> segmentGroupsWithLight;

		private readonly List<LineRendererMesh> activeLineRenderers;

		private static int lightCount;

		private static readonly List<LineRendererMesh> lineRendererCache;

		private static readonly List<LightningBoltSegmentGroup> groupCache;

		private static readonly List<Light> lightCache;

		public float MinimumDelay
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		public bool HasGlow
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public bool IsActive => false;

		public CameraMode CameraMode
		{
			get
			{
				return default(CameraMode);
			}
			private set
			{
			}
		}

		public void SetupLightningBolt(LightningBoltDependencies dependencies)
		{
		}

		public bool Update()
		{
			return false;
		}

		public void Cleanup()
		{
		}

		public LightningBoltSegmentGroup AddGroup()
		{
			return null;
		}

		public static void ClearCache()
		{
		}

		private void CleanupLight(Light l)
		{
		}

		private void EnableLineRenderer(LineRendererMesh lineRenderer, int tag)
		{
		}

		private IEnumerator EnableLastRendererCoRoutine()
		{
			return null;
		}

		private LineRendererMesh GetOrCreateLineRenderer()
		{
			return null;
		}

		private void RenderGroup(LightningBoltSegmentGroup group, LightningBoltParameters p)
		{
		}

		private static IEnumerator NotifyBolt(LightningBoltDependencies dependencies, LightningBoltParameters p, Transform transform, Vector3 start, Vector3 end)
		{
			return null;
		}

		private void ProcessParameters(LightningBoltParameters p, RangeOfFloats delay, LightningBoltDependencies depends)
		{
		}

		private void ProcessAllLightningParameters()
		{
		}

		private void EnableCurrentLineRendererFromThread()
		{
		}

		private void EnableCurrentLineRenderer()
		{
		}

		private void RenderParticleSystems(Vector3 start, Vector3 end, float trunkWidth, float lifeTime, float delaySeconds)
		{
		}

		private Transform RenderLightningBolt(LightningBoltQualitySetting quality, int generations, int startGroupIndex, int endGroupIndex, LightningBoltParameters parameters)
		{
			return null;
		}

		private void CreateLightsForGroup(LightningBoltSegmentGroup group, LightningLightParameters lp, LightningBoltQualitySetting quality, int maxLights)
		{
		}

		private bool AddLightToGroup(LightningBoltSegmentGroup group, LightningLightParameters lp, int segmentIndex, int nthLight, int nthShadows, ref int maxLights, ref int nthShadowCounter)
		{
			return false;
		}

		private Light GetOrCreateLight(LightningLightParameters lp)
		{
			return null;
		}

		private void UpdateLight(LightningLightParameters lp, IEnumerable<Light> lights, float delay, float peakStart, float peakEnd, float lifeTime)
		{
		}

		private void UpdateLights()
		{
		}

		private IEnumerator GenerateParticleCoRoutine(ParticleSystem p, Vector3 pos, float delay)
		{
			return null;
		}

		private void CheckForGlow(IEnumerable<LightningBoltParameters> parameters)
		{
		}
	}
}
