using System;
using UnityEngine;

namespace GGMatch3
{
	public class BurriedElementPiece
	{
		[Serializable]
		public class Settings
		{
			public Color colorWhenBurried;

			public Color colorWhenDugOut;
		}

		public LevelDefinition.BurriedElement elementDefinition;

		private Match3Game game;

		public BurriedElementBehaviour burriedElementBehaviour;

		private BurriedElements burriedElements;

		private WobbleAnimation wobbleAnimation;

		public Settings settings => null;

		public TransformBehaviour transformBehaviour => null;

		public void Wobble(WobbleAnimation.Settings settings)
		{
		}

		public void Init(Match3Game game, BurriedElements burriedElements, LevelDefinition.BurriedElement elementDefinition)
		{
		}

		public bool IsCompatibleWithPickupGoal(Slot slot, Match3Goals.ChipTypeDef chipTypeDef)
		{
			return false;
		}

		public bool ContainsPosition(IntVector2 position)
		{
			return false;
		}

		public bool IsSlotBlocking(Slot slot)
		{
			return false;
		}

		private void SetColor(Color color)
		{
		}

		public void OnSlateDestroyed(Slot destroyedSlot, SlotDestroyParams destroyParams)
		{
		}

		public void Update(float deltaTime)
		{
		}

		private void RemoveFromElements()
		{
		}

		public void RemoveFromGame()
		{
		}
	}
}
