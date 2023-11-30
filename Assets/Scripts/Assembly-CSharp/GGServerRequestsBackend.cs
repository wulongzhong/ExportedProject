using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using ProtoModels;
using UnityEngine;

public class GGServerRequestsBackend : BehaviourSingletonInit<GGServerRequestsBackend>
{
	public delegate void OnComplete(ServerRequest request);

	public class UrlBuilder
	{
		private string urlBase;

		private Dictionary<string, string> paramPairs;

		private Dictionary<string, List<string>> paramListPairs;

		private string data;

		public static string GetTimestampAttributeName()
		{
			return null;
		}

		public UrlBuilder(string hostName)
		{
		}

		public UrlBuilder addPath(string path)
		{
			return null;
		}

		public UrlBuilder addData(string newData)
		{
			return null;
		}

		public UrlBuilder addParams(string paramName, string paramVal)
		{
			return null;
		}

		public UrlBuilder addParams(string paramName, int paramVal)
		{
			return null;
		}

		public string SignAndToString(string publicKey, string privateKey)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}

	public class ServerRequest
	{
		public enum RequestStatus
		{
			Success = 0,
			Error = 1,
			NotSent = 2
		}

		public delegate void OnComplete(ServerRequest request);

		private sealed class _003CRequestCoroutine_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ServerRequest _003C_003E4__this;

			private WWW _003Cquery_003E5__2;

			private float _003Ctime_003E5__3;

			private bool _003Ctimeout_003E5__4;

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
			public _003CRequestCoroutine_003Ed__30(int _003C_003E1__state)
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

		public OnComplete onComplete;

		public int groupId;

		public float progress;

		public float timeoutSec;

		public CacheGetStrategy cacheGetStrategy;

		public CacheStategy cache;

		public TimeSpan cacheTimeToLive;

		public RequestStatus status;

		private string _003CerrorMessage_003Ek__BackingField;

		protected object responseObj;

		public string errorMessage
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public T GetResponse<T>() where T : class
		{
			return null;
		}

		protected virtual string GetUrl()
		{
			return null;
		}

		protected virtual WWW CreateQuery()
		{
			return null;
		}

		protected virtual void ParseQueryResponse(WWW query)
		{
		}

		protected virtual void ParseResponse(byte[] bytes)
		{
		}

		public virtual string GetCacheKey(string url)
		{
			return null;
		}

		private string StripParamFromUrl(string url, string paramName)
		{
			return null;
		}

		private string RemoveChangingParams(string url)
		{
			return null;
		}

		protected virtual bool TryGetFromMemoryCache(string url)
		{
			return false;
		}

		protected virtual bool TryGetFromFileCache(string url)
		{
			return false;
		}

		protected virtual void CacheResults(WWW query)
		{
		}

		protected virtual void CacheToFile(WWW query)
		{
		}

		public virtual bool TryGetFromCache()
		{
			return false;
		}

		public virtual IEnumerator RequestCoroutine()
		{
			return null;
		}
	}

	public class ProtoRequest<T> : ServerRequest where T : class
	{
		public T response
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override WWW CreateQuery()
		{
			return null;
		}

		protected override void ParseResponse(byte[] bytes)
		{
		}
	}

	private interface NonceSetRequest
	{
		void SetNonce(string nonce);
	}

	private interface PidSetRequest
	{
		void SetPid(string pid);
	}

	public class ProtoRequestPid<T> : ProtoRequest<T>, PidSetRequest where T : class
	{
		public virtual void SetPid(string pid)
		{
		}

		public ProtoRequestPid()
		{
			//((ProtoRequest<>)(object)this)._002Ector();
		}
	}

	public class UploadLeadDataRequest : ProtoRequestPid<StatusMessage>
	{
		public string nonce;
	}

	public class EventLeadRequest : ProtoRequestPid<EventLeads>
	{
	}

