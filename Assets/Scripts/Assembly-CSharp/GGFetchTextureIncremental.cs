using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GGFetchTextureIncremental : BehaviourSingletonInit<GGFetchTextureIncremental>
{
	public class TextureResult
	{
		public int textureSetId;

		public Texture2D texture;
	}

	public class TextureRequest
	{
		public int textureSetId;

		public string url;
	}

	public delegate void OnIncrementComplete(List<TextureResult> textureIncrement, bool isFinished);

	private class Request
	{
		public List<TextureRequest> request;

		public OnIncrementComplete incrementCallback;

		public List<TextureResult> result;

		public int currentIncrement;
	}

	private sealed class _003CQueryTexture_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TextureRequest request;

		public GGFetchTextureIncremental _003C_003E4__this;

		private TextureResult _003CtextureResult_003E5__2;

		private WWW _003Cwww_003E5__3;

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
		public _003CQueryTexture_003Ed__17(int _003C_003E1__state)
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

	public int texturesInOneIncrement;

	public TimeSpan cacheTimeToLive;

	private int nextUnusedTicket;

	private Dictionary<int, Request> requests;

	private Queue idTickets;

	private int currentTicket;

	public override void Init()
	{
	}

	public int GetTicketForFetchTexturesQueue(List<TextureRequest> request, OnIncrementComplete incrementCallback)
	{
		return 0;
	}

	private void QueueNewRequestRecord(List<TextureRequest> request, OnIncrementComplete incrementCallback, int requestId)
	{
	}

	private void BeginProcessingNewRequest()
	{
	}

	private int GetNextTicket()
	{
		return 0;
	}

	private void TryFetchIncrement()
	{
	}

	private void FetchIncrement()
	{
	}

	private IEnumerator QueryTexture(TextureRequest request)
	{
		return null;
	}

	private Texture2D TryGetFromCache(string key)
	{
		return null;
	}

	private void TryCacheTexture(WWW query)
	{
	}

	private void ReceiveTexture(TextureResult result)
	{
	}

	private bool IsIncrementProcessingFinished()
	{
		return false;
	}

	private void OnIncrementGetFinished()
	{
	}

	private void AdvanceRequestsToNextIncrement()
	{
	}

	private bool IsCurrentRequestProcessed()
	{
		return false;
	}

	public void StopRequest(int requestTicket)
	{
	}

	private void StopCoroutinesForTicket(int requestTicket)
	{
	}

	private void RemoveRequest(int requestTicket)
	{
	}

	public GGFetchTextureIncremental()
	{
		//((BehaviourSingletonInit<>)(object)this)._002Ector();
	}
}
