public class RandomProvider
{
	private int internalSeed;

	public virtual int seed
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual void Init()
	{
	}

	public virtual float Range(float min, float max)
	{
		return 0f;
	}

	public virtual int Range(int min, int max)
	{
		return 0;
	}
}
