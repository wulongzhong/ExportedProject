using UnityEngine;

namespace GGMatch3
{
	public class ChipPhysics
	{
		public SlotComponent chip;

		public Vector3 movingFrom;

		public Vector3 movingTo;

		public Vector3 velocity;

		public Vector3 currentPosition;

		public bool isActive;

		public bool isFalling;

		public long frameIndexWhenDeactivated;

		public float lastMoveTime;

		public long lastMoveFrameIndex;

		public float speed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool isArrivedToDestination => false;

		public void StartMove(Vector3 movingFrom, Vector3 movingTo, long frameIndex, float currentTime)
		{
		}

		public UpdateResult OnUpdate(UpdateParams updateParams)
		{
			return default(UpdateResult);
		}
	}
}
