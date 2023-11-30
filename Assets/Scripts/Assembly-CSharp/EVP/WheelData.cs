using UnityEngine;

namespace EVP
{
	public class WheelData
	{
		public Wheel wheel;

		public WheelCollider collider;

		public Transform transform;

		public Vector3 origin;

		public float forceDistance;

		public float steerAngle;

		public bool grounded;

		public WheelHit hit;

		public GroundMaterial groundMaterial;

		public float suspensionCompression;

		public float downforce;

		public Vector3 velocity;

		public Vector2 localVelocity;

		public Vector2 localRigForce;

		public bool isBraking;

		public float finalInput;

		public Vector2 tireSlip;

		public Vector2 tireForce;

		public Vector2 dragForce;

		public Vector2 rawTireForce;

		public float angularVelocity;

		public float angularPosition;

		public PhysicMaterial lastPhysicMaterial;

		public bool visualGrounded;

		public RaycastHit visualHit;

		public Collider visualHitCollider;

		public float positionRatio;

		public bool isWheelChildOfCaliper;

		public float combinedTireSlip;

		public float downforceRatio;
	}
}
