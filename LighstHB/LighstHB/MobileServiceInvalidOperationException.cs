using System;
using System.Runtime.Serialization;

namespace LighstHB
{
    [Serializable]
    internal class MobileServiceInvalidOperationException : Exception
    {
        public MobileServiceInvalidOperationException()
        {
        }

        public MobileServiceInvalidOperationException(string message) : base(message)
        {
        }

        public MobileServiceInvalidOperationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MobileServiceInvalidOperationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public object Response { get; internal set; }
    }
}