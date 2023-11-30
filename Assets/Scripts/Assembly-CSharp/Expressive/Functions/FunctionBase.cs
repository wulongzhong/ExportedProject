using System.Collections.Generic;
using Expressive.Expressions;

namespace Expressive.Functions
{
	internal abstract class FunctionBase : IFunction
	{
		private IDictionary<string, object> _003CVariables_003Ek__BackingField;

		public IDictionary<string, object> Variables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public abstract string Name { get; }

		public abstract object Evaluate(IExpression[] parameters, ExpressiveOptions options);

		protected bool ValidateParameterCount(IExpression[] parameters, int expectedCount, int minimumCount)
		{
			return false;
		}
	}
}