	public class EventScoreUpdateRequest : ProtoRequestPid<UpdateLeadResponse>
	{
		public string nonce;
	}

	public class NonceRequest : ServerRequest
	{
		protected override string GetUrl()
		{
			return null;
		}

		protected override WWW CreateQuery()
		{
			return null;
		}
	}

	public class LeaderboardsRequest : ProtoRequestPid<Lead>
	{
	}

	public class UpdateAppMessageRead : ProtoRequestPid<StatusMessage>
	{
	}

	public class AppMessagesRequest : ProtoRequestPid<MessageList>
	{
	}

	public class SegmentedLeaderboardsRequest : ProtoRequestPid<CombinationLeads>
	{
	}

	public class ActiveCompetitionRequest : ProtoRequest<CompetitionMessage>
	{
	}

	public class UpdateRequest : ProtoRequestPid<StatusMessage>
	{
		private string pid;

		private string app;

		private int sR;

		private string n;

		private string c;

		private int s;

		private string imageUrl;

		private int version;

		public string nonce;

		public int rank2;

		public string room;

		public UpdateRequest(int sR, string n, string c)
		{
			//((ProtoRequestPid<>)(object)this)._002Ector();
		}

		public override void SetPid(string pid)
		{
		}

		public void SetScore(int s)
		{
		}

		protected override string GetUrl()
		{
			return null;
		}

		protected override WWW CreateQuery()
		{
			return null;
		}
	}

	public class IdRequest : ProtoRequest<Pid>
	{
		private string fbId;

		private string gId;

		private string installId;

		private string app;

		private string fbIdForApp;

		public IdRequest()
		{
			//((ProtoRequest<>)(object)this)._002Ector();
		}

		protected override string GetUrl()
		{
			return null;
		}

		protected override WWW CreateQuery()
		{
			return null;
		}
	}

	public class GetPrizesRequest : ProtoRequestPid<Lead>
	{
	}

	public class GetPrizesRequestCombinationLead : ProtoRequestPid<CombinationLeads>
	{
	}

	public class AckPrizesRequest : ProtoRequestPid<StatusMessage>
	{
	}

	public class CloudSyncRequest : ProtoRequestPid<CloudSyncData>
	{
		public string nonce;

		private int _003CsnapshotId_003Ek__BackingField;

		private string _003CsnapshotGUID_003Ek__BackingField;

		public int snapshotId
		{
			get
			{
				return 0;
			}
			protected set
			{
			}
		}

		public string snapshotGUID
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public override void SetPid(string pid)
		{
		}

		public void SetVersionInfo(int snapshotId, string snapshotGUID)
		{
		}

		public virtual CloudSyncData GetRequestData()
		{
			return null;
		}

		public CloudSyncRequest()
		{
			//((ProtoRequestPid<>)(object)this)._002Ector();
		}
	}

	public class GetCloudSyncDataRequest : CloudSyncRequest
	{
		private string app;

		private string pid;

		public override void SetPid(string pid)
		{
		}

		public override CloudSyncData GetRequestData()
		{
			return null;
		}

		protected override string GetUrl()
		{
			return null;
		}

		protected override WWW CreateQuery()
		{
			return null;
		}
	}

	public class UpdateCloudSyncDataRequest : CloudSyncRequest
	{
		private string app;

		private string pid;

		private string data;

		public override void SetPid(string pid)
		{
		}

		public void AddData(CloudSyncData syncData)
		{
		}

		public override CloudSyncData GetRequestData()
		{
			return null;
		}

		protected override string GetUrl()
		{
			return null;
		}

		protected override WWW CreateQuery()
		{
			return null;
		}
	}

	public class FacebookLoginRequest : ProtoRequest<FBLogin>
	{
		public FacebookLoginRequest()
		{
			//((ProtoRequest<>)(object)this)._002Ector();
		}
	}

	public class FacebookInviteFriends : ProtoRequestPid<InvitableFriends>
	{
	}

