using System.Collections.Generic;
using GGMatch3;
using UnityEngine;

public class Match3GameParams
{
	public LevelDefinition level;

	public List<LevelDefinition> levelsList;

	public List<BoosterConfig> activeBoosters;

	public List<BoosterConfig> boughtBoosters;

	public List<TalkingDialog.TalkLine> toSay;

	public Match3GameListener listener;

	public Match3StagesDB.Stage stage;

	public int iterations;

	public float timeScale;

	public bool isAIPlayer;

	public bool isAIDebug;

	public bool isHudDissabled;

	public int levelIndex;

	public bool disableParticles;

	public int giftBoosterLevel;

	public bool setRandomSeed;

	public int randomSeed;

	public bool disableBackground;

	public Sprite backgroundSprite;

	public int BoughtBoosterCount(BoosterType boosterType)
	{
		return 0;
	}
}
