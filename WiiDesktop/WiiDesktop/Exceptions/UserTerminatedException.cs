using System;
using System.Runtime.Serialization;

namespace WiiDesktop.Exceptions
{
    class UserTerminatedException : ApplicationException
    {
        public UserTerminatedException() : base() {}
        public UserTerminatedException(string message) : base(message) {}
        public UserTerminatedException(string message, Exception inner) : base(message, inner) {}

        protected UserTerminatedException(SerializationInfo info, StreamingContext context)  : base(info, context){}

    }
}
