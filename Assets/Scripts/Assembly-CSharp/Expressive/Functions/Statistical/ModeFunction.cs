using System;
using System.Linq;
using Expressive.Expressions;

namespace Expressive.Functions.Statistical
{
	internal class ModeFunction : FunctionBase
	{
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			public int maxCount;

			internal bool _003CEvaluate_003Eb__2(IGrouping<object, object> g)
			{
				return false;
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<object, object> _003C_003E9__2_0;

			public static Func<IGrouping<object, object>, int> _003C_003E9__2_1;

			internal object _003CEvaluate_003Eb__2_0(object v)
			{
				return null;
			}

			internal int _003CEvaluate_003Eb__2_1(IGrouping<object, object> g)
			{
				return 0;
			}
		}

		public override string Name => null;

		public override object Evaluate(IExpression[] parameters, ExpressiveOptions options)
		{
			return null;
		}
	}
}
