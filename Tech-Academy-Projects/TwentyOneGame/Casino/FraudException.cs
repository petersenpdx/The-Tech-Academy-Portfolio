using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Casino
{
    public class FraudException : Exception
    {
        public FraudException()
            : base() { }
        public FraudException(string message)
            : base(message) { }

    }
}