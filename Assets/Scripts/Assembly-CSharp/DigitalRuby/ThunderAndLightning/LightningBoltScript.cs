using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBoltScript : MonoBehaviour
	{
		public Camera Camera;

		public CameraMode CameraMode;

		internal CameraMode calculatedCameraMode;

		public bool UseWorldSpace;

		public bool CompensateForParentTransform;

		public LightningBoltQualitySetting QualitySetting;

		public bool MultiThreaded;

		public float LevelOfDetailDistance;

		public bool UseGameTime;

		public string SortLayerName;

		public int SortOrderInLayer;

		public float SoftParticlesFactor;

		public int RenderQueue;

		public Material LightningMaterialMesh;

		public Material LightningMaterialMeshNoGlow;

		public Texture2D LightningTexture;

		public Texture2D LightningGlowTexture;

		public ParticleSystem LightningOriginParticleSystem;

		public ParticleSystem LightningDestinationParticleSystem;

		public Color LightningTintColor;

		public Color GlowTintColor;

		public BlendMode SourceBlendMode;

		public BlendMode DestinationBlendMode;

		public float JitterMultiplier;

		public float Turbulence;

		public Vector3 TurbulenceVelocity;

		public Vector4 IntensityFlicker;

		private static readonly Vector4 intensityFlickerDefault;

		public Texture2D IntensityFlickerTexture;

		private Action<LightningBoltParameters, Vector3, Vector3> _003CLightningStartedCallback_003Ek__BackingField;

		private Action<LightningBoltParameters, Vector3, Vector3> _003CLightningEndedCallback_003Ek__BackingField;

		private Action<Light> _003CLightAddedCallback_003Ek__BackingField;

		private Action<Light> _003CLightRemovedCallback_003Ek__BackingField;

		private static Vector4 _003CTimeVectorSinceStart_003Ek__BackingField;

		private static float _003CTimeSinceStart_003Ek__BackingField;

		private static float _003CDeltaTime_003Ek__BackingField;

		public static float TimeScale;

		private static bool needsTimeUpdate;

		private Material _003ClightningMaterialMeshInternal_003Ek__BackingField;

		private Material _003ClightningMaterialMeshNoGlowInternal_003Ek__BackingField;

		private Texture2D lastLightningTexture;

		private Texture2D lastLightningGlowTexture;

		private readonly List<LightningBolt> activeBolts;

		private readonly LightningBoltParameters[] oneParameterArray;

		private readonly List<LightningBolt> lightningBoltCache;

		private readonly List<LightningBoltDependencies> dependenciesCache;

		private LightningThreadState threadState;

		private static int shaderId_MainTex;

		private static int shaderId_TintColor;

		private static int shaderId_JitterMultiplier;

		private static int shaderId_Turbulence;

		private static int shaderId_TurbulenceVelocity;

		private static int shaderId_SrcBlendMode;

		private static int shaderId_DstBlendMode;

		private static int shaderId_InvFade;

		private static int shaderId_LightningTime;

		private static int shaderId_IntensityFlicker;

		private static int shaderId_IntensityFlickerTexture;

		public Action<LightningBoltParameters, Vector3, Vector3> LightningStartedCallback
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Action<LightningBoltParameters, Vector3, Vector3> LightningEndedCallback
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Action<Light> LightAddedCallback
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Action<Light> LightRemovedCallback
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool HasActiveBolts => false;

		public static Vector4 TimeVectorSinceStart
		{
			get
			{
				return default(Vector4);
			}
			private set
			{
			}
		}

		public static float TimeSinceStart
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		public static float DeltaTime
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		internal Material lightningMaterialMeshInternal
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		internal Material lightningMaterialMeshNoGlowInternal
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public virtual void CreateLightningBolt(LightningBoltParameters p)
		{
		}

		public void CreateLightningBolts(ICollection<LightningBoltParameters> parameters)
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual LightningBoltParameters OnCreateParameters()
		{
			return null;
		}

		protected LightningBoltParameters CreateParameters()
		{
			return null;
		}

		protected virtual void PopulateParameters(LightningBoltParameters p)
		{
		}

		private Coroutine StartCoroutineWrapper(IEnumerator routine)
		{
			return null;
		}

		private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		private LightningBoltDependencies CreateLightningBoltDependencies(ICollection<LightningBoltParameters> parameters)
		{
			return null;
		}

		private void ReturnLightningDependenciesToCache(LightningBoltDependencies d)
		{
		}

		internal void OnLightAdded(Light l)
		{
		}

		internal void OnLightRemoved(Light l)
		{
		}

		internal void AddActiveBolt(LightningBolt bolt)
		{
		}

		private void UpdateShaderIds()
		{
		}

		private void UpdateMaterialsForLastTexture()
		{
		}

		private void UpdateTexture()
		{
		}

		private void SetMaterialPerspective()
		{
		}

		private void SetMaterialOrthographicXY()
		{
		}

		private void SetMaterialOrthographicXZ()
		{
		}

		private void SetupMaterialCamera()
		{
		}

		private void EnableKeyword(string keyword, bool enable, Material m)
		{
		}

		private void UpdateShaderParameters()
		{
		}

		private void CheckCompensateForParentTransform()
		{
		}

		private void UpdateCamera()
		{
		}

		private LightningBolt GetOrCreateLightningBolt()
		{
			return null;
		}

		private void UpdateActiveBolts()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void Cleanup()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}
	}
}
