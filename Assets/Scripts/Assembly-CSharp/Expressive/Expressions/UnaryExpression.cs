using System.Collections.Generic;

namespace Expressive.Expressions
{
	internal class UnaryExpression : IExpression
	{
		private readonly IExpression _expression;

		private readonly UnaryExpressionType _expressionType;

		internal UnaryExpression(UnaryExpressionType type, IExpression expression)
		{
		}

		public object Evaluate(IDictionary<string, object> variables)
		{
			return null;
		}
	}
}
