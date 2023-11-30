using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GGMatch3
{
	public class LevelEditorSlot : MonoBehaviour
	{
		[Serializable]
		public class PortalDefinition
		{
			public RectTransform container;

			public Color lowColor;

			public Color highColor;

			public Image coloredImage;

			public string suffix;

			public Text label;

			public void SetActive(bool active)
			{
			}

			public void Init(int index, int totalCount)
			{
			}
		}

		[Serializable]
		public class LayerDesc
		{
			public GameObject objectToShow;
		}

		[Serializable]
		public class LayerSet
		{
			public List<LayerDesc> layers;

			public void ShowLayer(int index)
			{
			}
		}

		[Serializable]
		public class ChipDescriptor
		{
			public ItemColor color;

			public ChipType chipType;

			public RectTransform container;
		}

		[Serializable]
		public class ChipTypeDescriptor
		{
			public ChipType chipType;

			public RectTransform container;
		}

		[SerializeField]
		private List<RectTransform> widgetsToHide;

		[SerializeField]
		private Color normalGravityColor;

		[SerializeField]
		private Color jumpGravityColor;

		[SerializeField]
		private List<Text> magicHatItemsCount;

		[SerializeField]
		private List<Image> coloredGravityImages;

		[SerializeField]
		private RectTransform generatorContainer;

		[SerializeField]
		private Text generatorText;

		[SerializeField]
		private Image generatorSetupImage;

		[SerializeField]
		private RectTransform upArrow;

		[SerializeField]
		private RectTransform downArrow;

		[SerializeField]
		private RectTransform leftArrow;

		[SerializeField]
		private RectTransform rightArrow;

		[SerializeField]
		private RectTransform emptyContainer;

		[SerializeField]
		private RectTransform fillContainer;

		[SerializeField]
		private RectTransform wallContainer;

		[SerializeField]
		private RectTransform wallLeft;

		[SerializeField]
		private RectTransform wallRight;

		[SerializeField]
		private RectTransform wallUp;

		[SerializeField]
		private RectTransform wallDown;

		[SerializeField]
		private RectTransform chipContainer;

		[SerializeField]
		private RectTransform randomChipContainer;

		[SerializeField]
		private RectTransform netContainer;

		[SerializeField]
		private List<RectTransform> boxContainer;

		[SerializeField]
		private RectTransform iceContainer;

		[SerializeField]
		private LayerSet iceLayerSet;

		[SerializeField]
		private RectTransform conveyorContainer;

		[SerializeField]
		private RectTransform conveyorContainerDown;

		[SerializeField]
		private RectTransform conveyorContainerUp;

		[SerializeField]
		private RectTransform exitForFallingChip;

		[SerializeField]
		private Text moreMovesLabel;

		[SerializeField]
		private RectTransform bubbleContainer;

		[SerializeField]
		private RectTransform snowCoverContainer;

		[SerializeField]
		private List<RectTransform> basketContainer;

		[SerializeField]
		private LayerSet basketLayerSet;

		[SerializeField]
		private LayerSet boxLayerSet;

		[SerializeField]
		private RectTransform chainContainer;

		[SerializeField]
		private LayerSet chainLayerSet;

		[SerializeField]
		private LayerSet bunnyLeyerSet;

		[SerializeField]
		private LayerSet rockBlockLayerSet;

		[SerializeField]
		private LayerSet cookiePickupLayerSet;

		[SerializeField]
		private RectTransform slotColorSlateContainer;

		[SerializeField]
		private LayerSet slotColorSlateLevelSet;

		[SerializeField]
		private List<ChipDescriptor> chips;

		[SerializeField]
		private List<ChipTypeDescriptor> chipsTypes;

		[SerializeField]
		private RectTransform portalContainer;

		[SerializeField]
		private PortalDefinition enterPortal;

		[SerializeField]
		private PortalDefinition exitPortal;

		[SerializeField]
		private RectTransform carpetContainer;

		[NonSerialized]
		public IntVector2 position;

		public Action<LevelEditorSlot> onPressed;

		public static void SetActive(List<RectTransform> list, bool active)
		{
		}

		public static void SetActive(RectTransform t, bool active)
		{
		}

		private static void SetText(Text label, string text)
		{
		}

		public void ButtonCallback_OnPressed()
		{
		}

		public void Init(LevelDefinition level, LevelDefinition.SlotDefinition slot)
		{
		}

		private void SetGeneratorSetup(LevelDefinition level, LevelDefinition.SlotDefinition slot)
		{
		}

		private void SetConveyor(LevelDefinition.SlotDefinition slot)
		{
		}

		private void SetPortals(LevelDefinition level, LevelDefinition.SlotDefinition slot)
		{
		}
	}
}
