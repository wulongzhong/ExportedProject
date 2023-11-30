using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace GGMatch3
{
	public class TransformBehaviour : SlotComponentBehavoiour
	{
		public class SortingLayerSettings
		{
			public SpriteRenderer spriteRenderer;

			public SquareClothRenderer squareClothRenderer;

			public SpriteSortingSettings sortingSettings;
		}

		private List<SortingLayerSettings> sortingSettings;

		[SerializeField]
		private Transform shadowTransform;

		[SerializeField]
		private Transform partOfGoalContainer;

		[SerializeField]
		private bool destroyWhenRemovedFromGame;

		[SerializeField]
		private Transform offsetTransform;

		[SerializeField]
		public Transform scalerTransform;

		[SerializeField]
		private Transform childrenContainer;

		private List<TransformBehaviour> children;

		[SerializeField]
		private List<SpriteRenderer> spriteRenderers;

		[SerializeField]
		private List<SquareClothRenderer> clothRenderers;

		[SerializeField]
		private List<TextMeshPro> textRenderers;

		private Vector3 showMatchActionLocalScale_;

		private Vector3 slotLocalScale_;

		private Vector3 wobbleLocalScale_;

		private Vector3 localScale_;

		private Vector3 slotOffsetPosition_;

		private Vector3 localOffsetPosition_;

		private Vector3 localPotentialMatchOffsetPosition_;

		public Vector3 showMatchActionLocalScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 slotLocalScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 wobbleLocalScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 localScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 totalLocalScale => default(Vector3);

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

		public Vector3 slotOffsetPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 localOffsetPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 localPotentialMatchOffsetPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion localRotationOffset
		{
			set
			{
			}
		}

		public void SetPartOfGoalActive(bool active)
		{
		}

		public void SetShadowActive(bool active)
		{
		}

		public void AddChild(TransformBehaviour t)
		{
		}

		private void ApplyScale()
		{
		}

		public Vector3 WorldToLocalPosition(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		public List<SortingLayerSettings> SaveSortingLayerSettings()
		{
			return null;
		}

		public void ResetSortingLayerSettings()
		{
		}

		private void ApplyPosition()
		{
		}

		public void SetAlpha(float alpha)
		{
		}

		public void SetText(string text)
		{
		}

		public void SetColor(Color color)
		{
		}

		public void SetBrightness(float brightness)
		{
		}

		public void SetSortingLayer(SpriteSortingSettings s)
		{
		}

		public void SetSortingLayer(int sortingLayerId, int orderInLayer)
		{
		}

		public void ForceRemoveFromGame()
		{
		}

		public override void RemoveFromGame()
		{
		}
	}
}
