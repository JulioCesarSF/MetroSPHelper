using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MetroSPHelper.Exceptions
{
    /// <summary>
    /// ResponseException
    /// </summary>
    public class ResponseException : Exception
    {
        /// <summary>
        /// Default
        /// </summary>
        public ResponseException()
        {
        }
        /// <summary>
        /// Constructor message
        /// </summary>
        /// <param name="message"></param>
        public ResponseException(string message) : base(message)
        {
            
        }
        /// <summary>
        /// Constructor message and response
        /// </summary>
        /// <param name="message">Message to display</param>
        /// <param name="response">Http Response object</param>
        public ResponseException(string message, HttpWebResponse response) : base(message)
        {
            message += $"\n{response.StatusCode.ToString()}";
        }
    }
}
