using System;
using System.Runtime.Serialization;

namespace Expressive.Exceptions
{
	[Serializable]
	public sealed class UnrecognisedTokenException : Exception
	{
		private string _003CToken_003Ek__BackingField;

		public string Token
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		internal UnrecognisedTokenException(string token)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
