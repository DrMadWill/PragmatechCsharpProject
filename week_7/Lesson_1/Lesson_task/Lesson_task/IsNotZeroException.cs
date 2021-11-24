using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_task
{
    class IsNotZeroException:Exception
    {
        private readonly string _message;
        public IsNotZeroException(string message)
        {
            this._message = message;
        }

        public override string Message => this._message;
    }
}
