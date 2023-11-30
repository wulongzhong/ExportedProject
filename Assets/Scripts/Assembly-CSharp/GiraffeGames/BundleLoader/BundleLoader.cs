using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace GiraffeGames.BundleLoader
{
	public class BundleLoader : BehaviourSingletonInit<BundleLoader>, IDisposable
	{
		public class Request
		{
			private bool _003CIsDone_003Ek__BackingField;

			private bool _003CIsError_003Ek__BackingField;

			private float _003Cprogress_003Ek__BackingField;

			private IEnumerator _003Caction_003Ek__BackingField;

			public bool IsDone
			{
				get
				{
					return false;
				}
				protected set
				{
				}
			}

			public bool IsDownloading => false;

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

			public bool IsSuccess => false;

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

			public IEnumerator action
			{
				get
				{
					return null;
				}
				protected set
				{
				}
			}

			public virtual void CreateAction(BundleLoader loader)
			{
			}
		}

		public class AssetBundleRequest : Request
		{
			private sealed class _003CDoGetBundle_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public BundleLoader loader;

				public BundleManifest manifest;

				public BundleManifest.BundleDescrption bundle;

				public AssetBundleRequest _003C_003E4__this;

				private List<string> _003Cdependencies_003E5__2;

				private List<DownloadAssetBundleRequest> _003CdownloadDependencies_003E5__3;

				private DownloadAssetBundleRequest _003CmainBudleDownload_003E5__4;

				private bool _003CisError_003E5__5;

				private float _003CtotalCount_003E5__6;

				private IEnumerator _003Caction_003E5__7;

				private int _003Ci_003E5__8;

				private DownloadAssetBundleRequest _003Cdependancy_003E5__9;

				private IEnumerator _003CdownAction_003E5__10;

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
				public _003CDoGetBundle_003Ed__15(int _003C_003E1__state)
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

			public string bundleName;

			private bool _003CIsManifestError_003Ek__BackingField;

			private AssetBundle _003CassetBundle_003Ek__BackingField;

			protected bool IsManifestError
			{
				set
				{
				}
			}

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

			public AssetBundleRequest(string bundleName)
			{
			}

			public override void CreateAction(BundleLoader loader)
			{
			}

			private void DoneManifestError()
			{
			}

			private void DoneDownloadError()
			{
			}

			private void GetAllDependencies(List<string> outList, BundleManifest manifest, BundleManifest.BundleDescrption bundle)
			{
			}

			public int TotalBytesToDownload(BundleLoader loader)
			{
				return 0;
			}

			private IEnumerator DoGetBundle(BundleManifest manifest, BundleManifest.BundleDescrption bundle, BundleLoader loader)
			{
				return null;
			}
		}

		public class ManifestRequest : Request
		{
			private sealed class _003CGetManifests_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public BundleLoader loader;

				public ManifestRequest _003C_003E4__this;

				private BundleManifest _003Cmanifest_003E5__2;

				private string[] _003CbaseUris_003E5__3;

				private int _003Ci_003E5__4;

				private DownloadJsonObjectRequest<BundleManifest> _003Cdownload_003E5__5;

				private IEnumerator _003Caction_003E5__6;

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
				public _003CGetManifests_003Ed__3(int _003C_003E1__state)
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

			public string manifestName;

			public override void CreateAction(BundleLoader loader)
			{
			}

			private IEnumerator GetManifests(BundleLoader loader)
			{
				return null;
			}
		}

		private class AssetBundleContainer
		{
			public AssetBundle bundle;

			public string name;

			public Hash128 hash;

			public string[] dependencies;
		}

		private sealed class _003CDoRequest_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Request request;

			public BundleLoader _003C_003E4__this;

			private IEnumerator _003Caction_003E5__2;

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
			public _003CDoRequest_003Ed__9(int _003C_003E1__state)
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

		private List<Request> requests;

		private Dictionary<string, AssetBundleContainer> activeBundles;

		private BundleManifest manifest;

		private IEnumerator downloadAction;

		private string[] baseUris;

		private string[] manifestBaseUris;

		public bool IsDownloadMessageSet => false;

		public string DownloadMessage => null;

		public bool IsNewVersionNeeded => false;

		public int TotalBytesToDownload(string bundleName)
		{
			return 0;
		}

		public AssetBundleRequest LoadBundle(string bundleName)
		{
			return null;
		}

		public ManifestRequest LoadManifest()
		{
			return null;
		}

		public void AddRequest(Request request)
		{
		}

		private void TryStartRequest(bool force)
		{
		}

		private IEnumerator DoRequest(Request request)
		{
			return null;
		}

		public void InitUris(string[] manifestUris, string[] assetUris)
		{
		}

		public static string LocalUri()
		{
			return null;
		}

		public static string SimulatedUri()
		{
			return null;
		}

		public static string StreamingAssetsFolder()
		{
			return null;
		}

		private BundleManifest.BundleDescrption GetBundleDescription(BundleManifest manifest, string bundleName)
		{
			return null;
		}

		public bool IsActiveBundleOK(string bundleName)
		{
			return false;
		}

		private bool IsActiveBundleOk(BundleManifest manifest, BundleManifest.BundleDescrption bundle)
		{
			return false;
		}

		public void UnloadBundle(string bundleName)
		{
		}

		private AssetBundleContainer GetBundleContainer(string bundleName)
		{
			return null;
		}

		private void AddActiveAssetBundle(AssetBundle bundle, BundleManifest.BundleDescrption descrption)
		{
		}

		public static string JoinUri(string path, string name)
		{
			return null;
		}

		private void Update()
		{
		}

		public void Dispose()
		{
		}

		public BundleLoader()
		{
			//((BehaviourSingletonInit<>)(object)this)._002Ector();
		}
	}
}
