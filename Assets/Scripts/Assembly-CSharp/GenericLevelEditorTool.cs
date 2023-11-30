using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GGMatch3;
using UnityEngine;
using UnityEngine.UI;

public class GenericLevelEditorTool : MonoBehaviour
{
	public enum Actions
	{
		SetChip = 0,
		DeleteSlot = 1,
		SetChain = 2,
		SetBox = 3,
		SetIce = 4,
		DeleteBurriedElement = 5,
		AddBurriedElement = 6,
		SetColorSlate = 7,
		AddGenerator = 8,
		RemoveGenerator = 9,
		FallingExit = 10,
		Carpet = 11,
		JumpSquare = 12,
		Conveyor = 13,
		Gravity = 14,
		Basket = 15,
		PortalEntrance = 16,
		PortalExit = 17,
		PortalRemove = 18,
		Wall = 19,
		GenerateFalling = 20,
		GeneratorTagChange = 21,
		ChipTagChange = 22,
		TutorialChange = 23,
		PredefinedElements = 24,
		Snow = 25
	}

	public enum Variant
	{
		Add = 0,
		Remove = 1
	}

	private sealed class _003CDoChangeSlotUserInteraction_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GenericLevelEditorTool _003C_003E4__this;

		public LevelDefinition.SlotDefinition slot;

		public InGameLevelEditorScreen screen;

		public LevelDefinition levelDef;

		private IEnumerator _003CuserChange_003E5__2;

