using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class IsAlreadyAddedException: Exception
    {
        private readonly string _message;
        public IsAlreadyAddedException(string message)
        {
            this._message = message;
        }

        public override string Message => this._message;
    }
}
