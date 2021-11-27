using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class NotNullOrEmptyException:Exception
    {
        private readonly string _message;
        public NotNullOrEmptyException(string message)
        {
            this._message = message;
        }

        public override string Message => this._message;
    }
}
