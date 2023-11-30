using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningCustomTransformStateInfo
	{
		private LightningCustomTransformState _003CState_003Ek__BackingField;

		private LightningBoltParameters _003CParameters_003Ek__BackingField;

		public Vector3 BoltStartPosition;

		public Vector3 BoltEndPosition;

		public Transform Transform;

		public Transform StartTransform;

		public Transform EndTransform;

		public object UserInfo;

		private static readonly List<LightningCustomTransformStateInfo> cache;

		public LightningCustomTransformState State
		{
			get
			{
				return default(LightningCustomTransformState);
			}
			set
			{
			}
		}

		public LightningBoltParameters Parameters
		{
			set
			{
			}
		}

		public static LightningCustomTransformStateInfo GetOrCreateStateInfo()
		{
			return null;
		}

		public static void ReturnStateInfoToCache(LightningCustomTransformStateInfo info)
		{
		}
	}
}
