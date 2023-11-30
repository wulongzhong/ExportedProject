using System;
using UnityEngine;

namespace GGMatch3
{
	public class MagicHat : SlotComponent
	{
		[Serializable]
		public class Settings
		{
			public float durationForBunnyUp;

			public Vector3 bunnyOffsetIn;

			public Vector3 bunnyOffsetOut;

			public Vector3 bunnyScaleIn;

			public Vector3 bunnyScaleOut;

			public AnimationCurve positionCurve;

			public AnimationCurve scaleCurve;

			public float delayUp;
		}

		private MagicHatBehaviour hatBehaviour;

		private float timeSinceBunnyCollected;

		public override int sortingOrder => 0;

		private Settings settings => null;

		public override bool isSlotMatchingSuspended => false;

		public override bool isAttachGrowingElementSuspended => false;

		public override bool isPlaceBubbleSuspended => false;

		public override bool isMoveIntoSlotSuspended => false;

		public override bool isSlotGravitySuspended => false;

		public override bool isSlotSwapSuspended => false;

		public override bool isPreventingGravity => false;

		public override bool isCreatePowerupWithThisSlotSuspended => false;

		public override bool isMovingWithConveyor => false;

		public override bool isDestroyedByMatchingNextTo => false;

		public void Init(MagicHatBehaviour hatBehaviour)
		{
		}

		public override bool IsAvailableForDiscoBombSuspended(bool replaceWithBombs)
		{
			return false;
		}

		public override bool IsCompatibleWithPickupGoal(Match3Goals.ChipTypeDef chipTypeDef)
		{
			return false;
		}

		public override SlotDestroyResolution OnDestroyNeighbourSlotComponent(Slot slotBeingDestroyed, SlotDestroyParams destroyParams)
		{
			return default(SlotDestroyResolution);
		}

		public override SlotDestroyResolution OnDestroySlotComponent(SlotDestroyParams destroyParams)
		{
			return default(SlotDestroyResolution);
		}

		private void CreateBunny(Slot slotBeingDestroyed, SlotDestroyParams destroyParams)
		{
		}

		private void UpdateBunny()
		{
		}

		public override void OnUpdate(float deltaTime)
		{
		}
	}
}
