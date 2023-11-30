using System;
using UnityEngine.Events;

namespace DigitalRuby.ThunderAndLightning
{
	[Serializable]
	public class LightningCustomTransformDelegate : UnityEvent<LightningCustomTransformStateInfo>
	{
		public LightningCustomTransformDelegate()
		{
            //((UnityEvent<T0>)(object)this)._002Ector();
        }
    }
}
