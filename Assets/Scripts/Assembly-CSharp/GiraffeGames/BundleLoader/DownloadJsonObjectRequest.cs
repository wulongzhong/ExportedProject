using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.Networking;

namespace GiraffeGames.BundleLoader
{
	internal class DownloadJsonObjectRequest<T> : RequestBase
	{
		private sealed class _003CDownload_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DownloadJsonObjectRequest<T> _003C_003E4__this;

			private UnityWebRequest _003Cwww_003E5__2;

			private UnityWebRequestAsyncOperation _003Casync_003E5__3;

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
			public _003CDownload_003Ed__10(int _003C_003E1__state)
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

		private string uri;

		private T _003Cdata_003Ek__BackingField;

		private bool _003CisFromCache_003Ek__BackingField;

		public T data
		{
			get
			{
				return default(T);
			}
			protected set
			{
			}
		}

		protected bool isFromCache
		{
			set
			{
			}
		}

		public DownloadJsonObjectRequest(string uri)
		{
		}

		public override IEnumerator Download()
		{
			return null;
		}
	}
}
