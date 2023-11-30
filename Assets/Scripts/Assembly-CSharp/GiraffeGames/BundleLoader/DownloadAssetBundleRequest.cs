using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Networking;

namespace GiraffeGames.BundleLoader
{
	internal class DownloadAssetBundleRequest : RequestBase
	{
		private sealed class _003CDownload_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DownloadAssetBundleRequest _003C_003E4__this;

			private AssetBundle _003CassetBundle_003E5__2;

			private int _003Ci_003E5__3;

			private UnityWebRequest _003Cwww_003E5__4;

			private UnityWebRequestAsyncOperation _003Crequest_003E5__5;

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
			public _003CDownload_003Ed__9(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
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

		private string[] baseUris;

		private BundleManifest.BundleId bundleId;

		private AssetBundle _003CassetBundle_003Ek__BackingField;

		public AssetBundle assetBundle
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public bool IsCached => false;

		public DownloadAssetBundleRequest(string[] baseUris, BundleManifest.BundleId bundleId)
		{
		}

		public override IEnumerator Download()
		{
			return null;
		}
	}
}
