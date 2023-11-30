using System.Collections.Generic;
using Expressive.Expressions;

namespace Expressive.Operators.Grouping
{
	internal class ParenthesisOpenOperator : IOperator
	{
		public string[] Tags => null;

		public IExpression BuildExpression(Token previousToken, IExpression[] expressions, ExpressiveOptions options)
		{
			return null;
		}

		public bool CanGetCaptiveTokens(Token previousToken, Token token, Queue<Token> remainingTokens)
		{
			return false;
		}

		public Token[] GetCaptiveTokens(Token previousToken, Token token, Queue<Token> remainingTokens)
		{
			return null;
		}

		public Token[] GetInnerCaptiveTokens(Token[] allCaptiveTokens)
		{
			return null;
		}

		public OperatorPrecedence GetPrecedence(Token previousToken)
		{
			return default(OperatorPrecedence);
		}
	}
}
