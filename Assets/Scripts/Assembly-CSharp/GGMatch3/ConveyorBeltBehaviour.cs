using System;
using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	public class ConveyorBeltBehaviour : MonoBehaviour
	{
		[SerializeField]
		private ComponentPool pool;

		private Match3Game game;

		[NonSerialized]
		public PipeBehaviour entrancePipe;

		[NonSerialized]
		public PipeBehaviour exitPipe;

		private List<ConveyorBeltSegment> segments;

		public void Init(Match3Game game, LevelDefinition.ConveyorBelt conveyorBeltDef, int index)
		{
		}

		private void InitSegment(LevelDefinition.ConveyorBeltLinearSegment segment)
		{
		}

		public void SetTile(float tile)
		{
		}

		public Color GetColor()
		{
			return default(Color);
		}

		public void SetColor(Color color)
		{
		}
	}
}
