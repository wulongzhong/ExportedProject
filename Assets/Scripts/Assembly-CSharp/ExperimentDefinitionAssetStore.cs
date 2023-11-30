using GGOptimize;

public class ExperimentDefinitionAssetStore : ScriptableObjectSingleton<ExperimentDefinitionAssetStore>
{
	private static bool applicationIsQuitting;

	protected new static ExperimentDefinitionAssetStore instance_;

	public ExperimentsDefinition experimentsDefinition;

	public new static ExperimentDefinitionAssetStore instance => null;

	public new void OnDestroy()
	{
	}

	public ExperimentDefinitionAssetStore()
	{
        //((ScriptableObjectSingleton<>)(object)this)._002Ector();
    }
}
