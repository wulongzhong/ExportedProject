using System;
using System.Collections.Generic;
using Amazon;
using Amazon.CognitoIdentity;
using Amazon.KinesisFirehose;
using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using GGMatch3;
using ProtoModels;
using UnityEngine;

public class AWSFirehoseAnalytics : MonoBehaviour
{
	public class CustomEvent
	{
		protected Dictionary<string, double?> metricDictionary;

		protected Dictionary<string, string> attributeDictionary;

		protected Dictionary<string, object> baseDictionary;

		public CustomEvent(string eventType)
		{
		}

		public CustomEvent()
		{
		}

		private void AddBasicAttributes()
		{
		}

		public void AddMetric(string name, double value)
		{
		}

		public void AddAttribute(string name, string attribute)
		{
		}

		private string Escape(string str)
		{
			return null;
		}

		private string DictionaryToJSON(Dictionary<string, object> dict)
		{
			return null;
		}

		private string DictionaryToJSON(Dictionary<string, string> dict)
		{
			return null;
		}

		private string DictionaryToJSON(Dictionary<string, double?> dict)
		{
			return null;
		}

		public virtual string SerializeToJSON()
		{
			return null;
		}
	}

	public class MonetizationEvent : CustomEvent
	{
		public string Currency
		{
			set
			{
			}
		}

		public double? ItemPrice
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ItemPriceFormatted
		{
			set
			{
			}
		}

		public string ProductId
		{
			set
			{
			}
		}

		public string Store
		{
			set
			{
			}
		}

		public MonetizationEvent()
			: base(null)
		{
		}
	}

	public class AnalyticsManager
	{
		public virtual void RecordEvent(CustomEvent ce)
		{
		}

		public virtual void OnDisable()
		{
		}

		public virtual void OnUpdate()
		{
		}
	}

	public class AnalyticsProducerConsumerManager : AnalyticsManager
	{
		private class Producer
		{
			private AnalyticsProducerConsumerManager manager;

			public Producer(AnalyticsProducerConsumerManager manager)
			{
			}

			public void RecordEvent(CustomEvent ce)
			{
			}
		}

		private class Consumer
		{
			private enum Status
			{
				Available = 0,
				Busy = 1
			}

			private AmazonServiceCallback<PutRecordBatchRequest, PutRecordBatchResponse> externalCallback;

			private AnalyticsProducerConsumerManager manager;

			private float timeInterval;

			private int maxBeforeSend;

			private int maxPerBatch;

			private int maxRecordsLocalStack;

			private float trashPercentage;

			private CognitoAWSCredentials credentials;

			private RegionEndpoint kinesisRegion;

			private string S3Name;

			private AmazonKinesisFirehoseClient client_;

			private float timer;

			private List<EventLog.Event> localStack_;

			private Status status;

			private AmazonKinesisFirehoseClient client => null;

			private List<EventLog.Event> localStack => null;

			public Consumer(CognitoAWSCredentials credentials, RegionEndpoint kinesisRegion, string S3Name, AnalyticsProducerConsumerManager manager, float timeInterval, int maxBeforeSend, int maxPerBatch, int maxRecordsLocalStack, float trashPercentage, AmazonServiceCallback<PutRecordBatchRequest, PutRecordBatchResponse> callback = null)
			{
			}

			public void Consume()
			{
			}

			public void DebugConsume()
			{
			}

			public void ConsumeRows(int maxRows)
			{
			}

			private void MaintainStack()
			{
			}

			private void AsynchPutRecordCallback(AmazonServiceResult<PutRecordBatchRequest, PutRecordBatchResponse> res)
			{
			}
		}

		private Consumer consumer;

		private Producer producer;

		private AWSFirehoseAnalytics analytics;

		private EventLog model => null;

		private void Save()
		{
		}

		public override void OnDisable()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void RecordEvent(CustomEvent ce)
		{
		}

		public AnalyticsProducerConsumerManager(AWSFirehoseAnalytics analytics, CognitoAWSCredentials credentials, RegionEndpoint kinesisRegion, string S3Name, float timeInterval, int maxBeforeSend, int maxPerBatch, int maxRecordsLocalStack, float trashPercentage, AmazonServiceCallback<PutRecordBatchRequest, PutRecordBatchResponse> callback)
		{
		}
	}

	private static bool isAttached;

	protected GGNotificationCenter.EventDispatcher eventDispatcher;

	public static string FileName;

	public DateTime lastTimestamp;

	public string _sessionID;

	public float timeInterval;

	public int maxRowsInBatch;

	public int maxRowsBeforeSend;

	public int bytesPerRecordEstimation;

	public int maxPauseBetweenSameSessionSeconds;

	public float localStackTrashingPercentage;

	public int maxBytes;

	public string IdentityPoolId;

	private CognitoAWSCredentials _credentials;

	public string CognitoIdentityRegion;

	public string KinsesisRegion;

	public AnalyticsManager analyticsManager;

	public bool supportIOS;

	private EventLog _model;

	public int sessionNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool isTester => false;

	public string sessionID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int maxRecordsInLocalStack => 0;

	protected string S3Name => null;

	private RegionEndpoint _CognitoIdentityRegion => null;

	private RegionEndpoint _KinsesisRegion => null;

	public bool isSupportedPlatform => false;

	private EventLog model => null;

	public static void AttachAmazonToGameObject(GameObject gameObject)
	{
	}

	private void Start()
	{
	}

	public void UsedOnlyForAOTCodeGeneration()
	{
	}

	private void AsynchPutRecordCallback(AmazonServiceResult<PutRecordRequest, PutRecordResponse> res)
	{
	}

	private void AsynchPutRecordBatchCallback(AmazonServiceResult<PutRecordBatchRequest, PutRecordBatchResponse> res)
	{
	}

	private void OnDisable()
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnApplicationFocus(bool pauseStatus)
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private void OnApplicationQuit()
	{
	}

	protected void AddBaseAttributesToEvent(CustomEvent customEvent)
	{
	}

	protected CustomEvent CreateEvent(string eventName)
	{
		return null;
	}

	public void RecordStageStartedEvent(object data)
	{
	}

	public void RecordStageCompletedEvent(object data)
	{
	}

	public void RecordStageFailedEvent(object data)
	{
	}

	public void RecordMovesBoughtEvent(object data)
	{
	}

	public void RecordLivesRefilledEvent(object data)
	{
	}

	protected MonetizationEvent CreateMonetizationEvent(OffersDB.ProductDefinition inApp)
	{
		return null;
	}

	public void RecordIAPEvent(object data)
	{
	}

	public void RecordRoomItemBoughtEvent(object data)
	{
	}

	public void RecordRoomItemChangedEvent(object data)
	{
	}

	public void RecordBoosterUsedEvent(object data)
	{
	}

	public void RateDialogEvent(object data)
	{
	}

	private void RecordEvent(CustomEvent customEvent)
	{
	}

	private void AddStageDataToEvent(CustomEvent customEvent, GameScreen.StageState stageState)
	{
	}

	private void OnDestroy()
	{
	}

	public void ResetModel()
	{
	}

	private void Save()
	{
	}

	public static int UnixTimestamp(DateTime time)
	{
		return 0;
	}

	public static byte[] ToByteArray(string str)
	{
		return null;
	}
}
