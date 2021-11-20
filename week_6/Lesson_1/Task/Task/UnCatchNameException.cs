using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class UnCatchNameException:Exception
    {
        private readonly string _message;
        public UnCatchNameException(string message)
        {
            this._message = message;
        }

        public override string Message => this._message;
    }
}
