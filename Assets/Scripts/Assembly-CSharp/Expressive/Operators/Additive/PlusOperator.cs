using System.Collections.Generic;
using Expressive.Expressions;

namespace Expressive.Operators.Additive
{
	internal class PlusOperator : OperatorBase
	{
		public override string[] Tags => null;

		public override IExpression BuildExpression(Token previousToken, IExpression[] expressions, ExpressiveOptions options)
		{
			return null;
		}

		public override bool CanGetCaptiveTokens(Token previousToken, Token token, Queue<Token> remainingTokens)
		{
			return false;
		}

		public override Token[] GetInnerCaptiveTokens(Token[] allCaptiveTokens)
		{
			return null;
		}

		public override OperatorPrecedence GetPrecedence(Token previousToken)
		{
			return default(OperatorPrecedence);
		}

		private bool IsUnary(Token previousToken)
		{
			return false;
		}
	}
}
