using System.Collections.Generic;
using Expressive.Expressions;

namespace Expressive.Operators
{
	internal abstract class OperatorBase : IOperator
	{
		public abstract string[] Tags { get; }

		public abstract IExpression BuildExpression(Token previousToken, IExpression[] expressions, ExpressiveOptions options);

		public virtual bool CanGetCaptiveTokens(Token previousToken, Token token, Queue<Token> remainingTokens)
		{
			return false;
		}

		public virtual Token[] GetCaptiveTokens(Token previousToken, Token token, Queue<Token> remainingTokens)
		{
			return null;
		}

		public virtual Token[] GetInnerCaptiveTokens(Token[] allCaptiveTokens)
		{
			return null;
		}

		public abstract OperatorPrecedence GetPrecedence(Token previousToken);
	}
}
