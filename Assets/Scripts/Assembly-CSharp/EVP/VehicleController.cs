using System;
using UnityEngine;

namespace EVP
{
	public class VehicleController : MonoBehaviour
	{
		public enum CenterOfMassMode
		{
			Transform = 0,
			Parametric = 1
		}

		public enum BrakeMode
		{
			Slip = 0,
			Ratio = 1
		}

		public enum UpdateRate
		{
			OnUpdate = 0,
			OnFixedUpdate = 1,
			Disabled = 2
		}

		public enum PositionMode
		{
			Accurate = 0,
			Fast = 1
		}

		public delegate void OnImpact();

		private struct VehicleFrame
		{
			public float frontPosition;

			public float rearPosition;

			public float baseHeight;

			public float frontWidth;

			public float rearWidth;

			public float middlePoint;
		}

		public Wheel[] wheels;

		public CenterOfMassMode centerOfMassMode;

		public float centerOfMassPosition;

		public float centerOfMassHeightOffset;

		public Transform centerOfMassTransform;

		public float maxSpeedForward;

		public float maxSpeedReverse;

		public float tireFriction;

		public float rollingResistance;

		public float antiRoll;

		public float maxSteerAngle;

		public float aeroDrag;

		public float aeroDownforce;

		public float driveBalance;

		public float brakeBalance;

		public float tireFrictionBalance;

		public float aeroBalance;

		public float handlingBias;

		public float maxDriveForce;

		public float forceCurveShape;

		public float maxDriveSlip;

		public float driveForceToMaxSlip;

		public float maxBrakeForce;

		public float brakeForceToMaxSlip;

		public BrakeMode brakeMode;

		public float maxBrakeSlip;

		public float maxBrakeRatio;

		public BrakeMode handbrakeMode;

		public float maxHandbrakeSlip;

		public float maxHandbrakeRatio;

		public bool tractionControl;

		public float tractionControlRatio;

		public bool brakeAssist;

		public float brakeAssistRatio;

		public bool steeringLimit;

		public float steeringLimitRatio;

		public bool steeringAssist;

		public float steeringAssistRatio;

		public float steerInput;

		public float throttleInput;

		public float brakeInput;

		public float handbrakeInput;

		public UpdateRate wheelUpdateRate;

		public PositionMode wheelPositionMode;

		public float sleepVelocity;

		public float defaultGroundGrip;

		public float defaultGroundDrag;

		public bool disallowRuntimeChanges;

		public bool disableSteerAngleCorrection;

		public bool showCollisionGizmos;

		[NonSerialized]
		public bool processContacts;

		[NonSerialized]
		public float impactThreeshold;

		[NonSerialized]
		public float impactInterval;

		[NonSerialized]
		public float impactIntervalRandom;

		[NonSerialized]
		public float impactMinSpeed;

		[NonSerialized]
		public bool computeExtendedTireData;

		public OnImpact onImpact;

		public static VehicleController current;

		public static float RpmToW;

		public static float WToRpm;

		private bool _003CinvertVisualWheelSpinDirection_003Ek__BackingField;

		private Transform m_transform;

		private Rigidbody m_rigidbody;

		private GroundMaterialManager m_groundMaterialManager;

		private Rigidbody m_referenceBody;

		private Rigidbody m_referenceCandidate;

		private int m_referenceCandidateCount;

		[NonSerialized]
		public string debugText;

		private WheelData[] m_wheelData;

		private float m_speed;

		private float m_speedAngle;

		private float m_steerAngle;

		private bool m_usesHandbrake;

		private CommonTools.BiasLerpContext m_forceBiasCtx;

		private VehicleFrame m_vehicleFrame;

		private bool m_paused;

		private bool m_singleFixedStep;

		private bool m_singleUpdateStep;

		private Collider[] m_colliders;

		private int[] m_colLayers;

		private WheelFrictionCurve m_colliderFriction;

		private int m_sumImpactCount;

		private Vector3 m_sumImpactPosition;

		private Vector3 m_sumImpactVelocity;

		private int m_sumImpactHardness;

		private float m_lastImpactTime;

		private Vector3 m_localDragPosition;

		private Vector3 m_localDragVelocity;

		private int m_localDragHardness;

		private float m_lastStrongImpactTime;

		private PhysicMaterial m_lastImpactedMaterial;

