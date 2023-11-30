using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	public class TeleporterAnimation
	{
		public struct MoveParams
		{
			public Match3Game game;

			public SlotComponent chip;

			public float initialSpeed;

			public PipeBehaviour entrancePipe;

			public IntVector2 positionToMoveFrom;

			public IntVector2 directionToMoveFrom;

			public PipeBehaviour exitPipe;

			public IntVector2 positionToMoveTo;

			public IntVector2 directionToMoveTo;

			public long currentFrameIndex;

			public float currentTime;
		}

		public struct LinearMove
		{
			public Vector3 startPosition;

			public Vector3 endPosition;

			public bool isStarted;

			public bool resetVisuallyWhenStart;

			public PipeBehaviour pipe;

			public bool isEntrance;
		}

		public List<LinearMove> moves;

		private Vector3 currentPosition;

		public float currentSpeed;

		private int activeMoveIndex;

		public float lastMoveTime;

		public long lastMoveFrame;

		private MoveParams mp;

		public bool isActive => false;

		public void StartMove(MoveParams mp)
		{
		}

		private void SetPipeScale(PipeBehaviour pipe, float scale)
		{
		}

		public UpdateResult OnUpdate(UpdateParams updateParams)
		{
			return default(UpdateResult);
		}
	}
}
