using System;
using System.Collections.Generic;

namespace Expressive.Expressions
{
	internal class FunctionExpression : IExpression
	{
		private readonly Func<IExpression[], IDictionary<string, object>, object> _function;

		private readonly string _name;

		private readonly IExpression[] _parameters;

		internal FunctionExpression(string name, Func<IExpression[], IDictionary<string, object>, object> function, IExpression[] parameters)
		{
		}

		public object Evaluate(IDictionary<string, object> variables)
		{
			return null;
		}
	}
}
