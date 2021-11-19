using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Sloution
{
    class SameBookAlreadyAddedException:Exception
    {
        private string _message;
        public SameBookAlreadyAddedException(string message)
        {
            _message = message;
        }

        public override string Message => _message;
    }
}
