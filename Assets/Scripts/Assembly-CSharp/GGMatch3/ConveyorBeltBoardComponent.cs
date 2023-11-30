using System;
using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	public class ConveyorBeltBoardComponent : BoardComponent
	{
		[Serializable]
		public class Settings
		{
			public int slotsToExtendPastEndOfBoard;

			public float delayBeforeMove;

			public float duration;

			public float pipeDuration;

			public AnimationCurve travelCurve;

			public AnimationCurve pipeTravelCurve;

			public float pipeScale;

			public float minTimeNotMoveBeforeCanStartConveyor;

			public Color colorWhenActive;

			public Color colorWhenMoved;

			public float colorChangeSpeed;

			public bool shouldJump;

			public float orthoDirectionUp;

			public Vector3 jumpScale;

			public SpriteSortingSettings sortingSettings;

			public AnimationCurve jumpUpCurve;

			public AnimationCurve jumpDistanceCurve;
		}

		public class LinearMove
		{
			public Vector3 startPosition;

			public Vector3 endPosition;

			public bool isStarted;

			public bool isEnded;

			public bool isJump;

			public bool resetVisuallyWhenStart;

			public PipeBehaviour pipe;

			public void Reset()
			{
			}

			public void OnStart(Movement m)
			{
			}

			public void OnEnd(Movement m)
			{
			}
		}

		public class Movement
		{
			public Slot fromSlot;

			public Slot toSlot;

			public bool isEnded;

			public List<SlotComponent> moveComponents;

			public List<LinearMove> linearMoves;

			public int currentLinearMoveIndex;

			public float durationScale;

			public void Reset()
			{
			}
		}

		private Match3Game game;

		private LevelDefinition.ConveyorBelt conveyorBeltDef;

		private ConveyorBeltBehaviour beh;

		private int movesCountWhenTookAction;

		private LockContainer lockContainer;

		private Lock globalLock;

		private List<Movement> moveList;

		private float movingTime;

		private bool _003CisMoving_003Ek__BackingField;

		private Color colorWhenStartMove;

		private List<Slot> slotsToLock;

		private List<Slot> slotsToCheck;

		private List<Slot> allSlotsList;

		public Settings settings => null;

		public bool isMoving
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public int lastMoveConveyorTookAction => 0;

		public bool needsToActivateConveyor => false;

		private void StartMove()
		{
		}

		private void SetPipeScale(PipeBehaviour pipe, float scale)
		{
		}

		public List<Slot> GetSlotsToLock()
		{
			return null;
		}

		public List<Slot> GetSlotsToCheck()
		{
			return null;
		}

		private void UpdateMove(float deltaTime)
		{
		}

		public void Init(Match3Game game, LevelDefinition.ConveyorBelt conveyorBeltDef, ConveyorBeltBehaviour beh)
		{
		}

		public bool IsMoveConveyorSuspended()
		{
			return false;
		}

		public override void Update(float deltaTime)
		{
		}
	}
}
