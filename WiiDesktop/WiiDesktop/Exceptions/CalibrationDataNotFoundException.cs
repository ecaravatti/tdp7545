using System;
using System.Runtime.Serialization;

namespace WiiDesktop.Exceptions
{
    class CalibrationDataNotFoundException : ApplicationException
    {
        public CalibrationDataNotFoundException() : base() {}
        public CalibrationDataNotFoundException(string message) : base(message) {}
        public CalibrationDataNotFoundException(string message, Exception inner) : base(message, inner) {}

        protected CalibrationDataNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }

    }
}
