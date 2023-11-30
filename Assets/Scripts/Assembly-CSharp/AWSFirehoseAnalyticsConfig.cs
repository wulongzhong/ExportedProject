using UnityEngine;

public class AWSFirehoseAnalyticsConfig : ScriptableObjectSingleton<AWSFirehoseAnalyticsConfig>
{
	[SerializeField]
	public string kinesisFirehoseStreamName;

	[SerializeField]
	public bool sendEventsInEditor;

	public AWSFirehoseAnalyticsConfig()
	{
		//((ScriptableObjectSingleton<>)(object)this)._002Ector();
	}
}
