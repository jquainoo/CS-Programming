using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.DayTwo_Sub
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException() :
            base()
        {

        }

        public InvalidAgeException(string message) 
            : base(message)
        {

        }
    }
}
