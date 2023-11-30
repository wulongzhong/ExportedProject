using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using EZCameraShake;
using GGMatch3;
using UnityEngine;

public class Match3Game : MonoBehaviour
{
	[Serializable]
	public class DifficultyChanger
	{
		[Serializable]
		public class MaterialChange
		{
			[SerializeField]
			public Match3StagesDB.Stage.Difficulty difficulty;

			[SerializeField]
			private Material material;

			[SerializeField]
			private MeshRenderer renderer;

			public void Change()
			{
			}
		}

		[SerializeField]
		private List<MaterialChange> changes;

		public void Apply(Match3StagesDB.Stage.Difficulty difficulty)
		{
		}
	}

	[Serializable]
	public class PieceCreatorPool
	{
		public PieceType type;

		public List<ChipType> chipTypeList;

		public List<ItemColor> itemColorList;

		public ComponentPool pool;
	}

	public interface IAffectorExportAction
	{
		void Execute();

		void OnCancel();
	}

	public class InputAffectorExport
	{
		public class InputAffectorForSlot
		{
			public Slot slot;

			public List<LightingBolt> bolts;

			public void Clear()
			{
			}

			public void PutAllBoltsIn(BoltCollection boltCollection)
			{
			}

			public LightingBolt GetLigtingBoltForSlots(IntVector2 startPosition, IntVector2 endPosition)
			{
				return null;
			}
		}

		private List<IAffectorExportAction> actions;

		private List<ChipAffectorBase> chipAffectors;

		public List<InputAffectorForSlot> affectorExports;

		public bool hasActions => false;

		public void AddChipAffector(ChipAffectorBase chipAffector)
		{
		}

		public void ExecuteOnAfterDestroy()
		{
		}

		public void AddAction(IAffectorExportAction action)
		{
		}

		public void ExecuteActions()
		{
		}

		public LightingBolt GetLigtingBoltForSlots(IntVector2 startPosition, IntVector2 endPosition)
		{
			return null;
		}

		public InputAffectorForSlot GetInputAffectorForSlot(Slot slot)
		{
			return null;
		}

		public void Clear()
		{
		}
	}

	public struct SwitchSlotsArguments
	{
		public IntVector2 pos1;

		public IntVector2 pos2;

		public bool instant;

		public List<LightingBolt> bolts;

		public float affectorDuration;

		public bool isAlreadySwitched;

		private InputAffectorExport affectorExport_;

		public InputAffectorExport affectorExport => null;

		public void Clear()
		{
		}
	}

	public struct StartGameArguments
	{
		public bool putBoosters;
	}

	public class TutorialMatchProgress
	{
		public LevelDefinition.TutorialMatch tutorialMatch;

		public bool isStarted;
	}

	[Serializable]
	public class TutorialSlotHighlighter
	{
		[SerializeField]
		private TilesBorderRenderer tilesMaskRenderer;

		[SerializeField]
		private TilesBorderRenderer borderMaskRenderer;

		[SerializeField]
		private TilesBorderRenderer borderRenderer;

		[SerializeField]
		private Transform tutorialBackground;

		[NonSerialized]
		private GameScreen gameScreen;

		public void Init(GameScreen gameScreen)
		{
		}

		public void SetTutorialBackgroundActive(bool active)
		{
		}

		public void ShowGameScreenTutorialMask()
		{
		}

		public void Show(TilesSlotsProvider provider)
		{
		}

		public void Hide()
		{
		}

		private void SetActive(bool flag)
		{
		}
	}

	public struct CreateBoardArguments
	{
		public LevelDefinition level;

		public Vector3 offset;
	}

	protected struct PotentialMatch
	{
		public ActionScore actionScore;

		public PowerupCombines.PowerupCombine powerupCombine;

		public PowerupActivations.PowerupActivation powerupActivation;

		public PotentialMatches.CompoundSlotsSet potentialMatch;

		public ActionScore powerupCreatedScore;

		public bool isActive => false;

		public int ScoreWithPowerupScore(int currentScoreFactor, int goalsFactor)
		{
			return 0;
		}

		//public PotentialMatch(PowerupCombines.PowerupCombine powerupCombine, ActionScore actionScore)
		//{
		//}

		//public PotentialMatch(PowerupActivations.PowerupActivation powerupActivation, ActionScore actionScore)
		//{
		//}

