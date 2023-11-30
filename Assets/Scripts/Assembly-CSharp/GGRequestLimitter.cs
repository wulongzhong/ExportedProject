using System.Collections;
using System.Collections.Generic;

public class GGRequestLimitter : BehaviourSingleton<GGRequestLimitter>
{
	public class RunningRequest
	{
		public IEnumerator query;

		public GGServerRequestsBackend.ServerRequest request;
	}

	public int requestLimit;

	private int nextUnusedId;

	private List<GGServerRequestsBackend.ServerRequest> pendingRequests;

	private List<RunningRequest> runningRequests;

	public int GetGroupId()
	{
		return 0;
	}

	public void Add(GGServerRequestsBackend.ServerRequest request)
	{
	}

	private void Update()
	{
	}

	private void CheckRunningRequests()
	{
	}

	private void StartNewRequests()
	{
	}

	public void StopRequest(GGServerRequestsBackend.ServerRequest request)
	{
	}

	public void StopRequestsWithGroup(int groupId)
	{
	}

	public GGRequestLimitter()
	{
		//((BehaviourSingleton<>)(object)this)._002Ector();
	}
}
