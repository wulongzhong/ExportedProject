using System;
using UnityEngine;

namespace GGMatch3
{
	[Serializable]
	public class GeneralSettings
	{
		public enum BombRangeType
		{
			Full = 0,
			Circle = 1,
			Diamond = 2,
			Candy = 3
		}

		public enum SeekingRangeType
		{
			Normal = 0,
			Candy = 1
		}

		[Serializable]
		public class CameraShakeSettings
		{
			[SerializeField]
			public float magnitude;

			[SerializeField]
			public float roughness;

			[SerializeField]
			public float fadeInTime;

			[SerializeField]
			public float fadeOutTime;

			[SerializeField]
			public Vector3 posInfluence;

			[SerializeField]
			public Vector3 rotInfluence;
		}

		public float chipScaleMult;

		public float pickupScaleMult;

		public float bombScaleMult;

		public float trapScaleMult;

		public float shakeScale;

		public bool preventAutomatchesIfPossible;

		public bool strictAsPossibleToPrevent;

		public bool waitTillBoardStopsForMatches;

		public bool waitIfRocketHitsPowerup;

		public float scoreSpeed;

		public float lerpSpeed;

		public CameraShakeSettings shakeSettings;

		public BombRangeType bombRangeType => default(BombRangeType);

		public SeekingRangeType seekingRangeType => default(SeekingRangeType);
	}
}