		//public PotentialMatch(PotentialMatches.CompoundSlotsSet potentialMatch, ActionScore actionScore, ActionScore powerupCreatedScore)
		//{
		//}
	}

	private struct SlotDestroyNeighbour
	{
		public Slot slotBeingDestroyed;

		public Slot neighbourSlot;

		//public SlotDestroyNeighbour(Slot slotBeingDestroyed, Slot neighbourSlot)
		//{
		//}
	}

	public class MaximumColorHelper
	{
		public struct Color
		{
			public ItemColor color;

			public int count;
		}

		private List<Color> colorList;

		public Color MaxColor => default(Color);

		public void Clear()
		{
		}

		private void AddColor(ItemColor color)
		{
		}

		public void AddSlot(Slot slot, bool replaceWithBombs)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Slot> _003C_003E9__125_0;

		internal int _003CCreateBoard_003Eb__125_0(Slot x, Slot y)
		{
			return 0;
		}
	}

	private sealed class _003CDoShuffleBoardAnimation_003Ed__196 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Match3Game _003C_003E4__this;

		private IEnumerator _003CshuffleInAnimation_003E5__2;

		private float _003Ctime_003E5__3;

		private float _003Cduration_003E5__4;

		private IEnumerator _003CoutAnimation_003E5__5;

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
		public _003CDoShuffleBoardAnimation_003Ed__196(int _003C_003E1__state)
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

	private sealed class _003CDoStartInAnimation_003Ed__241 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Match3Game _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private WinScreenBoardInAnimation _003Csettings_003E5__3;

		private float _003Cduration_003E5__4;

		private Transform _003Ct_003E5__5;

		private Vector3 _003CendPos_003E5__6;

		private Vector3 _003CstartPos_003E5__7;

		private Vector3 _003CendScale_003E5__8;

