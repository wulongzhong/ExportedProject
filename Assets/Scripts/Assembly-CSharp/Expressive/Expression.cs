using System.Collections.Generic;
using Expressive.Expressions;
using Expressive.Functions;

namespace Expressive
{
	public sealed class Expression
	{
		private IExpression _compiledExpression;

		private readonly ExpressiveOptions _options;

		private readonly string _originalExpression;

		private readonly ExpressionParser _parser;

		private string[] _variables;

		public Expression(string expression)
		{
		}

		public Expression(string expression, ExpressiveOptions options)
		{
		}

		public object Evaluate()
		{
			return null;
		}

		public object Evaluate(IDictionary<string, object> variables)
		{
			return null;
		}

		public void RegisterFunction(IFunction function)
		{
		}

		private void CompileExpression()
		{
		}
	}
}
