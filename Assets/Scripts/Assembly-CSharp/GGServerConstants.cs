using UnityEngine;

public class GGServerConstants : ScriptableObject
{
	private static GGServerConstants instance_;

	[SerializeField]
	private string constantsName;

	public string privateKey;

	public string publicKey;

	public string appName;

	public string urlBase;

	public int leadVersion;

	public string nonceUrlPath;

	public string timeUrlPath;

	public string leadUrlPath;

	public string updateUrlPath;

	public string getIdUrlPath;

	public string getPrizesUrlPath;

	public string ackPrizesUrlPath;

	public string getActiveCompetitionUrlPath;

	public string getCloudSyncUrlPath;

	public string updateCloudSyncUrlPath;

	public string FBLoginUrlPath;

	public string FBInvitableFriendsPath;

	public string PlayerProfilePath;

	public string FBPlayingFriendsPath;

	public string PlayerGetMessagesPath;

	public string MarkMessageReadPath;

	public string getFriendProfilesPath;

	public string getSegmentedLeaderboards;

	public string verifyInAppPurchases;

	public string exchangeCurrencyPath;

	public string getOnlineEventsPath;

	public string getOnlineEventsLeaderboardsPath;

	public string updateOnlineEventsPath;

	public string likeReplayPath;

	public string getPositionPath;

	public string getPlayerPositionList;

	public string uploadLeadDataPath;

	public string getAppMessagesPath;

	public string getEventMessagesPath;

	public string updateAppMessagesPath;

	public string createUserChallengePath;

	public string getUserChallengePath;

	public string getChallengesForPlayerPath;

	public string userChallengeReportScorePath;

	public string likeUserChallengesPath;

	public string rateUserChallengesPath;

	public string getSingleChallengePath;

	public string userChallengeIncrementDownloadCountPath;

	public string createChallengeReportPath;

	public int fbInvitePagesToFetch;

	public int maxEntriesPerLead;

	public static GGServerConstants instance => null;

	public string verifyInAppPurchasesUrl => null;
}
