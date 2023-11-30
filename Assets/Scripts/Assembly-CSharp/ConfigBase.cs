using UnityEngine;
using UnityEngine.Audio;

public class ConfigBase : ScriptableObject
{
	public enum GGFileIOCloudSyncTypes
	{
		WhisperSync = 0,
		GGCloudSync = 1,
		GGSaveLocalOnly = 2,
		GGSnapshotCloudSync = 3
	}

	public enum SocialProvider
	{
		GooglePlayServices = 0,
		AmazonGameCircle = 1
	}

	public enum InAppProvider
	{
		GooglePlayServices = 0,
		AmazonInApp = 1
	}

	[SerializeField]
	public bool loaidMainConfigFromFile;

	public GGGameName gameName;

	[SerializeField]
	private bool isDebug;

	public bool changeChipOnDevice;

	public bool isTestingSettingsScreen;

	public bool allowStockpiling;

	public bool overrideEnergyDurationOnlyIfBigger;

	[SerializeField]
	private bool isDebugOnDevice;

	[SerializeField]
	public bool useSinglePlayerSettings;

	public bool returnSameMatchServerAppNameWhenDebug;

	public bool showTotalEarningsOnWinningScreen;

	public bool useProfilePictureInMultiplayer;

	public bool useDeck;

	public bool useAddaptiveAIOnMultiplayer;

	public bool fakePlayerId;

	public string playerId;

	public bool useFakeFacebookPlayerId;

	public string fakeFacebookPlayerId;

	public bool useFakeApplePlayerId;

	public string fakeApplePlayerId;

	public string facebookAppId;

	public string facebookAppPlayerSuffix;

	public string facebookLoginPermissions;

	public string facebookMockResponse;

	public string facebookDisplayName;

	public string facebookTestAccessToken;

	public string experimentsResourceName;

	public float cloudSyncTimeDelay;

	public float cloudSyncTimeDelayWhenRequestFails;

	public int maxSyncFrequency;

	public Material adsMaterial;

	public bool secureCurrency;

	public string styleName;

	public string appNameOverrideForPrint;

	public string appName;

	public string inAppAdsName;

	public string matchServerUrl;

	public string matchServerApp;

	public int maxDisconnects;

	public string rankingsServerUrl;

	public string rankingsApp;

	public string iosAppId;

	public string proVersionPackage;

	public bool usingProfileData;

	public string activeConfig;

	public bool usingNewPhoton;

	public string activeConfigIOS;

	public string activeConfigWinRT;

	public bool tournamentsOnlyAvailableInPro;

	public bool noWaitingInPro;

	public string leaderboardId;

	public bool isProVersion;

	public bool canUseRate;

	public bool gameCenterAvailable;

	[SerializeField]
	private string rateProvider;

	public bool verifyPlayInApp;

	public bool testingInAppPurchases;

	public bool useGiftiz;

	public bool allDifficultiesInPro;

	public bool canUseFacebook;

	public string menuSceneName;

	public bool useGuestForNonLoggedInUsers;

	public bool showUpdatedPrivacyPolicyNotice;

	public int minVersionThatHasUpdatedPrivacyPolicy;

	public bool onlyShowNoticeIfUserLoggedIntoFacebook;

	public bool canChangeCuesMidGame;

	public bool updateSpinControlFromCueSpin;

	public GGFileIOCloudSyncTypes cloudSyncType;

	public string gameCenterCategory;

	public string mopubId;

	public string suggestionUrl;

	public string bugReportUrl;

	public SocialProvider socialProvider;

	public InAppProvider inAppProvider;

	public string interstitialAdId;

	public string amazonAppKey;

	public bool noAdsOnPromotionDay;

	public int initialCoins;

	public int initialStars;

	public int initialRuby;

	public int promotionCoins;

	public string promotionStart;

	public string promotionEnd;

	public string promotionMessage;

	private static ConfigBase _instance;

	public int notificationLatestTime;

	public int notificationEarliestTime;

	public AudioMixer masterMixer;

	public int minAudioVal;

	public int maxAudioVal;

	public int initialVolumeLevel;

	public int initialPlayerVersion;

	public string facebookError;

	public float multiplayerSkillPointsScale;

	public float multiplayerSkillPointsOffset;

	public int coinsCap;

	public int tokensCap;

	public int ggDollarsCap;

	public int ggRubyCap;

	public int eloCap;

	public int freeCoins;

	public int coinsForLike;

	public bool hasLootBoxes;

	[SerializeField]
	public bool useRubiesAsCarPartsCurrencyType;

	public CurrencyType freeCoinsCurrencyType;

	public bool overrideTimeForFreeCoins;

	public float freeCoinsTimeHours;

	[SerializeField]
	private bool GGOfficialUserEnabled_;

	public string GGofficialUserName;

	public string GGOfficialImageURL;

	public bool debug => false;

	public bool isFakePlayerIdOn => false;

	public string printAppName => null;

	public string platformRateProvider => null;

	public bool shouldShowAmazonAds => false;

	public bool isProVersionEnabled => false;

	public bool isProVersionAvailable => false;

	public static ConfigBase instance => null;

	public CurrencyType carPartsCurrencyType => default(CurrencyType);

	public bool GGOfficialUserEnabled => false;

	public bool IsSyncEnabledInCurrentScene()
	{
		return false;
	}

	public string GetSuggestionUrl(string playerName, string appName, string pid = "")
	{
		return null;
	}

	public string GetBugReportUrl(string playerName, string appName, string pid = "")
	{
		return null;
	}

	public void SetAudioMixerValues(GGPlayerSettings playerSettings)
	{
	}

	public string GetMatchServerAppName()
	{
		return null;
	}
}
