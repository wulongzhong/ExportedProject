using System.Collections.Generic;
using GGOptimize;

public class GGAB : SingletonInit<GGAB>
{
	public Optimize optimize;

	public override void Init()
	{
	}

	public static int GetInt(string propertyName, int defaultValue)
	{
		return 0;
	}

	public static bool GetBool(string propertyName, bool defaultValue)
	{
		return false;
	}

	public static string GetString(string propertyName, string defaultValue)
	{
		return null;
	}

	public static List<Experiment> GetActiveExperiments()
	{
		return null;
	}

	public GGAB()
	{
        //((SingletonInit<>)(object)this)._002Ector();
    }
}
