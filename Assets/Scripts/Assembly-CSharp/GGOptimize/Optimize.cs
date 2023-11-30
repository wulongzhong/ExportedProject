using System.Collections.Generic;
using ProtoModels;

namespace GGOptimize
{
	public class Optimize
	{
		public ExperimentsDefinition experimentsDefinition;

		protected ExperimentsData dataModel;

		protected List<Experiment> activeExperiments_;

		protected int userBucket => 0;

		protected ExperimentsData.ExperimentData GetExperimentData(Experiment e)
		{
			return null;
		}

		public bool IsNewUserOnExperiment(Experiment e)
		{
			return false;
		}

		public int GetUserBucket(Experiment experiment)
		{
			return 0;
		}

		protected void SetUserIsNewOnExperiment(Experiment experiment)
		{
		}

		public List<Experiment> GetActiveExperiments()
		{
			return null;
		}

		public NamedProperty GetNamedProperty(string name)
		{
			return null;
		}

		public int GetInt(string propertyName, int defaultValue)
		{
			return 0;
		}

		public bool GetBool(string propertyName, bool defaultValue)
		{
			return false;
		}

		public string GetString(string propertyName, string defaultValue)
		{
			return null;
		}

		public void Init(ExperimentsDefinition experimentsDefinition)
		{
		}
	}
}
