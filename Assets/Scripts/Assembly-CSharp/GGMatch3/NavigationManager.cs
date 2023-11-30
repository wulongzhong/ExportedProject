using System;
using System.Collections.Generic;
using UnityEngine;

namespace GGMatch3
{
	public class NavigationManager : MonoBehaviour
	{
		[Serializable]
		public class ObjectDefinition
		{
			public GameObject gameObject;

			public bool isScreen;
		}

		public class HistoryObject
		{
			public GameObject gameObject;

			public void SetActive(bool active)
			{
			}

			public void Hide()
			{
			}

			public void Show()
			{
			}
		}

		[SerializeField]
		private bool startInApp;

		[SerializeField]
		private bool showTermsOfServiceOnStart;

		[SerializeField]
		private string layerToLoadAtStart;

		[SerializeField]
		private List<ObjectDefinition> objectsList;

		private static NavigationManager instance_;

		private int _003CapplicationPausedTimes_003Ek__BackingField;

		public List<HistoryObject> history;

		public static NavigationManager instance => null;

		public int applicationPausedTimes
		{
			get
			{
				return 0;
			}
			protected set
			{
			}
		}

		public HistoryObject CurrentScreen => null;

		private void OnApplicationFocus(bool paused)
		{
		}

		public ObjectDefinition GetObjectByName(string name)
		{
			return null;
		}

		public Camera GetCamera()
		{
			return null;
		}

		public T GetObject<T>() where T : MonoBehaviour
		{
			return null;
		}

		public bool HasInHistory<T>() where T : MonoBehaviour
		{
			return false;
		}

		public T GetHistoryObjectBeh<T>() where T : MonoBehaviour
		{
			return null;
		}

		public HistoryObject GetHistoryObject<T>() where T : MonoBehaviour
		{
			return null;
		}

		public bool IsCurrentScreen<T>() where T : Component
		{
			return false;
		}

		public bool IsCurrentScreen(GameObject go)
		{
			return false;
		}

		private void Awake()
		{
		}

		private void LoadStartLayer()
		{
		}

		public void Push(MonoBehaviour behaviour, bool isModal = false)
		{
		}

		public void Push(GameObject screen, bool isModal = false)
		{
		}

		public void PopMultiple(int screensToPopCount)
		{
		}

		public void Pop(bool activateNextScreen = true)
		{
		}

		private void Update()
		{
		}

		private void TryToGoBack()
		{
		}

		private void _003CAwake_003Eb__25_0(bool success)
		{
		}
	}
}
