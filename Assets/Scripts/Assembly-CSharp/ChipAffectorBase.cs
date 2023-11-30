using System.Collections.Generic;
using GGMatch3;

public class ChipAffectorBase
{
	protected LockContainer lockContainer;

	private Lock globalLock_;

	protected Lock globalLock => null;

	public virtual bool canFinish => false;

	public virtual void ReleaseLocks()
	{
	}

	public virtual void ApplyLocks()
	{
	}

	public virtual void Clear()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void GiveLightingBoltsTo(List<LightingBolt> destinationBolts)
	{
	}

	public virtual void AddToInputAffectorExport(Match3Game.InputAffectorExport inputAffector)
	{
	}

	public virtual void OnAfterDestroy()
	{
	}
}
