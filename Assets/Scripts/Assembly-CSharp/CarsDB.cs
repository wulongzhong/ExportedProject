using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GiraffeGames.BundleLoader;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]
public class CarsDB : ScriptableObject
{
	[Serializable]
	public class Car
	{
		public string name;

		public string sceneName;

		public string locationSceneName;

		public string editorAssetPathLocationScene;

		public string displayName;

		public string description;

		public bool getDirectlyFromFileInEditor;

		public string assetBundleURLOSX;

		public string assetBundleURLAndroid;

		public string assetBundleURLIOS;

		public bool isOnlyForEditor;

		public Sprite cardSprite;

		public GiftBoxScreen.GiftsDefinition giftDefinition;

		public int totalPrice;

		public int totalPriceRuby;

		public bool loadFromAssetBundle;

		public string assetBundleName;

		private CarsDB cars;

		public string editorAssetPath;

		[NonSerialized]
		public CarScene sceneBehaviour;

		[NonSerialized]
		public Transform rootTransform;

		[NonSerialized]
		public bool isSceneLoaded;

		[NonSerialized]
		public string loadedSceneName;

		[NonSerialized]
		public bool isLocationSceneLoaded;

		[NonSerialized]
		public string loadedLocationSceneName;

		[NonSerialized]
		public CarLocation carLocation;

		[NonSerialized]
		public AssetBundle loadedAssetBundle;

		[NonSerialized]
		public string loadedAssetBundleName;

		public bool hasLocationScene => false;

		public string assetBundleURL => null;

		public bool isPassed => false;

		public bool isLocked => false;

		public bool isOpen => false;

		private RoomsBackend.RoomAccessor roomAccessor => null;

		public void Init(CarsDB cars)
		{
		}
	}

	public class LoadCarRequest
	{
		public Car car;

		public float progress;

		public bool isDone;

		public bool isError;

		public bool isLoadedFromAssetBundle;

		public bool isNewVersionOfGameRequired;

		public bool needsLoadingAssetBundle => false;

		public void FinishInError()
		{
		}

		public int TotalBytesToDownload()
		{
			return 0;
		}

		public LoadCarRequest(Car car)
		{
		}
	}

	private sealed class _003CLoad_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadCarRequest loadRequest;

		public CarsDB _003C_003E4__this;

		private BundleLoader _003CbundleLoader_003E5__2;

		private Car _003Ccar_003E5__3;

		private Scene _003Cscene_003E5__4;

		private bool _003CassetLoaded_003E5__5;

		private List<Car> _003Ccars_003E5__6;

		private bool _003ClocationNeedsLoading_003E5__7;

		private float _003CloadingPercentForCar_003E5__8;

		private GameObject _003ClocationGameObject_003E5__9;

		private int _003Ci_003E5__10;

		private Car _003Citem_003E5__11;

		private AsyncOperation _003CasyncWait_003E5__12;

		private BundleLoader.ManifestRequest _003CmanifestRequest_003E5__13;

		private BundleLoader.AssetBundleRequest _003CbundleRequest_003E5__14;

		private string _003CsceneName_003E5__15;

		private WWW _003Cwww_003E5__16;

		private AssetBundle _003CassetBundle_003E5__17;

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
		public _003CLoad_003Ed__23(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
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

	[SerializeField]
	public List<Car> carsList;

	private List<Car> cars_;

	[SerializeField]
	public CarCamera.BlendSettings blendSettings;

	[SerializeField]
	public ExplodeSlider.ExplosionSettings explosionSettings;

	[SerializeField]
	public List<CarSettings> carSettings;

	public CarModelSubpart.Settings subpartInSettings;

	public CarModelSubpart.BlinkSettings subpartBlinkSettings;

	public List<Car> cars => null;

	public int totalPriceForAllCars => 0;

	public int totalRubyPriceForAllCars => 0;

	public Car Active => null;

	private CarSettings GetCarSettings(string carName)
	{
		return null;
	}

	private CarCamera.Settings GetCarCamera(string carName, string cameraName)
	{
		return null;
	}

	public Car GetCar(string carName)
	{
		return null;
	}

	public Car NextCar(Car car)
	{
		return null;
	}

	public int IndexOf(Car car)
	{
		return 0;
	}

	public void UpdateData()
	{
	}

	public IEnumerator Load(LoadCarRequest loadRequest)
	{
		return null;
	}
}
