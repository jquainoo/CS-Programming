using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.DayOne
{
    public class InvalidEmailIdException : Exception
    {
        public InvalidEmailIdException()
            : base()
        {

        }

        public InvalidEmailIdException(string message)
            : base(message)
        {

        }
    }
}
