using System.Collections.Generic;

namespace Expressive.Expressions
{
	internal class ParenthesisedExpression : IExpression
	{
		private readonly IExpression _innerExpression;

		internal ParenthesisedExpression(IExpression innerExpression)
		{
		}

		public object Evaluate(IDictionary<string, object> variables)
		{
			return null;
		}
	}
}
