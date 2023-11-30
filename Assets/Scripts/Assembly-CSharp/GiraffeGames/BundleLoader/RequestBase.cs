using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace GiraffeGames.BundleLoader
{
	internal class RequestBase
	{
		private sealed class _003CDownload_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CDownload_003Ed__8(int _003C_003E1__state)
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

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }
        }

		private float _003Cprogress_003Ek__BackingField;

		private bool _003CisError_003Ek__BackingField;

		public float progress
		{
			get
			{
				return 0f;
			}
			protected set
			{
			}
		}

		public bool isError
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public virtual IEnumerator Download()
		{
			return null;
		}
	}
}
