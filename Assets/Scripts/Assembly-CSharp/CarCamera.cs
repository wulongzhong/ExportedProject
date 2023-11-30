using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CarCamera : MonoBehaviour
{
	[Serializable]
	public class BlendSettings
	{
		public float blendDuration;

		public AnimationCurve blendCurve;
	}

	[Serializable]
	public class Settings
	{
		public string settingsName;

		public float cameraDistance;

		public GGMath.FloatRange verticalAngleRange;

		public bool useHorizontalAngleRange;

		public GGMath.FloatRange horizontalAngleRange;

		public float fov;

		public float startVerticalAngle;

		public float startHorizontalAngle;

		public float horizontalAngleSpeed;

		public float verticalAngleSpeed;

		public bool enableRotationCenter;

		public Vector3 rotationCenter;

		public bool changeAnglesAtStart;

		public Transform originalTransform;

		public Settings Clone()
		{
			return null;
		}

		public Vector3 RotationCenter(Transform cameraParentTransform)
		{
			return default(Vector3);
		}
	}

	[Serializable]
	public class InertiaSettings
	{
		[SerializeField]
		public float maxVelocity;

		[SerializeField]
		public float dragSpeed;

		[SerializeField]
		public float minInertia;

		[SerializeField]
		public float affinityToNew;

		public Vector2 GetInertia(Vector2 displace, float deltaTime)
		{
			return default(Vector2);
		}
	}

	public struct State
	{
		public float horizontalAngle;

		public float verticalAngle;

		public float zoom;
	}

	private struct InputState
	{
		private Vector3 previousPosition;

		public bool isDown;

		public bool isMoved;

		public float totalDisplace;

		public bool isPinch;

		public int touchId;

		public Vector2 lastPosition;

		public Vector2 inertia;

		public int pinchFinger1TouchId;

		public int pinchFinger2TouchId;

		public float lastPinchScreenDistance;
	}

	public class AnimateIntoSettingsArguments
	{
		public Settings newSettings;

		public bool updateAngle;

		public Camera exampleCamera;

		public bool changeHorizontalAngle;

		public float newHorizontalAngle;

		public bool fadeFromBlack;

		public bool autoSetHorizontalAngle;

		public float time;
	}

	private sealed class _003CDoAnimateIntoSettingsFromCamera_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnimateIntoSettingsArguments arguments;

		public CarCamera _003C_003E4__this;

		private Camera _003CexampleCamera_003E5__2;

		private Settings _003CnewSettings_003E5__3;

		private float _003Cduration_003E5__4;

		private AnimationCurve _003Ccurve_003E5__5;

		private Vector3 _003CrotationCenterEnd_003E5__6;

		private float _003ChorizontalAngleEnd_003E5__7;

		private float _003CverticalAngleEnd_003E5__8;

		private float _003CendDistance_003E5__9;

		private Transform _003CcameraTransform_003E5__10;

		private float _003CendFOV_003E5__11;

		private int _003CzoomEnd_003E5__12;

		private float _003Ctime_003E5__13;

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
		public _003CDoAnimateIntoSettingsFromCamera_003Ed__41(int _003C_003E1__state)
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

	private sealed class _003CDoAnimateIntoSettings_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnimateIntoSettingsArguments arguments;

		public CarCamera _003C_003E4__this;

		private Settings _003CnewSettings_003E5__2;

		private float _003Cduration_003E5__3;

		private AnimationCurve _003Ccurve_003E5__4;

		private Vector3 _003CrotationCenterStart_003E5__5;

		private Vector3 _003CrotationCenterEnd_003E5__6;

		private float _003ChorizontalAngleStart_003E5__7;

		private float _003CverticalAngleStart_003E5__8;

		private float _003ChorizontalAngleEnd_003E5__9;

		private float _003CverticalAngleEnd_003E5__10;

		private float _003CstartDistance_003E5__11;

		private float _003CendDistance_003E5__12;

		private Transform _003CcameraTransform_003E5__13;

		private float _003CstartFOV_003E5__14;

		private float _003CendFOV_003E5__15;

		private float _003CzoomStart_003E5__16;

		private int _003CzoomEnd_003E5__17;

		private float _003Ctime_003E5__18;

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
		public _003CDoAnimateIntoSettings_003Ed__42(int _003C_003E1__state)
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

	[SerializeField]
	private Camera camera;

	[SerializeField]
	private bool useSettingsStartAngles;

	[SerializeField]
	public CameraSetups cameraSetups;

	[SerializeField]
	public string mainCameraSetupName;

	[SerializeField]
	private Settings settings;

	[NonSerialized]
	private Settings usedSettings;

	private IEnumerator animation;

	[SerializeField]
	public InertiaSettings inertiaSettings;

	[NonSerialized]
	private InputState inputState;

	[NonSerialized]
	private InputHandler inputHandler;

	private State state;

	public Vector3 cameraForward => default(Vector3);

	public Vector3 cameraPosition => default(Vector3);

	public bool isAnimating => false;

	public BlendSettings blendSettings => null;

	public Settings standardSettings => null;

	public bool isMoving => false;

	private float fovZoomMult => 0f;

	public Vector3 ScreenToViewPortPoint(Vector3 screenPoint)
	{
		return default(Vector3);
	}

	public Vector3 WorldToScreenPoint(Vector3 position)
	{
		return default(Vector3);
	}

	public Ray ScreenPointToRay(Vector3 position)
	{
		return default(Ray);
	}

	public bool isCameraCarCamera(Camera camera)
	{
		return false;
	}

	public Settings GetCarCamera(string name)
	{
		return null;
	}

	public static Settings CreateSettings(Camera camera)
	{
		return null;
	}

	public void Init(InputHandler inputHandler)
	{
	}

	public void SetUsedSettings(Settings settings)
	{
	}

	public void SetStandardSettings()
	{
	}

	public void AnimateIntoSettings(Settings newSettings)
	{
	}

	public void AnimateIntoSettings(AnimateIntoSettingsArguments arguments)
	{
	}

	public void AnimateIntoSettingsFromCamera(AnimateIntoSettingsArguments arguments)
	{
	}

	private IEnumerator DoAnimateIntoSettingsFromCamera(AnimateIntoSettingsArguments arguments)
	{
		return null;
	}

	private IEnumerator DoAnimateIntoSettings(AnimateIntoSettingsArguments arguments)
	{
		return null;
	}

	public void ChangeZoom(float pinchDelta)
	{
	}

	public void Move(Vector2 distance)
	{
	}

	private float FOVWithZoom(float fov)
	{
		return 0f;
	}

	private void UpdateCameraPosition()
	{
	}

	private void UpdateInertia()
	{
	}

	private void UpdateInputHandler()
	{
	}

	private void Update()
	{
	}
}
