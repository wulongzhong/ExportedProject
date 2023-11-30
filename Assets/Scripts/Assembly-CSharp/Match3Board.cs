using System.Collections.Generic;
using GGMatch3;

public class Match3Board
{
	public class MatchesInBoard
	{
		public int currentMove;

		public int matchesCount;

		public void AddMatch(int currentMoveIndex)
		{
		}
	}

	public class TimedCounter
	{
		public float timeLeft;

		public int eventCount;

		public void OnUserMadeMove()
		{
		}

		public void Update(float deltaTime)
		{
		}
	}

	public struct ChipCreateParams
	{
		public ChipType chipType;

		public ItemColor itemColor;

		public bool hasIce;

		public int iceLevel;
	}

	public MatchesInBoard matchesInBoard;

	public TimedCounter matchCounter;

	public GameStats gameStats;

	public FindMatches findMatches;

	public FindMatches findMatchesOutside;

	public PopulateBoard populateBoard;

	public PotentialMatches potentialMatches;

	public PowerupCombines powerupCombines;

	public PowerupActivations powerupActivations;

	public List<ItemColor> availableColors;

	public RandomProvider randomProvider;

	private List<ItemColor> selectedColors;

	private int maxSelectedColorCount;

	private int randomNumber;

	public LevelDefinition.ChipGenerationSettings generationSettings;

	public Slot[] slots;

	public List<Slot> sortedSlotsUpdateList;

	public List<BoardComponent> boardComponents;

	public BubblesBoardComponent bubblesBoardComponent;

	public IntVector2 size;

	public bool isGameEnded;

	public bool isBoardSettled;

	public bool isShufflingBoard;

	public int additionalMoves;

	public int collectedAdditionalMoves;

	public bool ignoreEndConditions;

	public bool isInteractionSuspended;

	public int powerupAnimationsInProgress;

	public bool isPowerupSelectionActive;

	public bool isEndConditionReached;

	public bool isUpdateSuspended;

	public bool isGameSoundsSuspended;

	public bool isAnyConveyorMoveSuspended;

	public int moveCountWhenConveyorTookAction;

	public ActionManager actionManager;

	public BurriedElements burriedElements;

	public MonsterElements monsterElements;

	public CarpetSpread carpet;

	public int generatedChipsCount;

	public bool hasMoreMoves;

	public ActionManager nonChangeStateActionMenager;

	public long currentFrameIndex;

	public float currentTime;

	public int userMovesCount;

	public int userScore;

	public int lastSettledMove;

	public long currentCoins;

	public float lastTimeWhenUserMadeMove;

	public long lastFrameWhenUserMadeMove;

	public int currentMatchesCount;

	public float currentDeltaTime;

	public bool isDirtyInCurrentFrame;

	public int currentMoveMatches => 0;

	public int totalAdditionalMoves => 0;

	public bool isInteractionSuspendedBecausePowerupAnimation => false;

	public void AddMatch()
	{
	}

	public void ResetMatchesInBoard()
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

	public ChipCreateParams RandomChip(GeneratorSlotSettings generationSettings)
	{
		return default(ChipCreateParams);
	}

	public ChipCreateParams RandomChip(ItemColor colorToIgnore = ItemColor.Unknown)
	{
		return default(ChipCreateParams);
	}

	public ItemColor RandomColor(ItemColor colorToIgnore = ItemColor.Unknown)
	{
		return default(ItemColor);
	}

	public void Add(BoardComponent boardComponent)
	{
	}

	public bool IsOutOfBoard(IntVector2 position)
	{
		return false;
	}

	public bool IsInBoard(IntVector2 position)
	{
		return false;
	}

	public int DistanceOutsideBoard(IntVector2 position)
	{
		return 0;
	}

	public void Init(IntVector2 size)
	{
	}

	public int Index(IntVector2 position)
	{
		return 0;
	}

	public IntVector2 PositionFromIndex(int index)
	{
		return default(IntVector2);
	}

	public void SetSlot(IntVector2 position, Slot slot)
	{
	}

	public Slot GetSlot(IntVector2 position)
	{
		return null;
	}
}
