using System;
using System.Collections.Generic;
using UnityEngine;

public class GGSoundSystem : MonoBehaviour
{
	public enum MusicType
	{
		NoMusic = 0,
		MainMenuMusic = 1,
		GameMusic = 2
	}

	public enum LoopSFXType
	{
		None = 0,
		Drill = 1,
		Spray = 2
	}

	public enum SFXType
	{
		ButtonPress = 0,
		CancelPress = 1,
		None = 2,
		ButtonFail = 3,
		FlyIn = 4,
		ButtonConfirm = 5,
		Flip = 6,
		PurchaseSuccess = 7,
		GiftPresented = 8,
		GiftOpen = 9,
		ChipSwap = 10,
		ChipTap = 11,
		CollectGoal = 12,
		GoalsComplete = 13,
		FlyRocket = 14,
		CollectGoalStart = 15,
		CreatePowerup = 16,
		BombExplode = 17,
		PlainMatch = 18,
		SeekingMissleTakeOff = 19,
		DiscoBallElectricity = 20,
		DiscoBallExplode = 21,
		CoinCollect = 22,
		CoinCollectStart = 23,
		BreakColorSlate = 24,
		BreakBox = 25,
		FlyCrossRocketAction = 26,
		BreakChain = 27,
		BreakIce = 28,
		GingerbreadManRescue = 29,
		SeekingMissleLand = 30,
		HammerHit = 31,
		PowerHammerHit = 32,
		HammerStart = 33,
		GrowingElementFinish = 34,
		GrowingElementGrowFlower = 35,
		CollectMoreMoves = 36,
		CollectMoreMovesStart = 37,
		RockBreak = 38,
		ChocolateBreak = 39,
		SnowDestroy = 40,
		SnowCreate = 41,
		BunnyOutOfHat = 42,
		WinScreenStart = 43,
		WinScreenReceieveAnimationStart = 44,
		RecieveStar = 45,
		RecieveCoin = 46,
		YouWinAnimation = 47,
		PartAddedToCar = 48,
		CarDragStart = 49,
		CarDragStartCarpet = 50,
		AudioClip = 51
	}

	private struct TimedCounter
	{
		public float leftTime;

		public int count;
	}

	[Serializable]
	public class MusicSource
	{
		public MusicType musicType;

		public AudioSource source;
	}

	[Serializable]
	public class LoopSoundFxClip
	{
		[SerializeField]
		public LoopSFXType clipType;

		[SerializeField]
		private AudioClip clip;

		[SerializeField]
		private AudioSource source;

		[SerializeField]
		private bool changeAmplitude;

		[SerializeField]
		private float amplitudeDuration;

		[SerializeField]
		private float fromAmplitude;

		[SerializeField]
		private float toAmplitude;

		[SerializeField]
		private bool changePitch;

		[SerializeField]
		private float pitchDuration;

		[SerializeField]
		private float fromPitch;

		[SerializeField]
		private float toPitch;

		[NonSerialized]
		private float time;

		public void Update()
		{
		}

		public void Stop()
		{
		}

		public void SetAmplitudeAndPitch()
		{
		}

		public void ResumePlay()
		{
		}
	}

	[Serializable]
	public class SoundFxClip
	{
		[Serializable]
		public class ClipVariation
		{
			public AudioClip clip;

			public float pitch;

			public float volume;
		}

		public struct VariationParameters
		{
			public float pitch;

			public AudioClip clip;

			public float volume;
		}

		public SFXType clipType;

		public AudioClip clip;

		public List<ClipVariation> variationList;

		public VariationParameters GetVariation(int index)
		{
			return default(VariationParameters);
		}
	}

	private class AudioSourceData
	{
		public AudioSource audioSource;

		public SFXType playedSound;

		public long frameIndexWhenStart;

		public AudioSourceData(AudioSource audioSource)
		{
		}
	}

	public struct PlayParameters
	{
		public SFXType soundType;

		public int variationIndex;

		public long frameNumber;
	}

	[SerializeField]
	private bool isDebug;

	private TimedCounter matchesCounter;

	[SerializeField]
	private MusicType defaultMusic;

	[SerializeField]
	private GameObject audioClipSourcePrefab;

	[SerializeField]
	private List<MusicSource> musics;

	[SerializeField]
	private List<SoundFxClip> soundFxList;

	[SerializeField]
	private List<LoopSoundFxClip> loopSoundFxList;

	private List<AudioSourceData> audioClipsSources;

	private static GGSoundSystem soundSystem_;

	public static GGSoundSystem instance => null;

	public static void Stop(LoopSoundFxClip sound)
	{
	}

	public static void StopMusic()
	{
	}

	public static void Update(LoopSoundFxClip sound)
	{
	}

	public static void ResumePlay(LoopSoundFxClip sound)
	{
	}

	public void PlayMusic(MusicType musicType)
	{
	}

	public void StopAllMusic()
	{
	}

	public static void Play(AudioClip clip)
	{
	}

	public static void Play(MusicType musicType)
	{
	}

	public static void Play(PlayParameters playParameters)
	{
	}

	public static void Play(SFXType soundType)
	{
	}

	public static void PlayRandomVariation(SFXType soundType)
	{
	}

	public static void ReportMatch()
	{
	}

	public void PlayFx(PlayParameters p)
	{
	}

	private void DoReportMatch()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public LoopSoundFxClip GetLoop(LoopSFXType type)
	{
		return null;
	}

	private SoundFxClip GetClip(SFXType soundType)
	{
		return null;
	}

	private long LastPlayingFrameNumber(SFXType soundType)
	{
		return 0L;
	}

	private AudioSourceData NextAudioSource()
	{
		return null;
	}

	private void PlayClip(AudioClip clip, PlayParameters p)
	{
	}

	private void Play(SoundFxClip clip, PlayParameters p)
	{
	}
}
