using System.Collections.Generic;

namespace Expressive.Expressions
{
	internal class VariableExpression : IExpression
	{
		private readonly string _variableName;

		internal VariableExpression(string variableName)
		{
		}

		public object Evaluate(IDictionary<string, object> variables)
		{
			return null;
		}
	}
}
