using System;
using System.Runtime.Serialization;

namespace SOLID.LSP
{
    [Serializable]
    public class CannotSwimException : Exception
    {
        public CannotSwimException()
        {
        }

        public CannotSwimException(string message) : base(message)
        {
        }

        public CannotSwimException(string message, Exception inner) : base(message, inner)
        {
        }

        protected CannotSwimException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}