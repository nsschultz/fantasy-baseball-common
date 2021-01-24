using System;
using System.Runtime.Serialization;

namespace FantasyBaseball.CommonModels.Exceptions
{
    /// <summary>Exception that is thrown when there is problem with the request.</summary>
    [Serializable] public class BadRequestException : Exception
    {
        /// <summary>Initializes a new instance of the exception class with a specified error message.</summary>
        /// <param name="message">The message that describes the error.</param>
        public BadRequestException(string message) : base(message) { }

        /// <summary>Initializes a new instance of the System.Exception class with serialized data.</summary>
        /// <param name="info">
        ///     The System.Runtime.Serialization.SerializationInfo that holds the serialized
        ///     object data about the exception being thrown.
        /// </param>
        /// <param name="context">
        ///     The System.Runtime.Serialization.StreamingContext that contains contextual information
        ///     about the source or destination..
        /// </param>
        protected BadRequestException(SerializationInfo info, StreamingContext context) :  base(info, context) { }
    }
}