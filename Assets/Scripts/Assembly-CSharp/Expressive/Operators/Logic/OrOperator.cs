using Expressive.Expressions;

namespace Expressive.Operators.Logic
{
	internal class OrOperator : OperatorBase
	{
		public override string[] Tags => null;

		public override IExpression BuildExpression(Token previousToken, IExpression[] expressions, ExpressiveOptions options)
		{
			return null;
		}

		public override OperatorPrecedence GetPrecedence(Token previousToken)
		{
			return default(OperatorPrecedence);
		}
	}
}
