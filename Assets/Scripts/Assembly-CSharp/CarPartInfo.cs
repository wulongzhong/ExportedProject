using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CarPartInfo
{
	public enum AnimType
	{
		ScaleBounce = 0,
		MoveOffset = 1
	}

	[SerializeField]
	public List<CarModelPart> hideWhenAnyActive;

	[SerializeField]
	public List<CarModelPart> hideWhenAnyShowing;

	[SerializeField]
	public List<CarModelPart> hideWhenNotActive;

	[SerializeField]
	public List<CarModelPart> showOnlyWhenUnlocked;

	[SerializeField]
	public List<CarModelPart> hideWhileOpening;

	[SerializeField]
	public List<CarModelPart> showOnlyWhenActive;

	[SerializeField]
	public bool isDefault;

	[SerializeField]
	public bool isHidden;

	[SerializeField]
	public bool isBox;

	[SerializeField]
	public string name;

	[SerializeField]
	private string displayName_;

	[SerializeField]
	public string thingToSay;

	[SerializeField]
	public TalkCharacter characterThatSays;

	[SerializeField]
	public string cameraName;

	[SerializeField]
	public List<TalkingDialog.TalkLine> toSayBefore;

	[SerializeField]
	public StoryTimelineBehaviour animationWhenPurchased;

	[SerializeField]
	public StoryTimelineBehaviour animationAfterBuy;

	[SerializeField]
	public int price;

	[SerializeField]
	public int rubyPrice;

	[SerializeField]
	public List<CarModelPart> mustBuildFirst;

	[SerializeField]
	public int groupIndex;

	[SerializeField]
	public int explodeGroupIndex;

	[SerializeField]
	public AnimType animType;

	[SerializeField]
	public Vector3 moveOffset;

	[SerializeField]
	public bool suspendExploding;

	[SerializeField]
	public bool confirmEachSubpart;

	[SerializeField]
	public float delaySubpartAnimation;

	[NonSerialized]
	private List<string> variantGroupsToShowAfterPurchase_;

	[SerializeField]
	public CarModelCustomization customizationToShowAfterPurchase;

	[SerializeField]
	public List<CarModelCustomization> otherCustomizationsAfterPurchase;

	[SerializeField]
	public List<PartHinge> hingesToTurnOnDuringPurchase;

	[SerializeField]
	public List<PartHinge> hingesToTurnOnAfterPurchase;

	[SerializeField]
	public List<string> animateChangeWithVariations;

	[SerializeField]
	public bool autoShow;

	[NonSerialized]
	private CarModel carModel;

	private RoomsBackend.RoomAccessor backendAccessor_;

	private RoomsBackend.VisualObjectAccessor visualObjectModel_;

	public bool hasAnimationWhenPurchased => false;

	public bool hasAnimationAfterBuy => false;

	public bool hasSomethingToSay => false;

	public string displayName => null;

	public SingleCurrencyPrice currencyPrice => null;

	public List<string> variantGroupsToShowAfterPurchase => null;

	private RoomsBackend.RoomAccessor backendAccessor => null;

	public RoomsBackend.VisualObjectAccessor visualObjectModel => null;

	public int selectedVariation
	{
		set
		{
		}
	}

	public bool isOwned
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isUnlocked => false;

	public void InitForRuntime(CarModel carModel, RoomsBackend.RoomAccessor backend)
	{
	}
}
