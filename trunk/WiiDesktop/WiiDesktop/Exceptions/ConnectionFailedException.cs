using System;
using System.Runtime.Serialization;

namespace WiiDesktop.Exceptions
{
    class ConnectionFailedException : ApplicationException
    {
        public ConnectionFailedException() : base() {}
        public ConnectionFailedException(string message) : base(message) {}
        public ConnectionFailedException(string message, Exception inner) : base(message, inner) {}

        protected ConnectionFailedException(SerializationInfo info, StreamingContext context) : base(info, context) { }

    }
}