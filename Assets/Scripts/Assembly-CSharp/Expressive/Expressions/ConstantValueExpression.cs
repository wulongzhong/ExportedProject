using System.Collections.Generic;

namespace Expressive.Expressions
{
	internal class ConstantValueExpression : IExpression
	{
		private readonly ConstantValueExpressionType _expressionType;

		private readonly object _value;

		internal ConstantValueExpression(ConstantValueExpressionType type, object value)
		{
		}

		public object Evaluate(IDictionary<string, object> variables)
		{
			return null;
		}
	}
}
