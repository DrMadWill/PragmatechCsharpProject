using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace Lesson
{
    static class MyExtensions
    {
        public static bool IsEmail(this string name)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(name);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;

            }
        }
    }
}
