using System;
using Expressive.Expressions;

namespace Expressive.Functions.Statistical
{
	internal class MedianFunction : FunctionBase
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<decimal, decimal> _003C_003E9__3_0;

			internal decimal _003CMedian_003Eb__3_0(decimal x)
			{
				return default(decimal);
			}
		}

		public override string Name => null;

		public override object Evaluate(IExpression[] parameters, ExpressiveOptions options)
		{
			return null;
		}

		private decimal Median(decimal[] xs)
		{
			return default(decimal);
		}
	}
}
