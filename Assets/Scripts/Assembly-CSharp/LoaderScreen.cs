using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class LoaderScreen : MonoBehaviour
{
	private enum ShowType
	{
		Loading = 0,
		Retry = 1
	}

	public delegate void OnConfigReceieved(MainConfig config);

	public class LoadMainConfigArgs
	{
		public MainConfigLoadType loadType;

		public Action<MainConfig> onComplete;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<bool> _003C_003E9__38_0;

		internal void _003CDoLoadMainConfig_003Eb__38_0(bool _003Cp0_003E)
		{
		}
	}

	private sealed class _003CDoLoadMainConfig_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoaderScreen _003C_003E4__this;

		public LoadMainConfigArgs loadMain;

		private MainConfig.Loader _003Cloader_003E5__2;

		private IEnumerator _003Caction_003E5__3;

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
		public _003CDoLoadMainConfig_003Ed__38(int _003C_003E1__state)
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

	[SerializeField]
	private bool failInEditor;

	public List<object> loadingRequests;

	[SerializeField]
	private RectTransform loadBar;

	[SerializeField]
	private Transform loadingContainer;

	[SerializeField]
	private Transform retryContainer;

	private IEnumerator action;

	private MainConfig _003Cconfig_003Ek__BackingField;

	private MainConfigLoadType _003CloadType_003Ek__BackingField;

	private object currentLoading;

	[NonSerialized]
	private DateTime lastLoadedTime;

	[NonSerialized]
	private bool isPaused;

	public static LoaderScreen instance => null;

	public static MainConfig mainConfig => null;

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

	public MainConfigLoadType loadType
	{
		get
		{
			return default(MainConfigLoadType);
		}
		protected set
		{
		}
	}

	public bool isCurrentlyLoadingMain => false;

	public bool NeedsLoad => false;

	public event OnConfigReceieved onConfig
	{
		add
		{
		}
		remove
		{
		}
	}

	public void GetConfig(Action<MainConfig> onReceieved, MainConfigLoadType loadType)
	{
	}

	private void Show(LoadMainConfigArgs args)
	{
	}

	private void Show(ShowType type)
	{
	}

	private void StartLoad()
	{
	}

	private void LoadRequest(object req)
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private IEnumerator DoLoadMainConfig(LoadMainConfigArgs loadMain)
	{
		return null;
	}

	public void ApplicationChangedFocus(bool focus)
	{
	}

	public void ButtonCallback_OnRetry()
	{
	}
}