		private IEnumerator _003CmenuChange_003E5__3;

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
		public _003CDoChangeSlotUserInteraction_003Ed__24(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public LevelDefinition levelDef;

		public LevelDefinition.SlotDefinition slot;

		public InGameLevelEditorScreen screen;

		public bool isSuccess;

		public Action<PanelMenuItem> _003C_003E9__1;

		internal void _003CLetUserChangePredefinedElements_003Eb__1(PanelMenuItem _003Cp0_003E)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_1
	{
		public GeneratorSetup generatorSetup;

		public bool isDone;

		public _003C_003Ec__DisplayClass26_0 CS_0024_003C_003E8__locals1;

		internal void _003CLetUserChangePredefinedElements_003Eb__5(PanelMenuItem _003Cp0_003E)
		{
		}

		internal void _003CLetUserChangePredefinedElements_003Eb__0(bool success)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_2
	{
		public List<GeneratorSetup.GeneratorChipSetup> chips;

		public _003C_003Ec__DisplayClass26_1 CS_0024_003C_003E8__locals2;

		internal void _003CLetUserChangePredefinedElements_003Eb__2(PanelMenuItem _003Cp0_003E)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_3
	{
		public int index;

		public _003C_003Ec__DisplayClass26_2 CS_0024_003C_003E8__locals3;

		internal void _003CLetUserChangePredefinedElements_003Eb__3(PanelMenuItem _003Cp0_003E)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_4
	{
		public ItemColor color;

		public _003C_003Ec__DisplayClass26_3 CS_0024_003C_003E8__locals4;

		internal void _003CLetUserChangePredefinedElements_003Eb__4(PanelMenuItem _003Cp0_003E)
		{
		}
	}

	private sealed class _003CLetUserChangePredefinedElements_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelDefinition levelDef;

		public LevelDefinition.SlotDefinition slot;

		public InGameLevelEditorScreen screen;

		private _003C_003Ec__DisplayClass26_0 _003C_003E8__1;

		private _003C_003Ec__DisplayClass26_1 _003C_003E8__2;

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
		public _003CLetUserChangePredefinedElements_003Ed__26(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public LevelDefinition levelDef;

		public InGameLevelEditorScreen screen;

		public LevelDefinition.SlotDefinition slot;

		public GenericLevelEditorTool _003C_003E4__this;

		public bool isSuccess;

		public Action<PanelMenuItem> _003C_003E9__7;

		internal void _003CLetUserChangeTutorial_003Eb__7(PanelMenuItem _003Cp0_003E)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_1
	{
		public bool isDone;

		public _003C_003Ec__DisplayClass27_0 CS_0024_003C_003E8__locals1;

		internal void _003CLetUserChangeTutorial_003Eb__0(bool success)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_2
	{
		public int index;

		public LevelDefinition.TutorialMatch item;

		public _003C_003Ec__DisplayClass27_1 CS_0024_003C_003E8__locals2;

		internal void _003CLetUserChangeTutorial_003Eb__1(PanelMenuItem _003Cp0_003E)
		{
		}

		internal void _003CLetUserChangeTutorial_003Eb__2(PanelMenuItem _003Cp0_003E)
		{
		}

		internal void _003CLetUserChangeTutorial_003Eb__3(PanelMenuItem _003Cp0_003E)
		{
		}

		internal void _003CLetUserChangeTutorial_003Eb__4(PanelMenuItem _003Cp0_003E)
		{
		}

		internal void _003CLetUserChangeTutorial_003Eb__5(PanelMenuItem _003Cp0_003E)
		{
		}

		internal void _003CLetUserChangeTutorial_003Eb__6(PanelMenuItem _003Cp0_003E)
		{
		}
	}

	private sealed class _003CLetUserChangeTutorial_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelDefinition levelDef;

		public InGameLevelEditorScreen screen;

		public LevelDefinition.SlotDefinition slot;

		public GenericLevelEditorTool _003C_003E4__this;

		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

		private _003C_003Ec__DisplayClass27_1 _003C_003E8__2;

		private MenuDialog _003CmenuDialog_003E5__2;

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
		public _003CLetUserChangeTutorial_003Ed__27(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public bool isDone;

		public GenericLevelEditorTool _003C_003E4__this;

		internal void _003CLetUserChangeUserSetCount_003Eb__0(int count)
		{
		}
	}

	private sealed class _003CLetUserChangeUserSetCount_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GenericLevelEditorTool _003C_003E4__this;

		public int initialCount;

		public string title;

		public Vector3 position;

		private _003C_003Ec__DisplayClass28_0 _003C_003E8__1;

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
		public _003CLetUserChangeUserSetCount_003Ed__28(int _003C_003E1__state)
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
	private Image background;

	[SerializeField]
	private Actions action;

	[SerializeField]
	private Variant variant;

	[SerializeField]
	private ChipType chipType;

	[SerializeField]
	private ItemColor itemColor;

	[SerializeField]
	private int level;

	[SerializeField]
	private int chipTag;

	[SerializeField]
	private IntVector2 direction;

	[SerializeField]
	private Image chipImage;

	private Action<GenericLevelEditorTool> onSelected;

	private IEnumerator enumAction;

	private bool isUserCountSet;

	private int userSetCount;

	public bool isRequeringPress => false;

	public bool isAbleToApplyToAll => false;

	public void ResetImage()
	{
	}

	public void Init(Action<GenericLevelEditorTool> onSelected)
	{
	}

	public void ButtonCallback_OnPressed()
	{
	}

	public void SetToolActive(bool active)
	{
	}

	public void ChangeSlotUserInteraction(LevelDefinition levelDefinition, LevelDefinition.SlotDefinition slot, InGameLevelEditorScreen screen)
	{
	}

	private IEnumerator DoChangeSlotUserInteraction(LevelDefinition levelDef, LevelDefinition.SlotDefinition slot, InGameLevelEditorScreen screen)
	{
		return null;
	}

	private void AddTutorial(LevelDefinition levelDef, InGameLevelEditorScreen screen)
	{
	}

	private IEnumerator LetUserChangePredefinedElements(LevelDefinition levelDef, LevelDefinition.SlotDefinition slot, InGameLevelEditorScreen screen)
	{
		return null;
	}

	private IEnumerator LetUserChangeTutorial(LevelDefinition levelDef, LevelDefinition.SlotDefinition slot, InGameLevelEditorScreen screen)
	{
		return null;
	}

	private IEnumerator LetUserChangeUserSetCount(string title, int initialCount, Vector3 position)
	{
		return null;
	}

	public bool ChangeSlot(LevelDefinition levelDef, LevelDefinition.SlotDefinition slot)
	{
		return false;
	}

	private List<IntVector2> PositionsUnderBurriedElement(LevelDefinition.BurriedElement burriedElement)
	{
		return null;
	}

	private bool SetBurriedElement(LevelDefinition level, LevelDefinition.BurriedElement burriedElement, bool addGrass)
	{
		return false;
	}

	private void Update()
	{
	}
}
