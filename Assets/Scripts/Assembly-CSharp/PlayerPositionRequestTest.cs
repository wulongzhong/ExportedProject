using UnityEngine;

public class PlayerPositionRequestTest : MonoBehaviour
{
	public delegate void OnComplete();

	public int startPid;

	public int endPid;

	private OnComplete onPopulationComplete;

	public void GetPlayerPositionList(OnComplete onComplete)
	{
	}

	public void OnRequestComplete(GGServerRequestsBackend.ServerRequest request)
	{
	}
}
