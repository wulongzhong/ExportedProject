using System;
using System.Collections.Generic;
using GGMatch3;

[Serializable]
public class GameStats
{
	public enum MoveType
	{
		Unknown = 0,
		Match = 1,
		PowerupActivation = 2,
		PowerupMix = 3,
		PowerupTap = 4
	}

	[Serializable]
	public class Move
	{
		public IntVector2 fromPosition;

		public IntVector2 toPosition;

		public MoveType moveType;

		public long frameWhenActivated;
	}

	public List<Move> moves;

	public int initialSeed;

	public int goalsFromPowerups;

	public int goalsFromUserMatches;

	public int goalsFromInertion;

	public int matchesFromUser;

	public int matchesFromInertion;

	public int powerupsCreatedFromUser;

	public int powerupsCreatedFromInertion;

	public int powerupsUsedBySwipe;

	public int powerupsMixed;

	public int powerupsUsedByTap;

	public int noUsefulMovesTurns;
}
