using System;
using System.Collections.Generic;
using Expressive.Expressions;
using Expressive.Functions;
using Expressive.Operators;

namespace Expressive
{
	internal sealed class ExpressionParser
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<Token, string> _003C_003E9__8_0;

			public static Func<string, bool> _003C_003E9__8_1;

			public static Func<Token, string> _003C_003E9__8_2;

			public static Func<string, bool> _003C_003E9__8_3;

			public static Func<KeyValuePair<string, IOperator>, int> _003C_003E9__25_0;

			public static Func<KeyValuePair<string, Func<IExpression[], IDictionary<string, object>, object>>, int> _003C_003E9__25_1;

			internal string _003CCompileExpression_003Eb__8_0(Token t)
			{
				return null;
			}

			internal bool _003CCompileExpression_003Eb__8_1(string t)
			{
				return false;
			}

			internal string _003CCompileExpression_003Eb__8_2(Token t)
			{
				return null;
			}

			internal bool _003CCompileExpression_003Eb__8_3(string t)
			{
				return false;
			}

			internal int _003CTokenise_003Eb__25_0(KeyValuePair<string, IOperator> op)
			{
				return 0;
			}

			internal int _003CTokenise_003Eb__25_1(KeyValuePair<string, Func<IExpression[], IDictionary<string, object>, object>> f)
			{
				return 0;
			}
		}

		private sealed class _003C_003Ec__DisplayClass10_0
		{
			public IFunction function;

			public ExpressionParser _003C_003E4__this;

			internal object _003CRegisterFunction_003Eb__0(IExpression[] p, IDictionary<string, object> a)
			{
				return null;
			}
		}

		private readonly char _decimalSeparator;

		private readonly ExpressiveOptions _options;

		private readonly IDictionary<string, Func<IExpression[], IDictionary<string, object>, object>> _registeredFunctions;

		private readonly IDictionary<string, IOperator> _registeredOperators;

		private readonly StringComparer _stringComparer;

		internal ExpressionParser(ExpressiveOptions options)
		{
		}

		internal IExpression CompileExpression(string expression, IList<string> variables)
		{
			return null;
		}

		internal void RegisterFunction(IFunction function)
		{
		}

		internal void RegisterOperator(IOperator op)
		{
		}

		private IExpression CompileExpression(Queue<Token> tokens, OperatorPrecedence minimumPrecedence, IList<string> variables, bool isWithinFunction)
		{
			return null;
		}

		private static string CleanString(string input)
		{
			return null;
		}

		private static bool CanExtractValue(string expression, int expressionLength, int index, string value)
		{
			return false;
		}

		private static bool CanGetString(string expression, int startIndex, char quoteCharacter)
		{
			return false;
		}

		private void CheckForExistingFunctionName(string functionName)
		{
		}

		private void CheckForExistingParticipant(IExpression participant, Token token, bool isWithinFunction)
		{
		}

		private static bool CheckForTag(string tag, string lookAhead, ExpressiveOptions options)
		{
			return false;
		}

		private static string ExtractValue(string expression, int expressionLength, int index, string expectedValue)
		{
			return null;
		}

		private StringComparer GetDictionaryComparer(ExpressiveOptions options)
		{
			return null;
		}

		private string GetNumber(string expression, int startIndex)
		{
			return null;
		}

		private static string GetString(string expression, int startIndex, char quoteCharacter)
		{
			return null;
		}

		private static bool IsQuote(char character)
		{
			return false;
		}

		private IList<Token> Tokenise(string expression)
		{
			return null;
		}

		private static void CheckForUnrecognised(IList<char> unrecognised, IList<Token> tokens, int index)
		{
		}
	}
}
