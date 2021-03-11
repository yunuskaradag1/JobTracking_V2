using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core.Exceptions
{
    public class ClearMessageException : Exception
    {
        public string ClearMessage { get; set; }

        public override string Message
        {
            get
            {
                return ClearMessage;
            }
        }

        public ClearMessageException(string message)
        {
            ClearMessage = message;
        }
    }
}
