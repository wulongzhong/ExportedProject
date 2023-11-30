using System;
using System.Collections.Generic;

namespace GGMatch3
{
	public class HeuristicAIPlayer
	{
		public struct PotentialMove
		{
			public ActionScore moveScore;

			public PotentialMatches.CompoundSlotsSet swapMatch;

			public PowerupActivations.PowerupActivation powerupActivation;

			public PowerupCombines.PowerupCombine powerupCombine;

			public ActionScore powerupScore;

			//public PotentialMove(ActionScore moveScore, PotentialMatches.CompoundSlotsSet swapMatch, ActionScore powerupScore)
			//{
			//}

			//public PotentialMove(ActionScore moveScore, PowerupActivations.PowerupActivation powerupActivation)
			//{
			//}

			//public PotentialMove(ActionScore moveScore, PowerupCombines.PowerupCombine powerupCombine)
			//{
			//}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Comparison<PotentialMove> _003C_003E9__5_0;

			internal int _003CFindBestMove_003Eb__5_0(PotentialMove x, PotentialMove y)
			{
				return 0;
			}
		}

		private Match3Game game;

		private List<PotentialMove> potentialMoves;

		private int lastMoveCount;

		public void Init(Match3Game game)
		{
		}

		public void FindBestMove()
		{
		}
	}
}
