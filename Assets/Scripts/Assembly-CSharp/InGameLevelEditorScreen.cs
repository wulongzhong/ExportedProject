using System;
using System.Collections.Generic;
using GGMatch3;
using TMPro;
using UnityEngine;

public class InGameLevelEditorScreen : MonoBehaviour, Match3GameListener
{
	public class State
	{
		public LevelDefinition level;

		public SavedLevel savedLevel;

		public string savedLevelPath;

		public List<LevelDefinition> undo;

		public List<LevelDefinition> redo;

		public GenericLevelEditorTool lastUsedTool;

		public IntVector2 lastUsedPosition;
	}

	public class LevelPayload
	{
		public LevelDefinition levelDefinition;

		public string path;

		public SavedLevel savedLevel => null;

		public LevelDefinition level => null;

		public LevelPayload(string path)
		{
		}

		public LevelPayload(LevelDefinition levelDefinition)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass65_0
	{
		public NavigationManager nav;

		public InGameLevelEditorScreen _003C_003E4__this;

		public List<Match3StagesDB.Stage> stages;

		internal void _003CButtonCallback_Publish_003Eb__0(SaveListDialog.DialogResult result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass66_0
	{
		public NavigationManager nav;

		public InGameLevelEditorScreen _003C_003E4__this;

		internal void _003CButtonCallback_SaveFile_003Eb__0(SaveListDialog.DialogResult result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass66_1
	{
		public SavedLevel newSavedLevel;

		public _003C_003Ec__DisplayClass66_0 CS_0024_003C_003E8__locals1;

		internal void _003CButtonCallback_SaveFile_003Eb__1(bool success)
		{
		}
	}

	[SerializeField]
	private string levelToOpen;

	[SerializeField]
	private Camera mainCamera;

	[SerializeField]
	private ComponentPool slotPool;

	[SerializeField]
	private ComponentPool burriedElementPool;

	[SerializeField]
	private RectTransform container;

	[SerializeField]
	private RectTransform innerContainer;

	[SerializeField]
	private Transform toolsContainer;

	[SerializeField]
	private int maxUndo;

	[SerializeField]
	private TextMeshProUGUI redoCount;

	[SerializeField]
	private TextMeshProUGUI undoCount;

	[SerializeField]
	private TextMeshProUGUI autosaveText;

	[SerializeField]
	private RectTransform levelContainerEdge;

	[SerializeField]
	private Transform toolFollower;

	[SerializeField]
	private Transform toolFollowerInner;

	[SerializeField]
	private LevelEditorGoalsPanel goalsPanel;

	[NonSerialized]
	private GameObject activeToolInFollower;

	[NonSerialized]
	private List<GenericLevelEditorTool> tools;

	[NonSerialized]
	private GenericLevelEditorTool activeTool;

	[SerializeField]
	public MainConfig mainConfig;

	[NonSerialized]
	private State state;

	private Vector3[] localCorners;

	public LevelDefinition level => null;

	private void OnEnable()
	{
	}

	private void OnRectTransformDimensionsChange()
	{
	}

	private void SetActiveTool(GenericLevelEditorTool activeTool)
	{
	}

	public void ShowLevel(State state)
	{
	}

	private void Callback_OnPressed(LevelEditorSlot levelEditorSlot)
	{
	}

	public void RegisterUndo()
	{
	}

	private void RegisterUndo(LevelDefinition prevLevel)
	{
	}

	private void ApplyActiveToolOnWholeLevel()
	{
	}

	private void ApplyActiveToolOnPosition(IntVector2 position)
	{
	}

	public void OnToolChangedSlot(LevelDefinition newLevel, LevelDefinition.SlotDefinition slot, bool changed)
	{
	}

	public void OnChange()
	{
	}

	public void Callback_ApplyToAll()
	{
	}

	public void Callback_OnUndo()
	{
	}

	public void Callback_Redo()
	{
	}

	private void Update()
	{
	}

	private void UpdateMousePosition()
	{
	}

	public void Callback_TopAddColumn()
	{
	}

	public void Callback_TopRemoveColumn()
	{
	}

	public void Callback_BottomAddColumn()
	{
	}

	public void Callback_BottomRemoveColumn()
	{
	}

	public void Callback_LeftAddColumn()
	{
	}

	public void Callback_LeftRemoveColumn()
	{
	}

	public void Callback_RightAddColumn()
	{
	}

	public void Callback_RightRemoveColumn()
	{
	}

	private void ChangeLevelSize(IntVector2 sizeAdd, IntVector2 offset)
	{
	}

	private void CopyWithOffset(List<LevelDefinition.SlotDefinition> copyFrom, LevelDefinition level, IntVector2 offset)
	{
	}

	public bool IsWorldToPositionOnBoard(Vector3 wordPos, LevelDefinition level)
	{
		return false;
	}

	public Vector3 GetLocalPosition(LevelDefinition level, IntVector2 position)
	{
		return default(Vector3);
	}

	public Vector3 GetWorldPosition(LevelDefinition level, IntVector2 position)
	{
		return default(Vector3);
	}

	public IntVector2 WorldToBoardPosition(Vector3 wordPos, LevelDefinition level)
	{
		return default(IntVector2);
	}

	public void PlayGame()
	{
	}

	public void OnGameComplete(GameCompleteParams completeParams)
	{
	}

	public void OnGameStarted(GameStartedParams startedParams)
	{
	}

	public void StopGame()
	{
	}

	private void Callback_OnLevelSettingsDialogComplete(LevelSettingsDialog dialog, bool success)
	{
	}

	public void ButtonCallback_Settings()
	{
	}

	private List<OpenListDialog.ListItem> CreateSublistFromLevelDB(OpenListDialog.ListItem listItem)
	{
		return null;
	}

	private List<OpenListDialog.ListItem> CreateSublistFromStages(OpenListDialog.ListItem listItem)
	{
		return null;
	}

	private List<OpenListDialog.ListItem> CreateSublistFromPath(OpenListDialog.ListItem listItem)
	{
		return null;
	}

	public void ButtonCallback_OpenFile()
	{
	}

	public void ButtonCallback_Publish()
	{
	}

	public void ButtonCallback_SaveFile()
	{
	}

	private void _003CButtonCallback_OpenFile_003Eb__64_0(OpenMultipleListDialog dialog, bool success)
	{
	}
}
