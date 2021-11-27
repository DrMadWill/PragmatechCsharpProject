using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class IsNotZeroCountException:Exception
    {
        private readonly string _message;
        public IsNotZeroCountException(string message)
        {
            this._message = message;
        }

        public override string Message => this._message;
    }
}