	public class FacebookPlayingFriends : ProtoRequestPid<InvitableFriends>
	{
	}

	public class GGServerPlayerMessages : ProtoRequestPid<ServerMessages>
	{
		private string app;

		private string pid;

		public GGServerPlayerMessages()
		{
			//((ProtoRequestPid<>)(object)this)._002Ector();
		}

		public override void SetPid(string pid)
		{
		}

		protected override string GetUrl()
		{
			return null;
		}

		protected override WWW CreateQuery()
		{
			return null;
		}
	}

	public class GGServerMarkMessagesAsRead : ProtoRequestPid<StatusMessage>
	{
	}

	public class GGServerGetFriendProfiles : ProtoRequestPid<FriendsProfiles>
	{
	}

	public class GetPlayerPositionsRequest : ProtoRequestPid<PlayerPositions>
	{
		private string app;

		private string pid;

		private string data;

		public GetPlayerPositionsRequest()
		{
			//((ProtoRequestPid<>)(object)this)._002Ector();
		}

		public override void SetPid(string pid)
		{
		}

		public void AddData(PlayerPositions players)
		{
		}

		protected override string GetUrl()
		{
			return null;
		}

		protected override WWW CreateQuery()
		{
			return null;
		}
	}

	private sealed class _003CDoCallWhenRequestComplete_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ServerRequest request;

