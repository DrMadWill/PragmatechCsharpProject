using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class IsNotZeroPriceException:Exception
    {
        private readonly string _message;
        public IsNotZeroPriceException(string message)
        {
            this._message = message;
        }

        public override string Message => this._message;
    }
}
