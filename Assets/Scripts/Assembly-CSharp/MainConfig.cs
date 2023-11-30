using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GGMatch3;
using GiraffeGames.BundleLoader;
using UnityEngine;

public class MainConfig : MonoBehaviour
{
	public class Loader
	{
		private sealed class _003CLoad_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Loader _003C_003E4__this;

			public MainConfigLoadType loadType;

			private BundleLoader _003Cloader_003E5__2;

			private BundleLoader.ManifestRequest _003CmaniReq_003E5__3;

			private BundleLoader.AssetBundleRequest _003CloadReq_003E5__4;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            object IEnumerator<object>.Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CLoad_003Ed__29(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }
        }

		private bool _003CIsDone_003Ek__BackingField;

		private bool _003CIsError_003Ek__BackingField;

		private bool _003CIsNewVersionNeeded_003Ek__BackingField;

		private float _003CProgress_003Ek__BackingField;

		private MainConfig _003Cconfig_003Ek__BackingField;

		protected bool IsDone
		{
			set
			{
			}
		}

		public bool IsError
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public bool IsNewVersionNeeded
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public float Progress
		{
			get
			{
				return 0f;
			}
			protected set
			{
			}
		}

		public bool IsDownloadMessageSet => false;

		public string DownloadMessage => null;

		public MainConfig config
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public static string RemoteUri()
		{
			return null;
		}

		private static string LocalUri()
		{
			return null;
		}

		private void DoneError()
		{
		}

		public IEnumerator Load(MainConfigLoadType loadType)
		{
			return null;
		}
	}

	[SerializeField]
	public Match3StagesDB stagesDB;

	[SerializeField]
	private List<LevelDB> levels;

	[SerializeField]
	private Dictionary<string, LevelDB> levelDBDictionary;

	[SerializeField]
	public CarsDB carsDB;

	[NonSerialized]
	private bool isInitialized;

	public LevelDB defaultLevelDB => null;

	public static string publishingLevelDBName => null;

	public LevelDB publishingLevelDB => null;

	public LevelDB NamedInstance(string levelDBName)
	{
		return null;
	}

	public void InitIfNeeded()
	{
	}

	private void Init()
	{
	}
}
