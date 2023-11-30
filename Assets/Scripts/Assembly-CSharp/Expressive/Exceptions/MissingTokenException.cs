using System;
using System.Runtime.Serialization;

namespace Expressive.Exceptions
{
	[Serializable]
	public sealed class MissingTokenException : Exception
	{
		private char _003CMissingToken_003Ek__BackingField;

		public char MissingToken
		{
			get
			{
				return '\0';
			}
			private set
			{
			}
		}

		internal MissingTokenException(string message, char missingToken)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
