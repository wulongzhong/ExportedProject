using System;
using UnityEngine;

namespace GGMatch3
{
	public class ChipBehaviour : SlotComponentBehavoiour
	{
		[SerializeField]
		private SquareClothRenderer clothRenderer;

		[SerializeField]
		private ClothDemo cloth;

		[NonSerialized]
		private Chip chip;

		[SerializeField]
		private Transform feather;

		[SerializeField]
		private Transform partOfGoal;

		[SerializeField]
		private Animator chipAnimator;

		[SerializeField]
		private Transform chipTransform;

		[SerializeField]
		private Transform particleParent;

		private GameObject particlesGameObject;

		private Transform prevParticleParent;

		public Vector3 localPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public bool hasBounce
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void Init(Chip chip)
		{
		}

		public void SetFeatherActive(bool active)
		{
		}

		public void ChangeClothTexture(ItemColor itemColor)
		{
		}

		public void ResetCloth()
		{
		}

		public void ResetVisually()
		{
		}

		public void StartChipDestroyAnimation(GameObject particles)
		{
		}

		public void SetBrightness(float brightness)
		{
		}

		public override void RemoveFromGame()
		{
		}

		public void SetActive(bool active)
		{
		}

		private void LateUpdate()
		{
		}
	}
}
