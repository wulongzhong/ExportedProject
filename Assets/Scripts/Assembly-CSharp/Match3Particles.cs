using System;
using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class Match3Particles : MonoBehaviour
{
	public enum PositionType
	{
		OnDestroyChip = 0,
		OnExplosion = 1,
		OnSeekingMissleExplosion = 2,
		BoxDestroy = 3,
		OnRocketStart = 4,
		MagicHatCreate = 5,
		PipeExitParticle = 6,
		PipeEnterParticle = 7,
		OnHammerHit = 8,
		OnHammerPowerHit = 9,
		BombCombine = 10,
		ChipSwipeHorizontal = 11,
		ChipSwipeVertical = 12,
		MissleHitTarget = 13,
		OnDestroyChipDiscoBomb = 14,
		OnDestroyChipLightStart = 15,
		OnDestroyChipPowerupCreate = 16,
		BombCreate = 17,
		BubblesDestroy = 18,
		BubblesCreate = 19,
		OnUIGoalCollected = 20,
		BurriedElementBreak = 21,
		PlacePowerupParticles = 22,
		OnDestroyChipCollect = 23,
		OnDestroyChipExplosion = 24,
		OnDestroyChipRocket = 25,
		BurriedElementTravelParticle = 26,
		ChipTap = 27,
		GoalComplete = 28
	}

	[Serializable]
	public class ItemColorModifier
	{
		public ItemColor ItemColor;

		public bool modifyColor;

		public Color colorMin;

		public Color colorMax;

		public void Apply(GameObject go)
		{
		}
	}

	[Serializable]
	public class PieceCreatorPool
	{
		public enum AbTestVariant
		{
			Normal = 0,
			CandyType = 1,
			CandyAnimType = 2,
			BurriedTest = 3,
			BarryChipTest = 4
		}

		public PositionType type;

		[SerializeField]
		public AbTestVariant abTestVariant;

		[SerializeField]
		private List<AbTestVariant> abTestVariantsList;

		public List<ChipType> chipTypeList;

		public List<int> levelList;

		public List<ItemColorModifier> itemColorModifiers;

		public ComponentPool pool;

		public bool IsAcceptableForVariant(int variant)
		{
			return false;
		}

		public ItemColorModifier GetModifier(ItemColor itemColor)
		{
			return null;
		}
	}

	[NonSerialized]
	public bool disableParticles;

	[SerializeField]
	private List<PieceCreatorPool> pieceCreatorPools;

	private List<PieceCreatorPool> positionTypeFilteredPools_;

	private List<PieceCreatorPool> GetPoolsForPositionType(PositionType type)
	{
		return null;
	}

	private PieceCreatorPool GetPool(PositionType type)
	{
		return null;
	}

	private PieceCreatorPool GetPool(PositionType type, ChipType chipType)
	{
		return null;
	}

	private PieceCreatorPool GetPool(PositionType type, ChipType chipType, int level)
	{
		return null;
	}

	public GameObject CreateParticles(Vector3 localPositionOfCenter, PositionType positionType, Quaternion rotation)
	{
		return null;
	}

	public GameObject CreateParticles(Slot slot, PositionType positionType)
	{
		return null;
	}

	public GameObject CreateParticles(Vector3 localPosition, PositionType positionType)
	{
		return null;
	}

	public GameObject CreateParticles(Chip chip, PositionType positionType, ChipType chipType, ItemColor itemColor)
	{
		return null;
	}

	public GameObject CreateParticlesWorld(Vector3 worldPosition, PositionType positionType, ChipType chipType, ItemColor itemColor)
	{
		return null;
	}

	public GameObject CreateParticles(Vector3 localPosition, PositionType positionType, ChipType chipType, int level)
	{
		return null;
	}

	public GameObject CreateParticles(Vector3 localPosition, PositionType positionType, ChipType chipType, ItemColor itemColor)
	{
		return null;
	}
}
