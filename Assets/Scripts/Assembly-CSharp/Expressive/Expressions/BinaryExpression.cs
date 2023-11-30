using System;
using System.Collections.Generic;

namespace Expressive.Expressions
{
	internal class BinaryExpression : IExpression
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<object, object, object> _003C_003E9__5_0;

			public static Func<object, object, object> _003C_003E9__5_1;

			public static Func<object, object, object> _003C_003E9__5_2;

			public static Func<object, object, object> _003C_003E9__5_3;

			public static Func<object, object, object> _003C_003E9__5_4;

			public static Func<object, object, object> _003C_003E9__5_12;

			public static Func<object, object, object> _003C_003E9__5_5;

			public static Func<object, object, object> _003C_003E9__5_6;

			public static Func<object, object, object> _003C_003E9__5_7;

			public static Func<object, object, object> _003C_003E9__5_8;

			public static Func<object, object, object> _003C_003E9__5_9;

			public static Func<object, object, object> _003C_003E9__5_10;

			public static Func<object, object, object> _003C_003E9__5_11;

			internal object _003CEvaluate_003Eb__5_0(object l, object r)
			{
				return null;
			}

			internal object _003CEvaluate_003Eb__5_1(object l, object r)
			{
				return null;
			}

			internal object _003CEvaluate_003Eb__5_2(object l, object r)
			{
				return null;
			}

			internal object _003CEvaluate_003Eb__5_3(object l, object r)
			{
				return null;
			}

			internal object _003CEvaluate_003Eb__5_4(object l, object r)
			{
				return null;
			}

			internal object _003CEvaluate_003Eb__5_12(object l, object r)
			{
				return null;
			}

			internal object _003CEvaluate_003Eb__5_5(object l, object r)
			{
				return null;
			}

			internal object _003CEvaluate_003Eb__5_6(object l, object r)
			{
				return null;
			}

			internal object _003CEvaluate_003Eb__5_7(object l, object r)
			{
				return null;
			}

			internal object _003CEvaluate_003Eb__5_8(object l, object r)
			{
				return null;
			}

			internal object _003CEvaluate_003Eb__5_9(object l, object r)
			{
				return null;
			}

			internal object _003CEvaluate_003Eb__5_10(object l, object r)
			{
				return null;
			}

			internal object _003CEvaluate_003Eb__5_11(object l, object r)
			{
				return null;
			}
		}

		private readonly BinaryExpressionType _expressionType;

		private readonly IExpression _leftHandSide;

		private readonly ExpressiveOptions _options;

		private readonly IExpression _rightHandSide;

		internal BinaryExpression(BinaryExpressionType type, IExpression lhs, IExpression rhs, ExpressiveOptions options)
		{
		}

		public object Evaluate(IDictionary<string, object> variables)
		{
			return null;
		}

		private static bool IsReal(object value)
		{
			return false;
		}

		private object Evaluate(object lhsResult, IExpression rhs, IDictionary<string, object> variables, Func<object, object, object> resultSelector)
		{
			return null;
		}
	}
}