		private GroundMaterial m_impactedGroundMaterial;

		public Vector3 localImpactPosition => default(Vector3);

		public Vector3 localImpactVelocity => default(Vector3);

		public bool isHardImpact => false;

		public Vector3 localDragPosition => default(Vector3);

		public Vector3 localDragVelocity => default(Vector3);

		public bool isHardDrag => false;

		public WheelData[] wheelData => null;

		public float speed => 0f;

		public float speedAngle => 0f;

		public float steerAngle => 0f;

		public bool invertVisualWheelSpinDirection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector3 frontAxlePosition => default(Vector3);

		public Vector3 rearAxlePosition => default(Vector3);

		public Transform cachedTransform => null;

		public Rigidbody cachedRigidbody => null;

		public bool paused
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void OnValidate()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		public void SingleStep()
		{
		}

		private void ComputeSteerAngle()
		{
		}

		private void UpdateSteering(WheelData wd)
		{
		}

		private float FixSteerAngle(WheelData wd, float inputSteerAngle)
		{
			return 0f;
		}

		private void UpdateSuspension(WheelData wd)
		{
		}

		private void UpdateLocalFrame(WheelData wd)
		{
		}

		private void UpdateGroundMaterial(WheelData wd)
		{
		}

		private void ComputeTireForces(WheelData wd)
		{
		}

		private void ApplyTireForces(WheelData wd)
		{
		}

		public Vector3 GetSidewaysForceAppPoint(WheelData wd, Vector3 contactPoint)
		{
			return default(Vector3);
		}

		private static float ComputeSlipAngle(Vector2 localVelocity)
		{
			return 0f;
		}

		private static float ComputeCombinedSlip(Vector2 localVelocity, Vector2 tireSlip)
		{
			return 0f;
		}

		private void ComputeExtendedTireData(WheelData wd, float referenceDownforce)
		{
		}

		private float ComputeDriveForce(float demandedForce, float maxForce, bool grounded)
		{
			return 0f;
		}

		private void ComputeBrakeValues(WheelData wd, BrakeMode mode, float maxSlip, float maxRatio, out float brakeSlip, out float brakeRatio)
		{
			brakeSlip = default(float);
			brakeRatio = default(float);
		}

		private void UpdateTransform(WheelData wd, float deltaTime)
		{
		}

		private void UpdateGroundMaterialCached(PhysicMaterial colliderMaterial, ref PhysicMaterial cachedMaterial, ref GroundMaterial groundMaterial)
		{
		}

		public void ResetVehicle()
		{
		}

		private void FindColliders()
		{
		}

		private void DisableCollidersRaycast()
		{
		}

		private void EnableCollidersRaycast()
		{
		}

		public Vector3 RaycastOthers(Vector3 from, Vector3 to, int layerMask = -5)
		{
			return default(Vector3);
		}

		public float SphereRaycastOthers(Vector3 origin, Vector3 direction, float radius, float maxDistance, int layerMask = -5)
		{
			return 0f;
		}

		private float GetWheelForceDistance(WheelCollider col)
		{
			return 0f;
		}

		private void UpdateWheelCollider(WheelCollider col)
		{
		}

		private void SetupWheelCollider(WheelCollider col)
		{
		}

		private void UpdateWheelSleep(WheelData wd)
		{
		}

		private VehicleFrame ComputeVehicleFrame()
		{
			return default(VehicleFrame);
		}

		private void ConfigureCenterOfMass()
		{
		}

		public static float GetBalancedValue(float value, float bias, float positionRatio)
		{
			return 0f;
		}

		public static float GetRampBalancedValue(float value, float bias, float positionRatio)
		{
			return 0f;
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void OnCollisionStay(Collision collision)
		{
		}

		private void ProcessContacts(Collision col, bool isCollisionEnter)
		{
		}

		private void HandleImpacts()
		{
		}

		private void UpdateDragState(Vector3 dragPosition, Vector3 dragVelocity, int dragHardness)
		{
		}

		private void AdjustWheelColliders()
		{
		}

		private static void AdjustColliderToWheelMesh(WheelCollider wheelCollider, Transform wheelTransform)
		{
		}

		private static Bounds GetScaledBounds(MeshFilter meshFilter)
		{
			return default(Bounds);
		}

		private void FromTransformToParametricCoM()
		{
		}
	}
}
