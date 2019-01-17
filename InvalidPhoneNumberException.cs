using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.DayOne
{
    public class InvalidPhoneNumberException : Exception
    {
        public InvalidPhoneNumberException()
            : base()
        {

        }

        public InvalidPhoneNumberException(string message)
            : base(message)
        {

        }
    }
}
