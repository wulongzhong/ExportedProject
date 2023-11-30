using System;

namespace Expressive.Exceptions
{
	[Serializable]
	public sealed class ExpressiveException : Exception
	{
		internal ExpressiveException(string message)
		{
		}

		internal ExpressiveException(Exception innerException)
		{
		}
	}
}
