using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.DayTwo_Sub
{
    public class InvalidTravelClassException : Exception
    {
        public InvalidTravelClassException() :
            base()
        {

        }

        public InvalidTravelClassException(string message) 
            : base(message)
        {

        }
    }
}
