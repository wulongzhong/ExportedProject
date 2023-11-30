using System;
using System.Runtime.Serialization;

namespace Expressive.Exceptions
{
	[Serializable]
	public sealed class FunctionNameAlreadyRegisteredException : Exception
	{
		private string _003CName_003Ek__BackingField;

		public string Name
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		internal FunctionNameAlreadyRegisteredException(string name)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