		public Action<ServerRequest> onComplete;

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
		public _003CDoCallWhenRequestComplete_003Ed__61(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass64_0
	{
		public ServerRequest playerId;

		internal void _003CDoUpdateEventsLeaderboards_003Eb__0(ServerRequest pid)
		{
		}
	}

	private sealed class _003CDoUpdateEventsLeaderboards_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GGServerRequestsBackend _003C_003E4__this;

		private _003C_003Ec__DisplayClass64_0 _003C_003E8__1;

		public EventScoreUpdateRequest updateRequest;

		public OnComplete onComplete;

		private NonceRequest _003CnonceReq_003E5__2;

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
		public _003CDoUpdateEventsLeaderboards_003Ed__64(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass69_0
	{
		public ServerRequest playerId;

		internal void _003CDoUpdateUser_003Eb__0(ServerRequest pid)
		{
		}
	}

	private sealed class _003CDoUpdateUser_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GGServerRequestsBackend _003C_003E4__this;

		private _003C_003Ec__DisplayClass69_0 _003C_003E8__1;

		public UpdateRequest update;

		public OnComplete onComplete;

		private NonceRequest _003CnonceReq_003E5__2;

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
		public _003CDoUpdateUser_003Ed__69(int _003C_003E1__state)
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

	private sealed class _003CGetPlayerId_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GGServerRequestsBackend _003C_003E4__this;

		public OnComplete onComplete;

		private IdRequest _003CidRequest_003E5__2;

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
		public _003CGetPlayerId_003Ed__71(int _003C_003E1__state)
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

	private sealed class _003CGetFacebookLogin_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GGServerRequestsBackend _003C_003E4__this;

		public OnComplete onComplete;

		private FacebookLoginRequest _003CloginRequest_003E5__2;

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
		public _003CGetFacebookLogin_003Ed__72(int _003C_003E1__state)
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

	private sealed class _003CDoRequest_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GGServerRequestsBackend _003C_003E4__this;

		public ActiveCompetitionRequest req;

		public OnComplete onComplete;

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
		public _003CDoRequest_003Ed__74(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass80_0
	{
		public ServerRequest playerId;

		internal void _003CDoSyncCsData_003Eb__0(ServerRequest pid)
		{
		}
	}

	private sealed class _003CDoSyncCsData_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GGServerRequestsBackend _003C_003E4__this;

		private _003C_003Ec__DisplayClass80_0 _003C_003E8__1;

		public CloudSyncRequest dataRequest;

		public OnComplete onComplete;

		private NonceRequest _003CnonceReq_003E5__2;

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
		public _003CDoSyncCsData_003Ed__80(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass82_0
	{
		public ServerRequest playerId;

		internal void _003CDoUploadLeadData_003Eb__0(ServerRequest pid)
		{
		}
	}

	private sealed class _003CDoUploadLeadData_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GGServerRequestsBackend _003C_003E4__this;

		private _003C_003Ec__DisplayClass82_0 _003C_003E8__1;

		public UploadLeadDataRequest dataRequest;

		public OnComplete onComplete;

		private NonceRequest _003CnonceReq_003E5__2;

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
		public _003CDoUploadLeadData_003Ed__82(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public PidSetRequest setPid;

		internal void _003CDoExecuteAllInterfacesRequest_003Eb__0(ServerRequest pid)
		{
		}
	}

	private sealed class _003CDoExecuteAllInterfacesRequest_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ServerRequest request;

		public GGServerRequestsBackend _003C_003E4__this;

		public OnComplete onComplete;

		private NonceSetRequest _003CsetNonce_003E5__2;

		private NonceRequest _003CnonceReq_003E5__3;

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
		public _003CDoExecuteAllInterfacesRequest_003Ed__93(int _003C_003E1__state)
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

	private sealed class _003CDoExecuteNonceRequest_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ServerRequest request;

		public GGServerRequestsBackend _003C_003E4__this;

		public OnComplete onComplete;

		private NonceSetRequest _003CsetNonce_003E5__2;

		private NonceRequest _003CnonceReq_003E5__3;

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
		public _003CDoExecuteNonceRequest_003Ed__94(int _003C_003E1__state)
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

	private sealed class _003CDoExecuteRequest_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GGServerRequestsBackend _003C_003E4__this;

		public ServerRequest request;

		public OnComplete onComplete;

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
		public _003CDoExecuteRequest_003Ed__95(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass96_0<T> where T : class
	{
		public ServerRequest playerId;

		public ProtoRequestPid<T> request;

		internal void _003CDoExecuteRequestWithPid_003Eb__0(ServerRequest pid)
		{
		}
	}

	private sealed class _003CDoExecuteRequestWithPid_003Ed__96<T> : IEnumerator<object>, IEnumerator, IDisposable where T : class
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProtoRequestPid<T> request;

		public GGServerRequestsBackend _003C_003E4__this;

		private _003C_003Ec__DisplayClass96_0<T> _003C_003E8__1;

		public OnComplete onComplete;

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
		public _003CDoExecuteRequestWithPid_003Ed__96(int _003C_003E1__state)
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

	protected RequestsBackendStorage storage;

	protected string storageFilename;

	private string memoryCachedPlayerId;

	public string cachedPlayerId
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public void ResetCache()
	{
	}

	public void Save()
	{
	}

	public override void Init()
	{
	}

	public void GetCompetitionLeaderboards(LeaderboardsRequest lead, OnComplete onComplete)
	{
	}

	public Coroutine CallWhenRequestComplete(ServerRequest request, Action<ServerRequest> onComplete)
	{
		return null;
	}

	private IEnumerator DoCallWhenRequestComplete(ServerRequest request, Action<ServerRequest> onComplete)
	{
		return null;
	}

	public void GetEventsLeaderboards(EventLeadRequest lead, OnComplete onComplete)
	{
	}

	public void UpdateEventsLeaderboards(EventScoreUpdateRequest updateRequest, OnComplete onComplete)
	{
	}

	private IEnumerator DoUpdateEventsLeaderboards(EventScoreUpdateRequest updateRequest, OnComplete onComplete)
	{
		return null;
	}

	public void GetAppMessagesRequest(AppMessagesRequest messageRequest, OnComplete onComplete)
	{
	}

	public void UpdateAppMessagesRequest(UpdateAppMessageRead messageRequest, OnComplete onComplete)
	{
	}

	public void GetSegmentedCompetitionLeaderboards(SegmentedLeaderboardsRequest lead, OnComplete onComplete)
	{
	}

	public void UpdateUser(UpdateRequest update, OnComplete onComplete)
	{
	}

	private IEnumerator DoUpdateUser(UpdateRequest update, OnComplete onComplete)
	{
		return null;
	}

	public void ExecuteGetPlayerId(OnComplete onComplete)
	{
	}

	public IEnumerator GetPlayerId(OnComplete onComplete)
	{
		return null;
	}

	public IEnumerator GetFacebookLogin(OnComplete onComplete)
	{
		return null;
	}

	public void GetActiveCompetition(ActiveCompetitionRequest req, OnComplete onComplete)
	{
	}

	private IEnumerator DoRequest(ActiveCompetitionRequest req, OnComplete onComplete)
	{
		return null;
	}

	public void GetPrizes(GetPrizesRequest getPrizesRequest, OnComplete onComplete)
	{
	}

	public void GetCombinationPrizes(GetPrizesRequestCombinationLead getPrizesRequest, OnComplete onComplete)
	{
	}

	public void AckPrizes(AckPrizesRequest ackPrizesRequest, OnComplete onComplete)
	{
	}

	public Coroutine GetCSData(CloudSyncRequest dataRequest, OnComplete onComplete)
	{
		return null;
	}

	public void UpdateCSData(UpdateCloudSyncDataRequest dataRequest, OnComplete onComplete)
	{
	}

	private IEnumerator DoSyncCsData(CloudSyncRequest dataRequest, OnComplete onComplete)
	{
		return null;
	}

	public void UploadLeadData(UploadLeadDataRequest dataRequest, OnComplete onComplete)
	{
	}

	private IEnumerator DoUploadLeadData(UploadLeadDataRequest dataRequest, OnComplete onComplete)
	{
		return null;
	}

	public void GetFacebookInvites(FacebookInviteFriends inviteRequest, OnComplete onComplete)
	{
	}

	public void GetFacebookPlayers(FacebookPlayingFriends playersRequest, OnComplete onComplete)
	{
	}

	public void GetMessagesForPlayer(GGServerPlayerMessages messagesRequest, OnComplete onComplete)
	{
	}

	public void MarkMessagesAsRead(GGServerMarkMessagesAsRead markAsReadRequest, OnComplete onComplete)
	{
	}

	public void GetFriendProfiles(GGServerGetFriendProfiles request, OnComplete onComplete)
	{
	}

	public void GetPlayerPositionList(GetPlayerPositionsRequest request, OnComplete onComplete)
	{
	}

	public void ExecuteRequest(ServerRequest request, OnComplete onComplete)
	{
	}

	public void ExecuteRequestWithPid<T>(ProtoRequestPid<T> request, OnComplete onComplete) where T : class
	{
	}

	public void ExecuteRequestWithNonce(ServerRequest request, OnComplete onComplete)
	{
	}

	public void ExecuteRequestAllInterfacesRequest(ServerRequest request, OnComplete onComplete)
	{
	}

	private IEnumerator DoExecuteAllInterfacesRequest(ServerRequest request, OnComplete onComplete)
	{
		return null;
	}

	private IEnumerator DoExecuteNonceRequest(ServerRequest request, OnComplete onComplete)
	{
		return null;
	}

	private IEnumerator DoExecuteRequest(ServerRequest request, OnComplete onComplete)
	{
		return null;
	}

	private IEnumerator DoExecuteRequestWithPid<T>(ProtoRequestPid<T> request, OnComplete onComplete) where T : class
	{
		return null;
	}

	public static DateTime GetDateTimeCompEnd(long seconds)
	{
		return default(DateTime);
	}

	public GGServerRequestsBackend()
	{
		//((BehaviourSingletonInit<>)(object)this)._002Ector();
	}
}
