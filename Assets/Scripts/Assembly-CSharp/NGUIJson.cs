using System.Collections;

public class NGUIJson
{
	protected static int lastErrorIndex;

	protected static string lastDecode;

	public static object jsonDecode(string json)
	{
		return null;
	}

	protected static Hashtable parseObject(char[] json, ref int index)
	{
		return null;
	}

	protected static ArrayList parseArray(char[] json, ref int index)
	{
		return null;
	}

	protected static object parseValue(char[] json, ref int index, ref bool success)
	{
		return null;
	}

	protected static string parseString(char[] json, ref int index)
	{
		return null;
	}

	protected static double parseNumber(char[] json, ref int index)
	{
		return 0.0;
	}

	protected static int getLastIndexOfNumber(char[] json, int index)
	{
		return 0;
	}

	protected static void eatWhitespace(char[] json, ref int index)
	{
	}

	protected static int lookAhead(char[] json, int index)
	{
		return 0;
	}

	protected static int nextToken(char[] json, ref int index)
	{
		return 0;
	}
}
