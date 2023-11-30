using System;
using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	public class Match3Settings : ScriptableObject
	{
		[Serializable]
		public class MonsterColorSettings
		{
			public ItemColor itemColor;

			public Material material;
		}

		[Serializable]
		public class ChipColorSettings
		{
			public string name;

			public List<ChipChange> chipChanges;

			public bool hasBoxes;

			public ChipChange GetChipChange(ItemColor itemColor)
			{
				return null;
			}
		}

		[Serializable]
		public class ChipChange
		{
			public ItemColor itemColor;

			public bool change;

			public float hue;

			public float saturation;

			public float brightness;

			public Texture2D textureReplace;

			public float scale;

			public float boxHue;

			public float boxSaturation;

			public float boxBrightness;
		}

		private static bool applicationIsQuitting;

		protected static Match3Settings instance_;

		protected static string loadedSingletonName;

		[SerializeField]
		private int selectedColorSettings;

		[SerializeField]
		private List<ChipColorSettings> colorSettings;

		[SerializeField]
		private List<MonsterColorSettings> monsterColorSettings;

		[SerializeField]
		private List<ChipChange> chipChanges;

		[SerializeField]
		public PartSettings partSettings;

		[SerializeField]
		private List<ChipDisplaySettings> chipDisplays;

		public int maxPotentialMatchesAtStart;

		public float boosterPlaceDelay;

		public float exitScrollSpeed;

		public GeneralSettings generalSettings;

		public GravitySettings gravitySettings;

		public PipeSettings pipeSettings;

		public DestroyChipAction.Settings destroyActionSettings;

		public DestroyChipAction.Settings destroyActionSettingsRocket;

		public DestroyChipActionGrow.Settings destroyActionGrowSettings;

		public DestroyBoxAction.Settings destroyBoxActionSettings;

		public DestroyChipActionExplosion.Settings destroyChipActionExplosionSettings;

		public ExplosionAction.Settings explosionSettings;

		public CrossExplosionAction.Settings crossExplosionSettings;

		public FlyRocketPieceAction.Settings flyRocketPieceSettings;

		public SwapChipsAction.Settings swapChipsActionSettings;

		public ShowSwapNotPossibleAction.Settings showSwapNotPossibleActionSettings;

		public DestroyFromGravityAction.Settings destroyFromGravityAction;

		public CreatePowerupAction.Settings createPowerupActionSettings;

		public DiscoBallDestroyAction.Settings discoBallDestroyActionSettings;

		public FlyCrossRocketAction.Settings flyCrossRocketActionSettings;

		public LightSlotComponent.Settings lightSlotSettings;

		public BasketBlocker.Settings basketBlockerSettings;

		public ConveyorBeltBoardComponent.Settings conveyorBeltSettings;

		public CollectGoalAction.Settings collectGoalSettings;

		public CollectBurriedElementAction.Settings collectBurriedEelementSettings;

		public CollectPointsAction.Settings collectPointsActionSettings;

		public SeekingMissileAction.Settings seekingMissileSettings;

		public ComboSeekingMissileAction.Settings seekingMissileComboSettings;

		public ShowPotentialMatchAction.Settings showPotentialMatchesSettings;

		public SwapToMatchAction.Settings swapToMatchActionSettings;

		public PlayerInput.Settings playerInputSettings;

		public PlayerInput.MoveFromLineAffector.Settings playerInputMoveFromLineSettings;

		public PlayerInput.ExplosionAffector.Settings explosionAffectorSettings;

		public PlayerInputCrossAffector.Settings playerInputCrossAffectorSettings;

		public DiscoBallAffector.Settings discoBallAffectorSettings;

		public ChipJumpBehaviour.Settings chipJumpSettings;

		public WobbleAnimation.Settings chipWobbleSettings;

		public ChipJumpBehaviour.Settings powerupJumpSettings;

		public ChipJumpBehaviour.Settings horizontalRocketJumpSettings;

		public ChipJumpBehaviour.Settings verticalRocketJumpSettings;

		public ChipJumpBehaviour.Settings bombJumpSettings;

		public ChipJumpBehaviour.Settings discoBallJumpSettings;

		public ChipJumpBehaviour.Settings seekingMissleJumpSettings;

		public ConfirmPurchasePanel.Settings confirmPurchasePanelSettings;

		public DecorateRoomSceneVisualItem.Settings visualItemAnimationSettings;

		public WinScreenBoardOutAnimation winScreenBoardOutAnimation;

		public WinScreenBoardInAnimation winScreenInAnimation;

		public MoneyPickupAnimation.Settings moneyPickupAnimationSettings;

		public MagicHat.Settings magicHatSettings;

		public MagicHat.Settings magicHatSettingsBomb;

		public DragButton.Settings dragButtonSettings;

		public StarConsumeAnimation.Settings starConsumeSettings;

		public GameScreen.MultiLevelAanimationSettings multiLevelAnimationSettings;

		public BurriedElementPiece.Settings burriedElementPieceSettings;

		public AnimateGrowingElementOnChip.Settings animateGrowingElementOnChipSettings;

		public AnimateCarryPiece.Settings animateCarryPieceSettings;

		public GrowingElementPot.Settings growingElementPotSettings;

		public WinScreen.Settings winScreenSettings;

		public SwipeAffector.Settings swipeAffectorSettings;

		public SeekingMissleAffector.Settings seekingMissleAffectorSettings;

		public PowerLineAffector.Settings powerLineAffectorSettings;

		public PowerCrossAffector.Settings powerCrossAffectorSettings;

		public CombineChipAffectors.Settings combineChipAffectorSettings;

		public PlacePowerupAction.Settings placePowerupActionSettings;

		public DestroyMatchingIslandBlinkAction.Settings destroyIslandBlinkSettings;

		public DestroyMatchingIslandBlinkAction.Settings destroyAfterSettings;

		public TutorialHandController.Settings tutorialHandSettings;

		public TutorialHandController.Settings tutorialSwipeSettings;

		public TutorialHandController.Settings tutorialTouchSettings;

		protected static string FilenameToLoad => null;

		public static Match3Settings instance => null;

		public void OnDestroy()
		{
		}

		protected static bool NeedsToLoadSingleton()
		{
			return false;
		}

		public MonsterColorSettings GeMonsterColorSettings(ItemColor itemColor)
		{
			return null;
		}

		public ChipColorSettings GetColorSettings()
		{
			return null;
		}

		public ChipChange GetChipChange(ItemColor itemColor)
		{
			return null;
		}

		public ChipDisplaySettings GetChipDisplaySettings(ChipType chipType, ItemColor itemColor)
		{
			return null;
		}
	}
}
