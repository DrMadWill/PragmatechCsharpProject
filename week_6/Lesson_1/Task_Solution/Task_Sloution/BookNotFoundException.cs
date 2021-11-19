using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Sloution
{
    class BookNotFoundException:Exception
    {
        private string _message;
        public BookNotFoundException(string message)
        {
            _message = message;
        }

        public override string Message => _message;
    }
}
