using System;
using UnityEngine;

namespace GiraffeGames.BundleLoader
{
	[Serializable]
	public class BundleManifest
	{
		[Serializable]
		public class PlatformHash
		{
			public RuntimePlatform platform;

			public string hash;

			public int byteLength;
		}

		public struct BundleId
		{
			public string name;

			public string uriName;

			public Hash128 hash;
		}

		[Serializable]
		public class BundleDescrption
		{
			public string name;

			public PlatformHash[] hash;

			public string[] dependencies;

			public int byteLength => 0;

			public Hash128 Hash128 => default(Hash128);

			public BundleId BundleId => default(BundleId);

			private PlatformHash GetPlatformHash()
			{
				return null;
			}

			public PlatformHash GetPlatformHash(RuntimePlatform platform)
			{
				return null;
			}
		}

		[SerializeField]
		public int minAppVersion;

		[SerializeField]
		public string downloadMessage;

		[SerializeField]
		public BundleDescrption[] bundles;

		public BundleDescrption GetBundleDescription(string bundleName)
		{
			return null;
		}
	}
}
