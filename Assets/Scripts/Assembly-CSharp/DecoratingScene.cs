using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DecoratingScene : MonoBehaviour
{
	[Serializable]
	public class GroupDefinition
	{
		[Serializable]
		public class AnimationDef
		{
			public string groupName;

			public string animationName;
		}

		public int groupIndex;

		public string title;

		public List<string> toSayAfterGroupCompletes;

		public AnimationDef playAfterFinish;
	}

	public enum ImagesFolderName
	{
		Folder_2048 = 0,
		Folder_1024 = 1
	}

	public struct RoomProgressState
	{
		public int completed;

		public int total;

		public bool isPassed => false;

		public float progress => 0f;

		public float Progress(int removeCompleted)
		{
			return 0f;
		}
	}

	private sealed class _003CDoZoomOutAnimation_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DecoratingScene _003C_003E4__this;

		private ConfirmPurchasePanel.Settings _003Csettings_003E5__2;

		private float _003Ctime_003E5__3;

		private Vector3 _003CstartScale_003E5__4;

		private Vector3 _003CstartPos_003E5__5;

		private Vector3 _003CendPos_003E5__6;

		private Vector3 _003CendScale_003E5__7;

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
		public _003CDoZoomOutAnimation_003Ed__78(int _003C_003E1__state)
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

	private sealed class _003CDoZoomInAnimation_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VisualObjectBehaviour visualObjectBehaviour;

		public DecoratingScene _003C_003E4__this;

		private ConfirmPurchasePanel.Settings _003Csettings_003E5__2;

		private float _003Ctime_003E5__3;

		private Vector3 _003CstartScale_003E5__4;

		private Vector3 _003CstartPos_003E5__5;

		private Vector3 _003CendPos_003E5__6;

		private Vector3 _003CendScale_003E5__7;

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
		public _003CDoZoomInAnimation_003Ed__79(int _003C_003E1__state)
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
	private List<GroupDefinition> groupDefinitions;

	[SerializeField]
	public List<VisualObjectBehaviour> visualObjectBehaviours;

	private List<VisualObjectBehaviour> activeBehaviours;

	public string sceneFolder;

	public string hierarchyJSONFile;

	public string hitboxJSONFile;

	public string metadataJSONFile;

	public string handlesJSONFile;

	public string dashLineJSONFile;

	[SerializeField]
	public bool shouldCreateCharacterScene;

	[SerializeField]
	public Transform rootTransform;

	[SerializeField]
	public RoomCharacterScene characterScene;

	[SerializeField]
	public CharacterAnimationPlayer animationPlayer;

	[SerializeField]
	public RoomSceneRenderObject roomSceneRender;

	[NonSerialized]
	public DecorateRoomScreen roomScreen;

	private Vector3 rootTransformOffset_;

	private Vector3 rootTransformOffsetAcceleration_;

	[SerializeField]
	public Transform offsetTransform;

	[SerializeField]
	public GraphicsSceneConfig config;

	public ImagesFolderName imagesFolder;

	public Color backgroundColor;

	public bool showCollisions;

	private IEnumerator animationEnum;

	private IEnumerator characterAnimationEnum;

	public int ownedItemsCount => 0;

	public DecoratingSceneConfig.AnimationSequence runningAnimation => null;

	public bool isCharacterAvailable => false;

	public Vector3 psdTransformationScale => default(Vector3);

	public Vector3 rootTransformScale
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 rootTransformOffset
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 rootTransformOffsetAcceleration
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	private Transform psdTransformationTransform => null;

	public string roomName => null;

	public RoomsBackend.RoomAccessor roomBackend => null;

	public GroupDefinition GetGroupForIndex(int index)
	{
		return null;
	}

	public GroupDefinition CurrentGroup()
	{
		return null;
	}

	public bool IsAllElementsPickedUpInGroup(int index)
	{
		return false;
	}

	public Vector3 CharacterBubblePosition(CharacterAvatar avatar)
	{
		return default(Vector3);
	}

	public List<DecoratingSceneConfig.AnimationSequence> GetAvailableSequences()
	{
		return null;
	}

	public void StopCharacterAnimation()
	{
	}

	public ChangeAnimationArguments AnimationForVisualBehaviour(VisualObjectBehaviour behaviour)
	{
		return default(ChangeAnimationArguments);
	}

	public void PlayCharacterAnimation(ChangeAnimationArguments arguments)
	{
	}

	public void SetCharacterAlpha(float alpha)
	{
	}

	public void SetCharacterAnimationAlpha(float alpha)
	{
	}

	public void AnimateCharacterAlphaTo(float alpha)
	{
	}

	private void SetRootTransform()
	{
	}

	public GraphicsSceneConfig CreateConfig()
	{
		return null;
	}

	public void ShowAll()
	{
	}

	public void ShowGroup(int groupIndex)
	{
	}

	public void DestroyCharacterScene()
	{
	}

	private void DestroyAllObjectBehaviours()
	{
	}

	private VisualObjectBehaviour CreateVisualObjectBehaviour(GraphicsSceneConfig.VisualObject vo)
	{
		return null;
	}

	public void CreateSceneBehaviours(GraphicsSceneConfig config)
	{
	}

	public RoomProgressState GetRoomProgressState()
	{
		return default(RoomProgressState);
	}

	public VisualObjectBehaviour GetBehaviour(string name)
	{
		return null;
	}

	public Vector3 PSDToWorldPoint(Vector2 point)
	{
		return default(Vector3);
	}

	public Vector3 WorldToPSDPoint(Vector2 point)
	{
		return default(Vector3);
	}

	public void ResetZoomIn()
	{
	}

	public void InitRuntimeData()
	{
	}

	public void Init(Camera mainCamera, float additionalMargin, DecorateRoomScreen roomScreen)
	{
	}

	public void ZoomIn(VisualObjectBehaviour visualObjectBehaviour)
	{
	}

	public void ZoomOut()
	{
	}

	private IEnumerator DoZoomOutAnimation()
	{
		return null;
	}

	private IEnumerator DoZoomInAnimation(VisualObjectBehaviour visualObjectBehaviour)
	{
		return null;
	}

	private void ScaleToFitInCamera(Camera mainCamera, float additionalMargin)
	{
	}

	private void Update()
	{
	}
}
