using System;
using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	[Serializable]
	public class LevelDefinition
	{
		[Serializable]
		public class BurriedElement
		{
			public enum Orientation
			{
				Horizontal = 0,
				Vertical = 1
			}

			public IntVector2 position;

			public IntVector2 size;

			public Orientation orientation;

			public IntVector2 oppositeCornerPosition => default(IntVector2);

			public bool ContainsPosition(IntVector2 positionToCheck)
			{
				return false;
			}

			public bool IsEqualTo(BurriedElement element)
			{
				return false;
			}

			public BurriedElement Clone()
			{
				return null;
			}
		}

		[Serializable]
		public class MonsterElement
		{
			public IntVector2 position;

			public IntVector2 size;

			public ItemColor itemColor;

			public int numberToCollect;

			public IntVector2 oppositeCornerPosition => default(IntVector2);

			public bool ContainsPosition(IntVector2 positionToCheck)
			{
				return false;
			}

			public bool IsEqualTo(MonsterElement e)
			{
				return false;
			}

			public MonsterElement Clone()
			{
				return null;
			}
		}

		[Serializable]
		public class BurriedElements
		{
			public List<BurriedElement> elements;

			public int CountAllElements()
			{
				return 0;
			}

			public bool IsEqualTo(BurriedElements e)
			{
				return false;
			}

			public void MoveByOffset(IntVector2 offset)
			{
			}

			public List<BurriedElement> ElementsUnderPosition(IntVector2 position)
			{
				return null;
			}

			public bool HasElementsUnderPosition(IntVector2 position)
			{
				return false;
			}

			public BurriedElements Clone()
			{
				return null;
			}
		}

		[Serializable]
		public class MonsterElements
		{
			public List<MonsterElement> elements;

			public void MoveByOffset(IntVector2 offset)
			{
			}

			public bool HasElementsUnderPosition(IntVector2 position)
			{
				return false;
			}

			public bool IsEqualTo(MonsterElements e)
			{
				return false;
			}

			public MonsterElements Clone()
			{
				return null;
			}
		}

		[Serializable]
		public class Size
		{
			public int width;

			public int height;

			public Size Clone()
			{
				return null;
			}

			public bool IsEqualTo(Size s)
			{
				return false;
			}
		}

		[Serializable]
		public class GeneratorSettings
		{
			public bool isGeneratorOn;

			public bool generateOnlyBunnies;

			public int maxFallingElementsToGenerate;

			public int chipTag;

			public int slotGeneratorSetupIndex;

			public GeneratorSettings Clone()
			{
				return null;
			}

			public bool IsEqualTo(GeneratorSettings s)
			{
				return false;
			}
		}

		[Serializable]
		public class WallSettings
		{
			public bool up;

			public bool down;

			public bool left;

			public bool right;

			public bool isWallActive => false;

			public bool noWall => false;

			public WallSettings Clone()
			{
				return null;
			}

			public bool IsEqualTo(WallSettings g)
			{
				return false;
			}
		}

		[Serializable]
		public class GravitySettings
		{
			public bool up;

			public bool down;

			public bool left;

			public bool right;

			public bool canJumpWithGravity;

			public bool noGravity => false;

			public GravitySettings Clone()
			{
				return null;
			}

			public bool IsEqualTo(GravitySettings g)
			{
				return false;
			}
		}

		[Serializable]
		public class SlotDefinition
		{
			public IntVector2 position;

			public GeneratorSettings generatorSettings;

			public GravitySettings gravitySettings;

			public WallSettings wallSettings;

			public SlotType slotType;

			public ChipType chipType;

			public int chipTag;

			public ItemColor itemColor;

			public int netLevel;

			public int magicHatItemsCount;

			public int boxLevel;

			public bool hasBubbles;

			public bool holeBlocker;

			public int snowCoverLevel;

			public int basketLevel;

			public int iceLevel;

			public bool hasCarpet;

			public int chainLevel;

			public int itemLevel;

			public bool isPartOfConveyor;

			public int portalEntranceIndex;

			public int portalExitIndex;

			public IntVector2 conveyorDirection;

			public bool isExitForFallingChip;

			public int colorSlateLevel;

			public Color colorSlateColor;

			public string colorSlateSpriteName;

			public bool hasHoleInSlot => false;

			public bool hasSnowCover => false;

			public int moreMovesCount => 0;

			public bool needsToBeGenerated => false;

			public bool isPortalEntrance => false;

			public bool isPortalExit => false;

			public bool isConveyorDirectionSet => false;

			public bool hasChain => false;

			public bool hasBox => false;

			public bool hasBasket => false;

			public bool hasIce => false;

			public bool hasNet => false;

			public bool hasColorSlate => false;

			public bool isFormingMatchesSuspended(LevelDefinition level)
			{
				return false;
			}

			public bool isMoveSuspended(LevelDefinition level)
			{
				return false;
			}

			public bool IsMonsterInSlot(LevelDefinition level)
			{
				return false;
			}

			public SlotDefinition Clone()
			{
				return null;
			}

			public bool IsEqualTo(SlotDefinition slot)
			{
				return false;
			}
		}

		[Serializable]
		public class ChipGenerationSettings
		{
			[Serializable]
			public class ChipSetting
			{
				public ChipType chipType;

				public ItemColor itemColor;

				public float weight;

				public bool IsEqualTo(ChipSetting c)
				{
					return false;
				}

				public ChipSetting Clone()
				{
					return null;
				}
			}

			public List<ChipSetting> chipSettings;

			public bool isConfigured => false;

			public bool IsEqualTo(ChipGenerationSettings c)
			{
				return false;
			}

			public ChipGenerationSettings Clone()
			{
				return null;
			}
		}

		[Serializable]
		public class TutorialMatch
		{
			public bool isEnabled;

			public List<IntVector2> matchingSlots;

			public IntVector2 slotToSwipe;

			public IntVector2 exchangeSlot;

			public void OffsetAllSlots(IntVector2 offset)
			{
			}

			public bool Contains(IntVector2 slot)
			{
				return false;
			}

			public bool IsEqualTo(TutorialMatch t)
			{
				return false;
			}

			public TutorialMatch Clone()
			{
				return null;
			}
		}

		public class Portal
		{
			public SlotDefinition entranceSlot;

			public SlotDefinition exitSlot;

			public bool isValid => false;

			public bool HasEntranceIndex(int index)
			{
				return false;
			}

			public bool HasExitIndex(int index)
			{
				return false;
			}
		}

		public class ConveyorBeltLinearSegment
		{
			public List<SlotDefinition> slotList;

			private List<IntVector2> possibleEntryPositions_;

			public IntVector2 direction => default(IntVector2);

			public SlotDefinition enterSlot => null;

			public SlotDefinition exitSlot => null;

			public IntVector2 exitPosition => default(IntVector2);

			public void FillLinearSegmentFromSlot(SlotDefinition slot, LevelDefinition level)
			{
			}

			public bool IsContaining(IntVector2 position)
			{
				return false;
			}

			public bool IsContaining(SlotDefinition slot)
			{
				return false;
			}
		}

		public class ConveyorBelts
		{
			public List<ConveyorBelt> conveyorBeltList;

			private List<ConveyorBeltLinearSegment> linearSegmentsList;

			private ConveyorBeltLinearSegment SegmentPriorTo(ConveyorBeltLinearSegment nextSegment)
			{
				return null;
			}

			private ConveyorBeltLinearSegment SegmentAfter(ConveyorBeltLinearSegment prevSegment)
			{
				return null;
			}

			public bool IsPartOfConveyor(IntVector2 position)
			{
				return false;
			}

			public bool IsPartOfConveyor(ConveyorBeltLinearSegment segment)
			{
				return false;
			}

			public bool IsPartOfLinearSegmentList(SlotDefinition slot)
			{
				return false;
			}

			public void Init(LevelDefinition level)
			{
			}

			private void CreateConveyorBeltsFromSegments(LevelDefinition level)
			{
			}
		}

		public class ConveyorBelt
		{
			public List<ConveyorBeltLinearSegment> segmentList;

			public bool isLoop;

			public ConveyorBeltLinearSegment firstSegment => null;

			public ConveyorBeltLinearSegment lastSegment => null;

			public IntVector2 firstPosition => default(IntVector2);

			public IntVector2 lastPosition => default(IntVector2);

			public bool IsContaining(IntVector2 position)
			{
				return false;
			}

			public bool IsContaining(ConveyorBeltLinearSegment segment)
			{
				return false;
			}
		}

		[SerializeField]
		public string name;

		[SerializeField]
		public string originalLevelFileName;

		[SerializeField]
		public string nextLevelName;

		[SerializeField]
		public string prevLevelName;

		[SerializeField]
		public bool lockLevelForEditing;

		[SerializeField]
		private string description;

		[SerializeField]
		private string notes;

		[SerializeField]
		public string tags;

		public long versionIndex;

		public Size size;

		public SuggestMoveType suggestMoveType;

		public ShowPotentialMatchSetting suggestMoveSetting;

		public int numChips;

		[SerializeField]
		public ChipGenerationSettings generationSettings;

		public bool isPowerupPlacementSuspended;

		public List<TutorialMatch> tutorialMatches;

		public bool isPreventingGeneratorChipMatching;

		public bool useChanceToNotPreventChipMatching;

		public float chanceToNotPreventChipMatching;

		public List<SlotDefinition> slots;

		public BurriedElements burriedElements;

		public MonsterElements monsterElements;

		public GoalsDefinition goals;

		public ExtraFallingElements extraFallingElements;

		public List<GeneratorSetup> generatorSetups;

		public List<GeneratorSlotSettings> generatorSlotSettings;

		public int portalIndexCount => 0;

		public int firstFreePortalEntranceIndex => 0;

		public int firstFreePortalExitIndex => 0;

		public bool IsSlotsEqualTo(LevelDefinition level)
		{
			return false;
		}

		public ConveyorBelts GetConveyorBelts()
		{
			return null;
		}

		public List<Portal> GetAllPortals()
		{
			return null;
		}

		public int GetNumberOfEmptyRowsAtBottom()
		{
			return 0;
		}

		public GeneratorSlotSettings GetGeneratorSlotSettings(int index)
		{
			return null;
		}

		public GeneratorSetup GetGeneratorSetup(IntVector2 position)
		{
			return null;
		}

		public SlotDefinition GetSlot(IntVector2 position)
		{
			return null;
		}

		public void SetSlot(IntVector2 position, SlotDefinition slot)
		{
		}

		public void ExchangeBurriedElementsForSmallOnes()
		{
		}

		private bool IsGeneratorSlotSettingsSame(LevelDefinition l)
		{
			return false;
		}

		private bool IsTutorialMatchesSame(LevelDefinition l)
		{
			return false;
		}

		private bool IsGeneratorSetupsSame(LevelDefinition l)
		{
			return false;
		}

		public bool IsEqualTo(LevelDefinition level)
		{
			return false;
		}

		public LevelDefinition Clone()
		{
			return null;
		}

		public void EnsureSizeAndInit()
		{
		}

		public int CountChips(ChipType type)
		{
			return 0;
		}
	}
}