		private Vector3 _003CstartScale_003E5__9;

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
		public _003CDoStartInAnimation_003Ed__241(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass244_0
	{
		public bool isWellDoneDone;

		public Match3Game _003C_003E4__this;

		public Action onComplete;

		internal void _003CDoWinAnimation_003Eb__1()
		{
		}

		internal void _003CDoWinAnimation_003Eb__0()
		{
		}
	}

	private sealed class _003CDoWinAnimation_003Ed__244 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Match3Game _003C_003E4__this;

		public Action onComplete;

		public WinScreen.InitArguments winScreenArguments;

		private _003C_003Ec__DisplayClass244_0 _003C_003E8__1;

		private int _003CcoinsPerMove_003E5__2;

		private int _003CadditionalCoins_003E5__3;

		private int _003CmovesRemaining_003E5__4;

		private List<Chip> _003CpowerupChips_003E5__5;

		private float _003Ctime_003E5__6;

		private float _003CmaxDuration_003E5__7;

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
		public _003CDoWinAnimation_003Ed__244(int _003C_003E1__state)
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

	private sealed class _003CDoWinScreenBoardOutAnimation_003Ed__246 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Match3Game _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private WinScreenBoardOutAnimation _003Csettings_003E5__3;

		private float _003Cduration_003E5__4;

		private Transform _003Ct_003E5__5;

		private Vector3 _003CstartPos_003E5__6;

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
		public _003CDoWinScreenBoardOutAnimation_003Ed__246(int _003C_003E1__state)
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

	public float timeScale;

	private HeuristicAIPlayer aiPlayer;

	public string levelName;

	private long startTimestampTicks;

	private long endTimestampTicks;

	[NonSerialized]
	public LevelDefinition level;

	private bool gameStarted;

	private bool preventAutomatchesIfPossible_;

	private List<BuyMovesPricesConfig.OfferConfig> moveOffersBought;

	[NonSerialized]
	public GameScreen gameScreen;

	[SerializeField]
	private DifficultyChanger difficultyChanger;

	[SerializeField]
	private CameraShaker cameraShaker;

	[SerializeField]
	public PlayerInput input;

	[SerializeField]
	public SlotsRendererPool slotsRendererPool;

	[SerializeField]
	public Match3Particles particles;

	[SerializeField]
	private TilesBorderRenderer borderRenderer;

	[SerializeField]
	private HiddenElementBorderRenderer hiddenElementBorderRenderer;

	[SerializeField]
	private SnowCoverBorderRenderer snowCoverRenderer;

	[SerializeField]
	private BubbleSlotsBorderRenderer bubbleSlotsBorderRenderer;

	[SerializeField]
	private TilesBorderRenderer slotsRenderer;

	[SerializeField]
	private TilesBorderRenderer conveyorBorderRenderer;

	[SerializeField]
	private BorderTilemapRenderer conveyorHoleRenderer;

	[SerializeField]
	private TilesBorderRenderer conveyorSlotsRenderer;

	[SerializeField]
	private ChocolateBorderRenderer chocolateBorderRenderer;

	[SerializeField]
	public TutorialSlotHighlighter tutorialHighlighter;

	[SerializeField]
	public Transform boardContainer;

	public Vector2 slotPhysicalSize;

	private ShowPotentialMatchAction showMatchAction;

	public float gravity;

	[SerializeField]
	private List<PieceCreatorPool> pieceCreatorPools;

	private List<Slot> affectingList;

	[NonSerialized]
	public Match3Board board;

	[NonSerialized]
	public Match3Goals goals;

	[NonSerialized]
	public ExtraFallingChips extraFallingChips;

	[NonSerialized]
	public Match3GameParams initParams;

	private StartGameArguments startGameArguments;

	private List<TutorialMatchProgress> tutorialMatchProgressList;

	private ShowTutorialMaskAction tutorialAction;

	public CreateBoardArguments createBoardArguments;

	private List<IntVector2> wallDirections;

	private IEnumerator shuffleBoardAnimation;

	public Dictionary<ItemColor, int> attachedElementsPerItemColor;

	private List<PotentialMatches.CompoundSlotsSet.MatchType> matchTypeToFind;

	private List<PowerupCombines.CombineType> combineTypeToFind;

	private List<Slot> discoBallSlots;

	protected List<PotentialMatch> potentialMatchesList;

	private bool isWellDoneShown;

	private bool isWellDoneShownDone;

	private int movesSettledCount;

	private IEnumerator animationEnum;

	private List<Slot> allNeighbourSlots;

	private List<SlotDestroyNeighbour> destroyNeighbourSlots;

	private MaximumColorHelper maxColorHelper;

	public bool preventAutomatchesIfPossible => false;

	public bool strictAsPossibleToprevent => false;

	public long totalTimePlayed => 0L;

	public int timesBoughtMoves => 0;

	public int totalCoinsSpent => 0;

	public long timePlayed => 0L;

	public Match3Settings settings => null;

	public float boardContainerScale => 0f;

	public Vector3 bottomLeft => default(Vector3);

	public int SeekingMissleCrossRadius => 0;

	public bool isHudEnabled => false;

	private bool isTutorialActive => false;

	private SuggestMoveType suggestMoveType => default(SuggestMoveType);

	private ShowPotentialMatchSetting showPotentialMatchSetting => default(ShowPotentialMatchSetting);

	public Vector2 BoardWorldSize => default(Vector2);

	public Vector2 PlayAreaWorldSize => default(Vector2);

	public bool isUserInteractionSuspended => false;

	public bool isBubblesSuspended => false;

	public bool isConveyorSuspended => false;

	public bool isOutOfMoves => false;

	public bool hasPlayedAnyMoves => false;

	public bool isConveyorMoving => false;

	public bool isBoardFullySettled => false;

	public bool isAnySlotMoving => false;

	public int TotalSlotsGoalsRemainingCount => 0;

	public bool IsPreventAutomatedMachesIfPossible()
	{
		return false;
	}

	public Vector3 WorldToBoardPosition(Vector3 worldPosition)
	{
		return default(Vector3);
	}

	public Vector3 LocalToWorldPosition(Vector3 localPosition)
	{
		return default(Vector3);
	}

	public ComponentPool GetPool(PieceType type)
	{
		return null;
	}

	public ComponentPool GetPool(PieceType type, ChipType chipType, ItemColor itemColor)
	{
		return null;
	}

	public List<Slot> GetCross(IntVector2 centerPos, int radius)
	{
		return null;
	}

	public List<Slot> GetSeekingMissleArea(IntVector2 centerPos)
	{
		return null;
	}

	public List<Slot> GetCrossArea(IntVector2 centerPos, int maxRadius)
	{
		return null;
	}

	public List<Slot> GetAreaOfEffect(ChipType chipType, IntVector2 centerPos)
	{
		return null;
	}

	public List<Slot> GetBombArea(IntVector2 centerPos, int maxRadius)
	{
		return null;
	}

	public List<Slot> GetArea(IntVector2 centerPos, int maxRadius)
	{
		return null;
	}

	public List<Slot> GetAllPlayingSlots()
	{
		return null;
	}

	public List<Slot> GetVerticalLine(IntVector2 centerPos)
	{
		return null;
	}

	public List<Slot> GetHorizontalLine(IntVector2 centerPos)
	{
		return null;
	}

	public ComponentPool GetPool(PieceType type, ChipType chipType)
	{
		return null;
	}

	public Slot GetSlot(IntVector2 position)
	{
		return null;
	}

	public void Play(GGSoundSystem.SFXType sound)
	{
	}

	public void Play(GGSoundSystem.PlayParameters sound)
	{
	}

	public void TapOnSlot(IntVector2 pos1, SwapParams swapParams = null)
	{
	}

	public bool TrySwitchSlots(Slot slot1, Slot slot2, bool instant)
	{
		return false;
	}

	public bool TrySwitchSlots(IntVector2 pos1, IntVector2 pos2, bool instant)
	{
		return false;
	}

	public void TryShowSwitchNotPossible(IntVector2 pos1, IntVector2 pos2)
	{
	}

	private void TryShowSwitchNotPossible(SwitchSlotsArguments arguments)
	{
	}

	public bool TrySwitchSlots(SwitchSlotsArguments arguments)
	{
		return false;
	}

	public int SlotsDistanceToEndOfBoard(IntVector2 pos, IntVector2 direction)
	{
		return 0;
	}

	public Vector3 LocalPositionOfCenter(IntVector2 position)
	{
		return default(Vector3);
	}

	public IntVector2 BoardPositionFromLocalPosition(Vector3 position)
	{
		return default(IntVector2);
	}

	public IntVector2 BoardPositionFromLocalPositionRound(Vector3 position)
	{
		return default(IntVector2);
	}

	public IntVector2 ClosestBoardPositionFromLocalPosition(Vector3 position)
	{
		return default(IntVector2);
	}

	public void SetHasBounceOnAllChips(bool hasBounce)
	{
	}

	private TutorialMatchProgress GetOrCreateTutorialMatchProgress(LevelDefinition.TutorialMatch tutorialMatch)
	{
		return null;
	}

	public void UpdateTutorialMatches(bool isBoardSettled)
	{
	}

	private void OnLastTutorialEnd()
	{
	}

	private void OnTutorialMiddle()
	{
	}

	private void OnTutorialEnd()
	{
	}

	public void ShakeCamera(GeneralSettings.CameraShakeSettings shakeSettings)
	{
	}

	public void ShakeCamera()
	{
	}

	public void StartGame(StartGameArguments arguments)
	{
	}

	private void PutBoosters(StartGameArguments arguments)
	{
	}

	public void Init(Camera mainCamera, GameScreen gameScreen, Match3GameParams initParams)
	{
	}

	public void Callback_ShowActivatePowerup(PowerupsDB.PowerupDefinition powerup)
	{
	}

	private void Callback_OnPlacePowerup(PowerupPlacementHandler.PlacementCompleteArguments completeArguments)
	{
	}

	private void Callback_OnBuyPowerupComplete(bool success)
	{
	}

	public void CreateBoard(LevelDefinition level)
	{
	}

	public void SetStageDifficulty(Match3StagesDB.Stage.Difficulty difficulty)
	{
	}

	public void CreateBoard(CreateBoardArguments arguments)
	{
	}

	private void AddSlotColorSlot(Slot slot, LevelDefinition.SlotDefinition slotDef)
	{
	}

	public void AddBurriedElementSlot(Slot slot, LevelDefinition.BurriedElement burriedElement)
	{
	}

	private void AddConveyorBelt(LevelDefinition.ConveyorBelt conveyorBelt, int index)
	{
	}

	private void AddBckLightToSlot(Slot slot)
	{
	}

	private void AddLightToSlot(Slot slot, LevelDefinition.SlotDefinition slotDef)
	{
	}

	private void AddJumpRampToSlot(Slot slot)
	{
	}

	private void AddFallingElementExitToSlot(Slot slot)
	{
	}

	private void AddWallToSlot(Slot slot, LevelDefinition.SlotDefinition slotDef)
	{
	}

	private void AddChainToSlot(Slot slot, LevelDefinition.SlotDefinition slotDef)
	{
	}

	private void AddIceToSlot(Slot slot, LevelDefinition.SlotDefinition slotDef)
	{
	}

	public void AddIceToSlot(Slot slot, int iceLevel)
	{
	}

	private void AddBasketToSlot(Slot slot, LevelDefinition.SlotDefinition slotDef)
	{
	}

	public void AddBubblesToSlot(Slot slot)
	{
	}

	public void AddSnowCoverToSlot(Slot slot)
	{
	}

	private void AddBoxToSlot(Slot slot, LevelDefinition.SlotDefinition slotDef, LevelDefinition level)
	{
	}

	private void AddNetToSlot(Slot slot, LevelDefinition.SlotDefinition slotDef)
	{
	}

	private void AddSpecialGenerator(Slot slot)
	{
	}

	public GrowingElementChip CreateGrowingElement(Slot slot, LevelDefinition.SlotDefinition slotDefinition)
	{
		return null;
	}

	public TransformBehaviour CreatePieceTypeBehaviour(ChipType chipType)
	{
		return null;
	}

	public TransformBehaviour CreateGrowingElementPieceBehaviour()
	{
		return null;
	}

	public MonsterElementBehaviour CreateMonsterElementBehaviour()
	{
		return null;
	}

	public FlyingSaucerBehaviour CreateFlyingSaucer()
	{
		return null;
	}

	public void CreateEmptyConveyorSpace(Slot slot)
	{
	}

	public void CreateConveyorBeltPlate(Slot slot)
	{
	}

	public MagicHat CreateMagicHat(Slot slot)
	{
		return null;
	}

	public MagicHatBomb CreateMagicHatBomb(Slot slot, LevelDefinition.SlotDefinition slotDefinition)
	{
		return null;
	}

	public HammerAnimationBehaviour CreateHammerAnimationBehaviour()
	{
		return null;
	}

	public CarpetSpreadBehaviour CreateCarpetSpread()
	{
		return null;
	}

	public BurriedElementBehaviour CreateBurriedElement()
	{
		return null;
	}

	public Chip CreateFallingElement(Slot slot, ChipType chipType)
	{
		return null;
	}

	public RockBlocker CreateRockBlocker(Slot slot, LevelDefinition.SlotDefinition slotDefinition)
	{
		return null;
	}

	public Chip CreateCharacterInSlot(Slot slot, ChipType chipType, int itemLevel)
	{
		return null;
	}

	public LightingBolt CreateLightingBolt()
	{
		return null;
	}

	public TransformBehaviour CreateChipFeather(Slot slot, ItemColor itemColor)
	{
		return null;
	}

	public LightingBolt CreateLightingBoltChip()
	{
		return null;
	}

	public LightingBolt CreateLightingBoltPowerup()
	{
		return null;
	}

	public Chip CreateMoreMovesChip(Slot slot, LevelDefinition.SlotDefinition slotDef)
	{
		return null;
	}

	public Chip CreateCharacterInSlot(Slot slot, LevelDefinition.SlotDefinition slotDef)
	{
		return null;
	}

	public void AddPipe(Slot slot, bool isExit, int index)
	{
	}

	public PipeBehaviour CreatePipeDontAddToSlot()
	{
		return null;
	}

	public MovingElement CreateMovingElementInSlot(Slot slot)
	{
		return null;
	}

	public TransformBehaviour CreateCoin()
	{
		return null;
	}

	public TransformBehaviour CreatePointsDisplay()
	{
		return null;
	}

	public Chip CreateChipInSlot(Slot slot, ChipType chipType, ItemColor itemColor)
	{
		return null;
	}

	public Chip CreateChipInSlot(Slot slot, ItemColor itemColor)
	{
		return null;
	}

	public Chip CreatePowerupInSlot(Slot slot, ChipType chipType)
	{
		return null;
	}

	public GameObject CreateParticles(Chip chip, PieceType pieceType, ChipType chipType, ItemColor itemColor)
	{
		return null;
	}

	public RocketPieceBehaviour CreateRocketPiece()
	{
		return null;
	}

	public void ApplySlotGravityForAllSlots()
	{
	}

	private void Update()
	{
	}

	private void StepSymulation(float deltaTime, int iteration)
	{
	}

	private IEnumerator DoShuffleBoardAnimation()
	{
		return null;
	}

	private void ShuffleBoard()
	{
	}

	private void UpdateBoardShuffle()
	{
	}

	public Slot LastSlotOnDirection(Slot origin, IntVector2 direction)
	{
		return null;
	}

	public Slot FirstSlotOnDirection(IntVector2 position, IntVector2 direction)
	{
		return null;
	}

	public List<Slot> SlotsInDiscoBallDestroy(ItemColor itemColor, bool replaceWithBombs)
	{
		return null;
	}

	private bool IsBetter(PotentialMatch a, PotentialMatch b)
	{
		return false;
	}

	private bool IsBetter(ActionScore a, ActionScore b)
	{
		return false;
	}

	private PowerupActivations.PowerupActivation SelectPowerupActivation(Match3Goals goals, PowerupActivations powerupActivations)
	{
		return null;
	}

	private PowerupCombines.PowerupCombine SelectPowerupCombine(Match3Goals goals, PowerupCombines powerupCombines)
	{
		return null;
	}

	private PotentialMatches.CompoundSlotsSet SelectPotentialMatch(Match3Goals goals, PotentialMatches potentialMatches)
	{
		return null;
	}

	private void CheckEndGameConditions()
	{
	}

	private void EndGame(bool isWin)
	{
	}

	public void ResumeGame()
	{
	}

	public void SuspendGameSounds()
	{
	}

	public void SuspendGame()
	{
	}

	public void QuitGame()
	{
	}

	public void ContinueGameAfterOffer(BuyMovesPricesConfig.OfferConfig offer)
	{
	}

	public void OnSlotSetDirty(Slot slot)
	{
	}

	public void OnPickupGoal(GoalCollectParams goalCollect)
	{
	}

	public void OnScoreAdded(int score)
	{
	}

	public void OnUserMadeMove()
	{
	}

	private void TryHighlightGoals()
	{
	}

	private void HighlightGoal(Match3Goals.GoalBase goal)
	{
	}

	private void HighlightAllGoals()
	{
	}

	private PotentialMatch GetMatchingPotentialMatchAction()
	{
		return default(PotentialMatch);
	}

	private List<PotentialMatch> FillPotentialMatchesWithScore(bool addPowerupCombines, bool addPowerupActivations, bool onlyBestPowerups)
	{
		return null;
	}

	private PotentialMatch GetBestPotentialMatch(List<PotentialMatch> potentialMatchesList)
	{
		return default(PotentialMatch);
	}

	private PotentialMatch GetBestPotentialMatchAction()
	{
		return default(PotentialMatch);
	}

	private void OnMoveSettled()
	{
	}

	public void OnCollectCoin()
	{
	}

	public void OnCollectedMoreMoves(int count)
	{
	}

	public void ProcessMatches(Matches m, SwapParams swapParams)
	{
	}

	public void StartInAnimation()
	{
	}

	private IEnumerator DoStartInAnimation()
	{
		return null;
	}

	public void StartWinAnimation(WinScreen.InitArguments winScreenArguments, Action onComplete)
	{
	}

	private int CoinsPerChipType(ChipType chipType, int coinsPerPowerup)
	{
		return 0;
	}

	private IEnumerator DoWinAnimation(WinScreen.InitArguments winScreenArguments, Action onComplete)
	{
		return null;
	}

	public void StartWinScreenBoardAnimation()
	{
	}

	private IEnumerator DoWinScreenBoardOutAnimation()
	{
		return null;
	}

	private bool ProcessIsland(Island island, SwapParams swapParams)
	{
		return false;
	}

	public void FinishDestroySlots(DestroyMatchingIslandAction.InitArguments arguments)
	{
	}

	public List<Slot> SlotsThatCanParticipateInDiscoBallAffectedArea(ItemColor itemColor, bool replaceWithBombs)
	{
		return null;
	}

	public ItemColor BestItemColorForDiscoBomb(bool replaceWithBombs)
	{
		return default(ItemColor);
	}

	public void ClearSlotLocks()
	{
	}

	public void AddLockToAllSlots(Lock slotLock)
	{
	}

	public int RandomRange(int min, int max)
	{
		return 0;
	}

	public float RandomRange(float min, float max)
	{
		return 0f;
	}

	public void RemoveLockFromAllSlots(Lock slotLock)
	{
	}

	public void Leave1Move()
	{
	}

	private void _003CPutBoosters_003Eb__108_0()
	{
	}
}
