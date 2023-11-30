using System.Collections.Generic;

namespace Expressive
{
	internal static class ExtensionMethods
	{
		internal static bool IsArithmeticOperator(string source)
		{
			return false;
		}

		internal static bool IsNumeric(string source)
		{
			return false;
		}

		internal static T PeekOrDefault<T>(Queue<T> queue)
		{
			return default(T);
		}

		internal static string SubstringUpTo(string source, int startIndex, char character)
		{
			return null;
		}
	}
}
