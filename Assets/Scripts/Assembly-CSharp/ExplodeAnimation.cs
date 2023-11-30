using System;
using System.Collections.Generic;

public class ExplodeAnimation
{
	public class PartDefinition
	{
		public float startTime;

		public float endTime;

		public int sortingGroupIndex;

		public List<CarModelPart> parts;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<PartDefinition> _003C_003E9__6_0;

		internal int _003CInit_003Eb__6_0(PartDefinition a, PartDefinition b)
		{
			return 0;
		}
	}

	[NonSerialized]
	private CarModel model;

	private List<PartDefinition> partDefinitions;

	public bool hasParts => false;

	private PartDefinition GetOrCreatePartDefinition(int sortingGroupIndex)
	{
		return null;
	}

	public void Init(CarModel model)
	{
	}

	public float ClosestFullTime(float time, float changeDirection)
	{
		return 0f;
	}

	public void SetTimeTo(float time)
	{
	}
}
