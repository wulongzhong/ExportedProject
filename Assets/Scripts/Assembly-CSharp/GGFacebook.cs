public class GGFacebook : BehaviourSingletonInit<GGFacebook>
{
	private IFacebookProvider facebook;

	public override void Init()
	{
	}

	public void Login(FBLoginParams loginParams)
	{
	}

	public bool IsInitialized()
	{
		return false;
	}

	public GGFacebook()
	{
		//((BehaviourSingletonInit<>)(object)this)._002Ector();
	}
}
